using System.Text.Json;
using System.Windows.Forms;

namespace BoardOptimizer
{
    public partial class MainForm : Form
    {
        internal MissionManager manager = new MissionManager();
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
            this.MainNotifyIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddMission_Click(object sender, EventArgs e)
        {
            AddMission AddWindow = new AddMission(this);
            AddWindow.Show();

            //MissionList.Items.Add(manager.missions[-1]);
        }

        private void MissionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = MissionList.SelectedItem.ToString();
        }
    }
}
