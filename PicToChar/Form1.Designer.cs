namespace PicToChar
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(14, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(385, 301);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(167, 409);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 40);
			this.button2.TabIndex = 3;
			this.button2.Text = "转换成字符";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(167, 332);
			this.hScrollBar1.Maximum = 1545;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(232, 17);
			this.hScrollBar1.TabIndex = 4;
			this.hScrollBar1.Value = 256;
			this.hScrollBar1.MouseCaptureChanged += new System.EventHandler(this.hScrollBar1_MouseCaptureChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 337);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "允许最大像素：";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(107, 332);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(45, 21);
			this.textBox1.TabIndex = 6;
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(167, 357);
			this.hScrollBar2.Maximum = 509;
			this.hScrollBar2.Minimum = -100;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(232, 17);
			this.hScrollBar2.TabIndex = 4;
			this.hScrollBar2.MouseCaptureChanged += new System.EventHandler(this.hScrollBar2_MouseCaptureChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 362);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "对比增强系数：";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(107, 357);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(45, 21);
			this.textBox2.TabIndex = 6;
			// 
			// hScrollBar3
			// 
			this.hScrollBar3.Location = new System.Drawing.Point(167, 382);
			this.hScrollBar3.Maximum = 509;
			this.hScrollBar3.Minimum = -100;
			this.hScrollBar3.Name = "hScrollBar3";
			this.hScrollBar3.Size = new System.Drawing.Size(232, 17);
			this.hScrollBar3.TabIndex = 4;
			this.hScrollBar3.MouseCaptureChanged += new System.EventHandler(this.hScrollBar3_MouseCaptureChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 387);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "宽度增加比例：";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(107, 382);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(45, 21);
			this.textBox3.TabIndex = 6;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 409);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 16);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "直方图均衡化";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(12, 433);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(48, 16);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "锐化";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(66, 433);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(60, 16);
			this.checkBox3.TabIndex = 7;
			this.checkBox3.Text = "二值化";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 456);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.hScrollBar3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.hScrollBar2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "图片转字符";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.HScrollBar hScrollBar3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
	}
}

