namespace BoardOptimizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			MissionPage = new TabPage();
			splitContainer1 = new SplitContainer();
			label1 = new Label();
			MissionList = new ListBox();
			groupBox1 = new GroupBox();
			checkBox_enabled = new CheckBox();
			MenuTabControl = new TabControl();
			MainNotifyIcon = new NotifyIcon(components);
			MainNotifyContextMenuStip = new ContextMenuStrip(components);
			退出ToolStripMenuItem = new ToolStripMenuItem();
			MissionPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			groupBox1.SuspendLayout();
			MenuTabControl.SuspendLayout();
			MainNotifyContextMenuStip.SuspendLayout();
			SuspendLayout();
			// 
			// MissionPage
			// 
			MissionPage.Controls.Add(splitContainer1);
			resources.ApplyResources(MissionPage, "MissionPage");
			MissionPage.Name = "MissionPage";
			MissionPage.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			resources.ApplyResources(splitContainer1, "splitContainer1");
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Panel1.Controls.Add(MissionList);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(groupBox1);
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// MissionList
			// 
			resources.ApplyResources(MissionList, "MissionList");
			MissionList.FormattingEnabled = true;
			MissionList.Name = "MissionList";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(checkBox_enabled);
			resources.ApplyResources(groupBox1, "groupBox1");
			groupBox1.Name = "groupBox1";
			groupBox1.TabStop = false;
			// 
			// checkBox_enabled
			// 
			resources.ApplyResources(checkBox_enabled, "checkBox_enabled");
			checkBox_enabled.Name = "checkBox_enabled";
			checkBox_enabled.UseVisualStyleBackColor = true;
			// 
			// MenuTabControl
			// 
			MenuTabControl.Controls.Add(MissionPage);
			resources.ApplyResources(MenuTabControl, "MenuTabControl");
			MenuTabControl.Name = "MenuTabControl";
			MenuTabControl.SelectedIndex = 0;
			// 
			// MainNotifyIcon
			// 
			resources.ApplyResources(MainNotifyIcon, "MainNotifyIcon");
			MainNotifyIcon.MouseDoubleClick += MainNotifyIcon_MouseDoubleClick;
			// 
			// MainNotifyContextMenuStip
			// 
			MainNotifyContextMenuStip.Items.AddRange(new ToolStripItem[] { 退出ToolStripMenuItem });
			MainNotifyContextMenuStip.Name = "MainNotifyContextMenuStip";
			resources.ApplyResources(MainNotifyContextMenuStip, "MainNotifyContextMenuStip");
			// 
			// 退出ToolStripMenuItem
			// 
			退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			resources.ApplyResources(退出ToolStripMenuItem, "退出ToolStripMenuItem");
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(MenuTabControl);
			Name = "MainForm";
			FormClosing += MainForm_FormClosing;
			MissionPage.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			MenuTabControl.ResumeLayout(false);
			MainNotifyContextMenuStip.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabPage MissionPage;
		private SplitContainer splitContainer1;
		private Label label1;
		private ListBox MissionList;
		private GroupBox groupBox1;
		private TabControl MenuTabControl;
		private CheckBox checkBox_enabled;
		private NotifyIcon MainNotifyIcon;
		private ContextMenuStrip MainNotifyContextMenuStip;
		private ToolStripMenuItem 退出ToolStripMenuItem;
	}
}
