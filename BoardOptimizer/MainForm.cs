using System.Text.Json;

namespace BoardOptimizer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;

				this.WindowState = FormWindowState.Minimized;
				this.MainNotifyIcon.Visible = true;
				this.Hide();
				return;
			}
		}

		private void MainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.MainNotifyIcon.Visible=false;
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}
	}
}
