﻿namespace VisualSAIStudio
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatureSAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameobjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areatriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timedActionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.emptySAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.setEntryorguidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSAITypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.scratch1 = new VisualSAIStudio.Scratch();
            this.vS2012ToolStripExtender1 = new VisualSAIStudio.VS2012ToolStripExtender(this.components);
            this.changeDBSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.generateWholeSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.dBCToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1684, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromDBToolStripMenuItem,
            this.toolStripMenuItem2,
            this.setEntryorguidToolStripMenuItem,
            this.setSAITypeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.validateToolStripMenuItem,
            this.generateSQLToolStripMenuItem,
            this.generateWholeSQLToolStripMenuItem,
            this.toolStripMenuItem4,
            this.changeDBSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromDBToolStripMenuItem
            // 
            this.loadFromDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatureSAIToolStripMenuItem,
            this.gameobjectToolStripMenuItem,
            this.areatriggerToolStripMenuItem,
            this.timedActionListToolStripMenuItem,
            this.toolStripMenuItem3,
            this.emptySAIToolStripMenuItem});
            this.loadFromDBToolStripMenuItem.Name = "loadFromDBToolStripMenuItem";
            this.loadFromDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFromDBToolStripMenuItem.Text = "Load from DB";
            // 
            // creatureSAIToolStripMenuItem
            // 
            this.creatureSAIToolStripMenuItem.Name = "creatureSAIToolStripMenuItem";
            this.creatureSAIToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.creatureSAIToolStripMenuItem.Text = "Creature";
            this.creatureSAIToolStripMenuItem.Click += new System.EventHandler(this.creatureSAIToolStripMenuItem_Click);
            // 
            // gameobjectToolStripMenuItem
            // 
            this.gameobjectToolStripMenuItem.Name = "gameobjectToolStripMenuItem";
            this.gameobjectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.gameobjectToolStripMenuItem.Text = "Gameobject";
            this.gameobjectToolStripMenuItem.Click += new System.EventHandler(this.gameobjectToolStripMenuItem_Click);
            // 
            // areatriggerToolStripMenuItem
            // 
            this.areatriggerToolStripMenuItem.Name = "areatriggerToolStripMenuItem";
            this.areatriggerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.areatriggerToolStripMenuItem.Text = "Areatrigger";
            this.areatriggerToolStripMenuItem.Click += new System.EventHandler(this.areatriggerToolStripMenuItem_Click);
            // 
            // timedActionListToolStripMenuItem
            // 
            this.timedActionListToolStripMenuItem.Name = "timedActionListToolStripMenuItem";
            this.timedActionListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.timedActionListToolStripMenuItem.Text = "Timed action list";
            this.timedActionListToolStripMenuItem.Click += new System.EventHandler(this.timedActionListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // emptySAIToolStripMenuItem
            // 
            this.emptySAIToolStripMenuItem.Name = "emptySAIToolStripMenuItem";
            this.emptySAIToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.emptySAIToolStripMenuItem.Text = "Empty SAI";
            this.emptySAIToolStripMenuItem.Click += new System.EventHandler(this.emptySAIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // setEntryorguidToolStripMenuItem
            // 
            this.setEntryorguidToolStripMenuItem.Name = "setEntryorguidToolStripMenuItem";
            this.setEntryorguidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setEntryorguidToolStripMenuItem.Text = "Set entry or guid";
            this.setEntryorguidToolStripMenuItem.Click += new System.EventHandler(this.setEntryorguidToolStripMenuItem_Click);
            // 
            // setSAITypeToolStripMenuItem
            // 
            this.setSAITypeToolStripMenuItem.Name = "setSAITypeToolStripMenuItem";
            this.setSAITypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setSAITypeToolStripMenuItem.Text = "Set SAI Type";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.validateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validateToolStripMenuItem.Text = "Validate";
            this.validateToolStripMenuItem.Click += new System.EventHandler(this.validateToolStripMenuItem_Click);
            // 
            // generateSQLToolStripMenuItem
            // 
            this.generateSQLToolStripMenuItem.Name = "generateSQLToolStripMenuItem";
            this.generateSQLToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.generateSQLToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.generateSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateSQLToolStripMenuItem.Text = "Generate SQL";
            this.generateSQLToolStripMenuItem.Click += new System.EventHandler(this.generateSQLToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click_1);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.targetsToolStripMenuItem,
            this.conditionsToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.errorsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click);
            // 
            // targetsToolStripMenuItem
            // 
            this.targetsToolStripMenuItem.Name = "targetsToolStripMenuItem";
            this.targetsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.targetsToolStripMenuItem.Text = "Targets";
            this.targetsToolStripMenuItem.Click += new System.EventHandler(this.targetsToolStripMenuItem_Click);
            // 
            // conditionsToolStripMenuItem
            // 
            this.conditionsToolStripMenuItem.Name = "conditionsToolStripMenuItem";
            this.conditionsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.conditionsToolStripMenuItem.Text = "Conditions";
            this.conditionsToolStripMenuItem.Click += new System.EventHandler(this.conditionsToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // errorsToolStripMenuItem
            // 
            this.errorsToolStripMenuItem.Name = "errorsToolStripMenuItem";
            this.errorsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.errorsToolStripMenuItem.Text = "Warnings";
            this.errorsToolStripMenuItem.Click += new System.EventHandler(this.errorsToolStripMenuItem_Click);
            // 
            // dBCToolStripMenuItem
            // 
            this.dBCToolStripMenuItem.Name = "dBCToolStripMenuItem";
            this.dBCToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dBCToolStripMenuItem.Text = "DBC";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DockBottomPortion = 0.2D;
            this.dockPanel1.DockLeftPortion = 0.2D;
            this.dockPanel1.DockRightPortion = 0.2D;
            this.dockPanel1.DockTopPortion = 0.2D;
            this.dockPanel1.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel1.Location = new System.Drawing.Point(0, 24);
            this.dockPanel1.Name = "dockPanel1";
            //this.dockPanel1.Theme = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
            this.dockPanel1.TabIndex = 12;
            this.dockPanel1.ActiveDocumentChanged += new System.EventHandler(this.dockPanel1_ActiveDocumentChanged);
            // 
            // scratch1
            // 
            this.scratch1.AllowDrop = true;
            this.scratch1.AutoSize = true;
            this.scratch1.BackColor = System.Drawing.Color.White;
            this.scratch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scratch1.Location = new System.Drawing.Point(0, 0);
            this.scratch1.Name = "scratch1";
            this.scratch1.Size = new System.Drawing.Size(859, 390);
            this.scratch1.TabIndex = 1;
            // 
            // vS2012ToolStripExtender1
            // 
            this.vS2012ToolStripExtender1.DefaultRenderer = null;
            this.vS2012ToolStripExtender1.VS2012Renderer = null;
            // 
            // changeDBSettingsToolStripMenuItem
            // 
            this.changeDBSettingsToolStripMenuItem.Name = "changeDBSettingsToolStripMenuItem";
            this.changeDBSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeDBSettingsToolStripMenuItem.Text = "Change DB settings";
            this.changeDBSettingsToolStripMenuItem.Click += new System.EventHandler(this.changeDBSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // generateWholeSQLToolStripMenuItem
            // 
            this.generateWholeSQLToolStripMenuItem.Name = "generateWholeSQLToolStripMenuItem";
            this.generateWholeSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateWholeSQLToolStripMenuItem.Text = "Generate whole SQL";
            this.generateWholeSQLToolStripMenuItem.Click += new System.EventHandler(this.generateWholeSQLToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1054);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Visual SAI Studio by bandysc";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Scratch scratch1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromDBToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem targetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
        private VS2012ToolStripExtender vS2012ToolStripExtender1;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSAITypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatureSAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameobjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areatriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timedActionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem emptySAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem setEntryorguidToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateWholeSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem changeDBSettingsToolStripMenuItem;
    }
}

