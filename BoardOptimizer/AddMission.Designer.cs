namespace BoardOptimizer
{
    partial class AddMission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            TxtInstructionBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TriggerTypeBox = new ComboBox();
            label1 = new Label();
            NameBox = new TextBox();
            checkBox_enabled = new CheckBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(TxtInstructionBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TriggerTypeBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(NameBox);
            groupBox1.Controls.Add(checkBox_enabled);
            groupBox1.Font = new Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(668, 430);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "属性";
            // 
            // button2
            // 
            button2.Font = new Font("HarmonyOS Sans SC", 12F);
            button2.Location = new Point(420, 327);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 10;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("HarmonyOS Sans SC", 12F);
            button1.Location = new Point(102, 327);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 9;
            button1.Text = "创建";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(277, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 54);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(133, 11);
            maskedTextBox1.Mask = "90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(121, 31);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(107, 24);
            label4.TabIndex = 1;
            label4.Text = "TriggerTime";
            label4.Click += label4_Click;
            // 
            // TxtInstructionBox
            // 
            TxtInstructionBox.Location = new Point(9, 169);
            TxtInstructionBox.Multiline = true;
            TxtInstructionBox.Name = "TxtInstructionBox";
            TxtInstructionBox.ScrollBars = ScrollBars.Both;
            TxtInstructionBox.Size = new Size(625, 106);
            TxtInstructionBox.TabIndex = 7;
            TxtInstructionBox.TextChanged += TxtInstructionBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(9, 132);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 6;
            label3.Text = "操作";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(9, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 5;
            label2.Text = "触发类型";
            // 
            // TriggerTypeBox
            // 
            TriggerTypeBox.FormattingEnabled = true;
            TriggerTypeBox.Items.AddRange(new object[] { "时间", "事件" });
            TriggerTypeBox.Location = new Point(93, 82);
            TriggerTypeBox.Name = "TriggerTypeBox";
            TriggerTypeBox.Size = new Size(120, 32);
            TriggerTypeBox.TabIndex = 4;
            TriggerTypeBox.SelectedIndexChanged += TriggerTypeBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 3;
            label1.Text = "名称";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(59, 32);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(154, 31);
            NameBox.TabIndex = 2;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // checkBox_enabled
            // 
            checkBox_enabled.AutoSize = true;
            checkBox_enabled.Font = new Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBox_enabled.ImeMode = ImeMode.NoControl;
            checkBox_enabled.Location = new Point(277, 34);
            checkBox_enabled.Margin = new Padding(4);
            checkBox_enabled.Name = "checkBox_enabled";
            checkBox_enabled.Size = new Size(68, 28);
            checkBox_enabled.TabIndex = 0;
            checkBox_enabled.Text = "启用";
            checkBox_enabled.UseVisualStyleBackColor = true;
            checkBox_enabled.CheckedChanged += checkBox_enabled_CheckedChanged;
            // 
            // AddMission
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(groupBox1);
            Name = "AddMission";
            Text = "AddMission";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox NameBox;
        private CheckBox checkBox_enabled;
        private Label label1;
        private Label label2;
        private ComboBox TriggerTypeBox;
        private TextBox TxtInstructionBox;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Button button2;
    }
}