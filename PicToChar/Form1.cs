using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicToChar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("请先拖拽图片文件到窗口中！");
				return;
			}

			char[] chars = new char[] { 'M', 'Q', 'H', 'N', 'O', 'S', '2', 'C', '?', ')', '>', '!', ':', ',', '.' };
			StringBuilder sb = new StringBuilder();
			string html_head = "<!DOCTYPE html><html><body style = \"font-family: Monospace;font-size: 2px;line-height: 50%;\">";
			string html_tail = "</body></html>";
			sb.Append(html_head);

			Bitmap bmp = (Bitmap)pictureBox1.Image;
			int p_fac = Convert.ToInt32(textBox1.Text); //最大像素个数
			double w_fac = Convert.ToDouble(textBox3.Text); //宽度因子
			double c_fac = Convert.ToDouble(textBox2.Text); //对比度因子
			bool binarization = false;
			int binary_threshold = 127;
			int m = Math.Max(bmp.Height, (int)(bmp.Width * w_fac));
			double delta = Math.Max(m * 1.0 / p_fac, 1);
			int w = (int)((int)(bmp.Width * w_fac) / delta);
			int h = (int)(bmp.Height / delta);

			FiltersSequence filter = new FiltersSequence();

			filter.Add(new ResizeNearestNeighbor(w, h));

			if (checkBox1.Checked)
			{
				filter.Add(new HistogramEqualization());
			}

			if (checkBox2.Checked)
			{
				filter.Add(new Sharpen());
			}

			if (checkBox3.Checked)
			{
				binarization = true;
			}

			using (Bitmap newbmp = filter.Apply(bmp))
			{
				if (binarization)
				{
					ImageStatisticsYCbCr stat = new ImageStatisticsYCbCr(newbmp);
					ContinuousHistogram y = stat.Y;
					binary_threshold = (int)(y.Mean * 162);
				}
				BitmapData bmpData =
					newbmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

				unsafe
				{
					byte* ptr = (byte*)(bmpData.Scan0);
					int tmp;
					for (int y = 0; y < h; y++)
					{
						for (int x = 0; x < w; x++)
						{
							tmp = ptr[1];
							tmp = (int)((tmp - 127) * c_fac + 127);
							tmp = tmp < 0 ? 0 : (tmp > 255 ? 255 : tmp);
							int l = (int)(0.299 * ptr[2] + 0.587 * tmp + 0.114 * ptr[0]);
							if (binarization)
							{
								l = l > binary_threshold ? 255 : 0;
							}
							sb.Append(chars[l * 14 / 255]);
							ptr += 3;
						}
						sb.Append("<br/>");
						ptr += bmpData.Stride - bmpData.Width * 3;
					}
				}
				newbmp.UnlockBits(bmpData);
			}
			sb.Append(html_tail);

			string tempFile = Path.GetTempFileName() + ".html";
			File.WriteAllText(tempFile, sb.ToString().Replace("...", ".. "));
			System.Diagnostics.Process.Start(tempFile);
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string filename = (e.Data.GetData(DataFormats.FileDrop, false) as string[])[0];
			try
			{
				pictureBox1.ImageLocation = filename;
			}
			catch
			{
				MessageBox.Show("不支持该文件格式！");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = hScrollBar1.Value.ToString();
			textBox2.Text = (hScrollBar2.Value * 1.0 / 100 + 1).ToString();
			textBox3.Text = (hScrollBar3.Value * 1.0 / 100 + 1).ToString();
		}

		private void hScrollBar1_MouseCaptureChanged(object sender, EventArgs e)
		{
			textBox1.Text = hScrollBar1.Value.ToString();
		}

		private void hScrollBar2_MouseCaptureChanged(object sender, EventArgs e)
		{
			textBox2.Text = (hScrollBar2.Value * 1.0 / 100 + 1).ToString();
		}

		private void hScrollBar3_MouseCaptureChanged(object sender, EventArgs e)
		{
			textBox3.Text = (hScrollBar3.Value * 1.0 / 100 + 1).ToString();
		}
	}
}
