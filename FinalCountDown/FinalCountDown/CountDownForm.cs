using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalCountDown {
	public partial class CountDownForm: Form {
		private int RemainingSeconds;
		System.Media.SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.beep_alarm);
		public CountDownForm() {
			InitializeComponent();
			Screen[] Screens = Screen.AllScreens;
			if (Screens.Length > 1) {
				Location = Screens[1].Bounds.Location;
			}
			Player.LoadAsync();
		}

		public void SetLogo(Image img) {
			picR.Image = img;
		}

		public void SetCountDownStartTime(int Seconds) {
			RemainingSeconds = Seconds;
			lblCountDown.Text = string.Format("{0}:{1:00}", RemainingSeconds / 60, RemainingSeconds % 60);
		}

		private void timerCountDown_Tick(object sender, EventArgs e) {
			if (RemainingSeconds > 0) {
				RemainingSeconds--;
			} else {
				Player.Play();
				timerCountDown.Stop();
			}
			lblCountDown.Text = string.Format("{0}:{1:00}", RemainingSeconds / 60, RemainingSeconds % 60);
		}

		public void StartCounting() {
			timerCountDown.Start();
		}

		public void SetRound(int Round) {
			lblRound.Text = Round.ToString();
		}

		public void SetTitle(string title) {
			lblTitle.Text = title;
		}

		protected override CreateParams CreateParams { //改善載入UI時的殘像感
			get {
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}
	}
}
