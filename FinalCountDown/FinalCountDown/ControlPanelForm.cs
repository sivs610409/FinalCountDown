using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalCountDown {
	public partial class BtnStartCount: Form {
		CountDownForm objCountDownForm = new CountDownForm();
		public BtnStartCount() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			btnShowForm.PerformClick();
			objCountDownForm.StartCounting();
		}

		private void btnBrowseImage_Click(object sender, EventArgs e) {
			OpenFileDialog OpenImageDialog = new OpenFileDialog();
			if (OpenImageDialog.ShowDialog() == DialogResult.OK) {

				try {
					Image Picture = Image.FromFile(OpenImageDialog.FileName);
					txtImagePath.Text = OpenImageDialog.FileName;
					objCountDownForm.SetLogo(Picture);
				} catch {
					MessageBox.Show("請選擇正確的圖檔!", "Open Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void numTime_ValueChanged(object sender, EventArgs e) {
			objCountDownForm.SetCountDownStartTime((int) (numMinute.Value * 60 + numSecond.Value));
		}

		private void numRound_ValueChanged(object sender, EventArgs e) {
			objCountDownForm.SetRound((int) numRound.Value);
		}

		private void btnShowForm_Click(object sender, EventArgs e) {
			if (objCountDownForm.Visible == true) {
				objCountDownForm.SetCountDownStartTime((int) (numMinute.Value * 60 + numSecond.Value));
				objCountDownForm.SetTitle(txtTitle.Text);
				objCountDownForm.SetRound((int) numRound.Value);
			}
			objCountDownForm.Show();
		}

		private void txtTitle_TextChanged(object sender, EventArgs e) {
			objCountDownForm.SetTitle(txtTitle.Text);
		}
	}
}
