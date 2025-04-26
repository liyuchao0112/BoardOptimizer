using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BoardOptimizer
{
    public partial class AddMission : Form
    {
        public MainForm mainForm;
        public AddMission(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Mission mission = new Mission();
            mission.name = "ai";
            mainForm.MissionList.Items.Add(mission.name);
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
        }



        private void TriggerTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = (string)TriggerTypeBox.SelectedItem;
            if (selectedType == "时间")
            {
                panel1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Action = TxtInstructionBox.Text;
            bool Is_enabled = checkBox_enabled.Checked;
            Mission New_Mission = new Mission();
            New_Mission.id = mainForm.MissionList.Items.Count;
            New_Mission.name = NameBox.Text;
            New_Mission.Triggertime = maskedTextBox1.Text;
            mainForm.manager.missions.Append(New_Mission);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TxtInstructionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_enabled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
