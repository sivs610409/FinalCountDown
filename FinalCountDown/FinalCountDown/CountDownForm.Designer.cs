namespace FinalCountDown {
	partial class CountDownForm {
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountDownForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblCountDown = new System.Windows.Forms.Label();
			this.timerCountDown = new System.Windows.Forms.Timer(this.components);
			this.picR = new System.Windows.Forms.PictureBox();
			this.lblRound = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.picR, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblCountDown, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblRound, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 768);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("標楷體", 50F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(344, 10);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(677, 227);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "標題文字";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCountDown
			// 
			this.lblCountDown.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblCountDown, 2);
			this.lblCountDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblCountDown.Font = new System.Drawing.Font("DSEG7 Modern", 200F);
			this.lblCountDown.ForeColor = System.Drawing.Color.White;
			this.lblCountDown.Location = new System.Drawing.Point(0, 262);
			this.lblCountDown.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
			this.lblCountDown.Name = "lblCountDown";
			this.lblCountDown.Size = new System.Drawing.Size(682, 267);
			this.lblCountDown.TabIndex = 2;
			this.lblCountDown.Text = "0:00";
			this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timerCountDown
			// 
			this.timerCountDown.Interval = 1000;
			this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
			// 
			// picR
			// 
			this.picR.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picR.Location = new System.Drawing.Point(3, 13);
			this.picR.Name = "picR";
			this.picR.Size = new System.Drawing.Size(335, 221);
			this.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picR.TabIndex = 5;
			this.picR.TabStop = false;
			// 
			// lblRound
			// 
			this.lblRound.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblRound.Font = new System.Drawing.Font("DSEG7 Modern", 90.99999F);
			this.lblRound.ForeColor = System.Drawing.Color.Red;
			this.lblRound.Image = ((System.Drawing.Image)(resources.GetObject("lblRound.Image")));
			this.lblRound.Location = new System.Drawing.Point(682, 257);
			this.lblRound.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.lblRound.Name = "lblRound";
			this.lblRound.Size = new System.Drawing.Size(342, 256);
			this.lblRound.TabIndex = 3;
			this.lblRound.Text = "1";
			this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CountDownForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CountDownForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblCountDown;
		private System.Windows.Forms.Timer timerCountDown;
		private System.Windows.Forms.PictureBox picR;
		private System.Windows.Forms.Label lblRound;
	}
}

