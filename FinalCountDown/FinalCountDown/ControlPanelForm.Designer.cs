namespace FinalCountDown {
	partial class BtnStartCount {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.button1 = new System.Windows.Forms.Button();
			this.txtImagePath = new System.Windows.Forms.TextBox();
			this.btnBrowseImage = new System.Windows.Forms.Button();
			this.numMinute = new System.Windows.Forms.NumericUpDown();
			this.numSecond = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numRound = new System.Windows.Forms.NumericUpDown();
			this.btnShowForm = new System.Windows.Forms.Button();
			this.txtTitle = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRound)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(371, 368);
			this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 51);
			this.button1.TabIndex = 0;
			this.button1.Text = "開始計數";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtImagePath
			// 
			this.txtImagePath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtImagePath.Location = new System.Drawing.Point(24, 90);
			this.txtImagePath.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.txtImagePath.Name = "txtImagePath";
			this.txtImagePath.Size = new System.Drawing.Size(443, 35);
			this.txtImagePath.TabIndex = 1;
			this.txtImagePath.Text = "請選擇Logo圖片路徑→";
			this.txtImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnBrowseImage
			// 
			this.btnBrowseImage.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBrowseImage.Location = new System.Drawing.Point(481, 81);
			this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.btnBrowseImage.Name = "btnBrowseImage";
			this.btnBrowseImage.Size = new System.Drawing.Size(60, 51);
			this.btnBrowseImage.TabIndex = 2;
			this.btnBrowseImage.Text = "...";
			this.btnBrowseImage.UseVisualStyleBackColor = true;
			this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
			// 
			// numMinute
			// 
			this.numMinute.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numMinute.Location = new System.Drawing.Point(160, 192);
			this.numMinute.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.numMinute.Name = "numMinute";
			this.numMinute.Size = new System.Drawing.Size(92, 35);
			this.numMinute.TabIndex = 3;
			this.numMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numMinute.ValueChanged += new System.EventHandler(this.numTime_ValueChanged);
			// 
			// numSecond
			// 
			this.numSecond.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numSecond.Location = new System.Drawing.Point(310, 192);
			this.numSecond.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.numSecond.Name = "numSecond";
			this.numSecond.Size = new System.Drawing.Size(92, 35);
			this.numSecond.TabIndex = 4;
			this.numSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numSecond.ValueChanged += new System.EventHandler(this.numTime_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(264, 195);
			this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 27);
			this.label1.TabIndex = 5;
			this.label1.Text = "：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(26, 294);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 27);
			this.label2.TabIndex = 6;
			this.label2.Text = "回合(紅色的數字)：";
			// 
			// numRound
			// 
			this.numRound.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numRound.Location = new System.Drawing.Point(234, 292);
			this.numRound.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.numRound.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.numRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numRound.Name = "numRound";
			this.numRound.Size = new System.Drawing.Size(92, 35);
			this.numRound.TabIndex = 8;
			this.numRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numRound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numRound.ValueChanged += new System.EventHandler(this.numRound_ValueChanged);
			// 
			// btnShowForm
			// 
			this.btnShowForm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowForm.Location = new System.Drawing.Point(187, 368);
			this.btnShowForm.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.btnShowForm.Name = "btnShowForm";
			this.btnShowForm.Size = new System.Drawing.Size(170, 51);
			this.btnShowForm.TabIndex = 10;
			this.btnShowForm.Text = "顯示計數視窗";
			this.btnShowForm.UseVisualStyleBackColor = true;
			this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtTitle.Location = new System.Drawing.Point(24, 27);
			this.txtTitle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(515, 35);
			this.txtTitle.TabIndex = 11;
			this.txtTitle.Text = "標題文字";
			this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
			// 
			// BtnStartCount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 434);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.btnShowForm);
			this.Controls.Add(this.numRound);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numSecond);
			this.Controls.Add(this.numMinute);
			this.Controls.Add(this.btnBrowseImage);
			this.Controls.Add(this.txtImagePath);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Name = "BtnStartCount";
			this.Text = "ControlPanel";
			((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRound)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtImagePath;
		private System.Windows.Forms.Button btnBrowseImage;
		private System.Windows.Forms.NumericUpDown numMinute;
		private System.Windows.Forms.NumericUpDown numSecond;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numRound;
		private System.Windows.Forms.Button btnShowForm;
		private System.Windows.Forms.TextBox txtTitle;
	}
}