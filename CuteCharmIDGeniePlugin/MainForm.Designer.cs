using System;
namespace CuteCharmIDGeniePlugin {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            this.gb_ShinyGroups = new System.Windows.Forms.GroupBox();
            this.rb_ShinyGroup4 = new System.Windows.Forms.RadioButton();
            this.rb_ShinyGroup3 = new System.Windows.Forms.RadioButton();
            this.rb_ShinyGroup2 = new System.Windows.Forms.RadioButton();
            this.rb_ShinyGroup1 = new System.Windows.Forms.RadioButton();
            this.pb_ShinyGroup4 = new System.Windows.Forms.PictureBox();
            this.pb_ShinyGroup3 = new System.Windows.Forms.PictureBox();
            this.pb_ShinyGroup2 = new System.Windows.Forms.PictureBox();
            this.pb_ShinyGroup1 = new System.Windows.Forms.PictureBox();
            this.gb_RandomChoice = new System.Windows.Forms.GroupBox();
            this.rb_Choose = new System.Windows.Forms.RadioButton();
            this.rb_RandomPure = new System.Windows.Forms.RadioButton();
            this.rb_RandomFixed = new System.Windows.Forms.RadioButton();
            this.lklb_Update = new System.Windows.Forms.LinkLabel();
            this.bt_Calculate = new System.Windows.Forms.Button();
            this.lb_TID = new System.Windows.Forms.Label();
            this.lb_SID = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cb_LeadList = new System.Windows.Forms.ComboBox();
            this.cb_GameList = new System.Windows.Forms.ComboBox();
            this.gb_TrainerID = new System.Windows.Forms.GroupBox();
            this.nud_TrainerID = new System.Windows.Forms.NumericUpDown();
            this.rb_ChooseTID = new System.Windows.Forms.RadioButton();
            this.rb_RandomTID = new System.Windows.Forms.RadioButton();
            this.pb_Donate = new System.Windows.Forms.PictureBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.lb_By = new System.Windows.Forms.Label();
            this.lklb_Author = new System.Windows.Forms.LinkLabel();
            this.lb_Lead = new System.Windows.Forms.Label();
            this.lb_Game = new System.Windows.Forms.Label();
            this.lb_TIDValue = new System.Windows.Forms.Label();
            this.lb_SIDValue = new System.Windows.Forms.Label();
            this.gb_ShinyGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup1)).BeginInit();
            this.gb_RandomChoice.SuspendLayout();
            this.gb_TrainerID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TrainerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Donate)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ShinyGroups
            // 
            this.gb_ShinyGroups.Controls.Add(this.rb_ShinyGroup4);
            this.gb_ShinyGroups.Controls.Add(this.rb_ShinyGroup3);
            this.gb_ShinyGroups.Controls.Add(this.rb_ShinyGroup2);
            this.gb_ShinyGroups.Controls.Add(this.rb_ShinyGroup1);
            this.gb_ShinyGroups.Controls.Add(this.pb_ShinyGroup4);
            this.gb_ShinyGroups.Controls.Add(this.pb_ShinyGroup3);
            this.gb_ShinyGroups.Controls.Add(this.pb_ShinyGroup2);
            this.gb_ShinyGroups.Controls.Add(this.pb_ShinyGroup1);
            this.gb_ShinyGroups.Location = new System.Drawing.Point(16, 96);
            this.gb_ShinyGroups.Name = "gb_ShinyGroups";
            this.gb_ShinyGroups.Size = new System.Drawing.Size(453, 206);
            this.gb_ShinyGroups.TabIndex = 1;
            this.gb_ShinyGroups.TabStop = false;
            this.gb_ShinyGroups.Text = "Shiny Group";
            // 
            // rb_ShinyGroup4
            // 
            this.rb_ShinyGroup4.AutoSize = true;
            this.rb_ShinyGroup4.Location = new System.Drawing.Point(384, 17);
            this.rb_ShinyGroup4.Name = "rb_ShinyGroup4";
            this.rb_ShinyGroup4.Size = new System.Drawing.Size(14, 13);
            this.rb_ShinyGroup4.TabIndex = 8;
            this.rb_ShinyGroup4.UseVisualStyleBackColor = true;
            this.rb_ShinyGroup4.CheckedChanged += new System.EventHandler(this.Rb_ShinyGroup4_CheckedChanged);
            // 
            // rb_ShinyGroup3
            // 
            this.rb_ShinyGroup3.AutoSize = true;
            this.rb_ShinyGroup3.Location = new System.Drawing.Point(274, 17);
            this.rb_ShinyGroup3.Name = "rb_ShinyGroup3";
            this.rb_ShinyGroup3.Size = new System.Drawing.Size(14, 13);
            this.rb_ShinyGroup3.TabIndex = 7;
            this.rb_ShinyGroup3.UseVisualStyleBackColor = true;
            this.rb_ShinyGroup3.CheckedChanged += new System.EventHandler(this.Rb_ShinyGroup3_CheckedChanged);
            // 
            // rb_ShinyGroup2
            // 
            this.rb_ShinyGroup2.AutoSize = true;
            this.rb_ShinyGroup2.Location = new System.Drawing.Point(164, 17);
            this.rb_ShinyGroup2.Name = "rb_ShinyGroup2";
            this.rb_ShinyGroup2.Size = new System.Drawing.Size(14, 13);
            this.rb_ShinyGroup2.TabIndex = 6;
            this.rb_ShinyGroup2.UseVisualStyleBackColor = true;
            this.rb_ShinyGroup2.CheckedChanged += new System.EventHandler(this.Rb_ShinyGroup2_CheckedChanged);
            // 
            // rb_ShinyGroup1
            // 
            this.rb_ShinyGroup1.AutoSize = true;
            this.rb_ShinyGroup1.Checked = true;
            this.rb_ShinyGroup1.Location = new System.Drawing.Point(54, 17);
            this.rb_ShinyGroup1.Name = "rb_ShinyGroup1";
            this.rb_ShinyGroup1.Size = new System.Drawing.Size(14, 13);
            this.rb_ShinyGroup1.TabIndex = 5;
            this.rb_ShinyGroup1.TabStop = true;
            this.rb_ShinyGroup1.UseVisualStyleBackColor = true;
            this.rb_ShinyGroup1.CheckedChanged += new System.EventHandler(this.Rb_ShinyGroup1_CheckedChanged);
            // 
            // pb_ShinyGroup4
            // 
            this.pb_ShinyGroup4.BackgroundImage = global::CuteCharmIDGeniePlugin.Properties.Resources.sg;
            this.pb_ShinyGroup4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ShinyGroup4.Location = new System.Drawing.Point(336, 36);
            this.pb_ShinyGroup4.Name = "pb_ShinyGroup4";
            this.pb_ShinyGroup4.Size = new System.Drawing.Size(111, 162);
            this.pb_ShinyGroup4.TabIndex = 3;
            this.pb_ShinyGroup4.TabStop = false;
            this.pb_ShinyGroup4.Click += new System.EventHandler(this.Rb_ShinyGroup4_CheckedChanged);
            // 
            // pb_ShinyGroup3
            // 
            this.pb_ShinyGroup3.BackgroundImage = global::CuteCharmIDGeniePlugin.Properties.Resources.sg;
            this.pb_ShinyGroup3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ShinyGroup3.Location = new System.Drawing.Point(226, 36);
            this.pb_ShinyGroup3.Name = "pb_ShinyGroup3";
            this.pb_ShinyGroup3.Size = new System.Drawing.Size(111, 162);
            this.pb_ShinyGroup3.TabIndex = 2;
            this.pb_ShinyGroup3.TabStop = false;
            this.pb_ShinyGroup3.Click += new System.EventHandler(this.Rb_ShinyGroup3_CheckedChanged);
            // 
            // pb_ShinyGroup2
            // 
            this.pb_ShinyGroup2.BackgroundImage = global::CuteCharmIDGeniePlugin.Properties.Resources.sg;
            this.pb_ShinyGroup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ShinyGroup2.Location = new System.Drawing.Point(116, 36);
            this.pb_ShinyGroup2.Name = "pb_ShinyGroup2";
            this.pb_ShinyGroup2.Size = new System.Drawing.Size(111, 162);
            this.pb_ShinyGroup2.TabIndex = 1;
            this.pb_ShinyGroup2.TabStop = false;
            this.pb_ShinyGroup2.Click += new System.EventHandler(this.Rb_ShinyGroup2_CheckedChanged);
            // 
            // pb_ShinyGroup1
            // 
            this.pb_ShinyGroup1.BackColor = System.Drawing.SystemColors.Control;
            this.pb_ShinyGroup1.BackgroundImage = global::CuteCharmIDGeniePlugin.Properties.Resources.sg;
            this.pb_ShinyGroup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ShinyGroup1.Location = new System.Drawing.Point(6, 36);
            this.pb_ShinyGroup1.Name = "pb_ShinyGroup1";
            this.pb_ShinyGroup1.Size = new System.Drawing.Size(111, 162);
            this.pb_ShinyGroup1.TabIndex = 0;
            this.pb_ShinyGroup1.TabStop = false;
            this.pb_ShinyGroup1.Click += new System.EventHandler(this.Rb_ShinyGroup1_CheckedChanged);
            // 
            // gb_RandomChoice
            // 
            this.gb_RandomChoice.Controls.Add(this.rb_Choose);
            this.gb_RandomChoice.Controls.Add(this.rb_RandomPure);
            this.gb_RandomChoice.Controls.Add(this.rb_RandomFixed);
            this.gb_RandomChoice.Location = new System.Drawing.Point(16, 61);
            this.gb_RandomChoice.Name = "gb_RandomChoice";
            this.gb_RandomChoice.Size = new System.Drawing.Size(453, 34);
            this.gb_RandomChoice.TabIndex = 5;
            this.gb_RandomChoice.TabStop = false;
            this.gb_RandomChoice.Text = "Shiny Group Selection";
            this.ToolTip1.SetToolTip(this.gb_RandomChoice, "Choose how Shiny Group is chosen");
            // 
            // rb_Choose
            // 
            this.rb_Choose.AutoSize = true;
            this.rb_Choose.Location = new System.Drawing.Point(369, 12);
            this.rb_Choose.Name = "rb_Choose";
            this.rb_Choose.Size = new System.Drawing.Size(61, 17);
            this.rb_Choose.TabIndex = 2;
            this.rb_Choose.TabStop = true;
            this.rb_Choose.Text = "Choose";
            this.rb_Choose.UseVisualStyleBackColor = true;
            this.rb_Choose.CheckedChanged += new System.EventHandler(this.Rb_Choose_CheckedChanged);
            // 
            // rb_RandomPure
            // 
            this.rb_RandomPure.AutoSize = true;
            this.rb_RandomPure.Location = new System.Drawing.Point(181, 12);
            this.rb_RandomPure.Name = "rb_RandomPure";
            this.rb_RandomPure.Size = new System.Drawing.Size(128, 17);
            this.rb_RandomPure.TabIndex = 1;
            this.rb_RandomPure.TabStop = true;
            this.rb_RandomPure.Text = "Random (w/ Group 4)";
            this.rb_RandomPure.UseVisualStyleBackColor = true;
            // 
            // rb_RandomFixed
            // 
            this.rb_RandomFixed.AutoSize = true;
            this.rb_RandomFixed.Location = new System.Drawing.Point(11, 12);
            this.rb_RandomFixed.Name = "rb_RandomFixed";
            this.rb_RandomFixed.Size = new System.Drawing.Size(134, 17);
            this.rb_RandomFixed.TabIndex = 0;
            this.rb_RandomFixed.TabStop = true;
            this.rb_RandomFixed.Text = "Random (w/o Group 4)";
            this.rb_RandomFixed.UseVisualStyleBackColor = true;
            // 
            // lklb_Update
            // 
            this.lklb_Update.AutoSize = true;
            this.lklb_Update.Location = new System.Drawing.Point(1, 4);
            this.lklb_Update.Name = "lklb_Update";
            this.lklb_Update.Size = new System.Drawing.Size(116, 13);
            this.lklb_Update.TabIndex = 6;
            this.lklb_Update.TabStop = true;
            this.lklb_Update.Text = "New Update Available!";
            this.ToolTip1.SetToolTip(this.lklb_Update, "new Features! Download the new version");
            this.lklb_Update.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lklb_Update_LinkClicked);
            // 
            // bt_Calculate
            // 
            this.bt_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calculate.Location = new System.Drawing.Point(242, 308);
            this.bt_Calculate.Name = "bt_Calculate";
            this.bt_Calculate.Size = new System.Drawing.Size(103, 33);
            this.bt_Calculate.TabIndex = 7;
            this.bt_Calculate.Text = "Calculate";
            this.ToolTip1.SetToolTip(this.bt_Calculate, "Calculates IDs");
            this.bt_Calculate.UseVisualStyleBackColor = true;
            this.bt_Calculate.Click += new System.EventHandler(this.Bt_Calculate_Click);
            // 
            // lb_TID
            // 
            this.lb_TID.AutoSize = true;
            this.lb_TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TID.Location = new System.Drawing.Point(13, 308);
            this.lb_TID.Name = "lb_TID";
            this.lb_TID.Size = new System.Drawing.Size(39, 18);
            this.lb_TID.TabIndex = 9;
            this.lb_TID.Text = "TID: ";
            // 
            // lb_SID
            // 
            this.lb_SID.AutoSize = true;
            this.lb_SID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SID.Location = new System.Drawing.Point(116, 308);
            this.lb_SID.Name = "lb_SID";
            this.lb_SID.Size = new System.Drawing.Size(40, 18);
            this.lb_SID.TabIndex = 10;
            this.lb_SID.Text = "SID: ";
            // 
            // cb_LeadList
            // 
            this.cb_LeadList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LeadList.FormattingEnabled = true;
            this.cb_LeadList.Items.AddRange(new object[] {
            "Male (Any% ♀)",
            "Female (87.5% ♂)",
            "Female (75% ♂)",
            "Female (50% ♂)",
            "Female (25% ♂)"});
            this.cb_LeadList.Location = new System.Drawing.Point(16, 36);
            this.cb_LeadList.Name = "cb_LeadList";
            this.cb_LeadList.Size = new System.Drawing.Size(108, 21);
            this.cb_LeadList.TabIndex = 19;
            this.ToolTip1.SetToolTip(this.cb_LeadList, "Choose the gender of your Cute Charm Lead");
            this.cb_LeadList.SelectedIndexChanged += new System.EventHandler(this.Cb_LeadList_SelectedIndexChanged);
            // 
            // cb_GameList
            // 
            this.cb_GameList.BackColor = System.Drawing.SystemColors.Window;
            this.cb_GameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GameList.FormattingEnabled = true;
            this.cb_GameList.Items.AddRange(new object[] {
            "Diamond/Pearl",
            "Platinum",
            "HeartGold/SoulSilver"});
            this.cb_GameList.Location = new System.Drawing.Point(133, 36);
            this.cb_GameList.Name = "cb_GameList";
            this.cb_GameList.Size = new System.Drawing.Size(139, 21);
            this.cb_GameList.TabIndex = 21;
            this.ToolTip1.SetToolTip(this.cb_GameList, "Select the game you are going to use");
            // 
            // gb_TrainerID
            // 
            this.gb_TrainerID.Controls.Add(this.nud_TrainerID);
            this.gb_TrainerID.Controls.Add(this.rb_ChooseTID);
            this.gb_TrainerID.Controls.Add(this.rb_RandomTID);
            this.gb_TrainerID.Location = new System.Drawing.Point(280, 28);
            this.gb_TrainerID.Name = "gb_TrainerID";
            this.gb_TrainerID.Size = new System.Drawing.Size(189, 34);
            this.gb_TrainerID.TabIndex = 23;
            this.gb_TrainerID.TabStop = false;
            this.gb_TrainerID.Text = "Trainer ID";
            this.ToolTip1.SetToolTip(this.gb_TrainerID, "Choose a specific TID or not");
            // 
            // nud_TrainerID
            // 
            this.nud_TrainerID.Location = new System.Drawing.Point(111, 10);
            this.nud_TrainerID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_TrainerID.Name = "nud_TrainerID";
            this.nud_TrainerID.Size = new System.Drawing.Size(56, 20);
            this.nud_TrainerID.TabIndex = 2;
            // 
            // rb_ChooseTID
            // 
            this.rb_ChooseTID.AutoSize = true;
            this.rb_ChooseTID.Location = new System.Drawing.Point(95, 12);
            this.rb_ChooseTID.Name = "rb_ChooseTID";
            this.rb_ChooseTID.Size = new System.Drawing.Size(28, 17);
            this.rb_ChooseTID.TabIndex = 1;
            this.rb_ChooseTID.TabStop = true;
            this.rb_ChooseTID.Text = " ";
            this.rb_ChooseTID.UseVisualStyleBackColor = true;
            this.rb_ChooseTID.CheckedChanged += new System.EventHandler(this.Rb_ChooseTID_CheckedChanged);
            // 
            // rb_RandomTID
            // 
            this.rb_RandomTID.AutoSize = true;
            this.rb_RandomTID.Location = new System.Drawing.Point(17, 12);
            this.rb_RandomTID.Name = "rb_RandomTID";
            this.rb_RandomTID.Size = new System.Drawing.Size(65, 17);
            this.rb_RandomTID.TabIndex = 0;
            this.rb_RandomTID.TabStop = true;
            this.rb_RandomTID.Text = "Random";
            this.rb_RandomTID.UseVisualStyleBackColor = true;
            this.rb_RandomTID.CheckedChanged += new System.EventHandler(this.Rb_RandomTID_CheckedChanged);
            // 
            // pb_Donate
            // 
            this.pb_Donate.BackColor = System.Drawing.SystemColors.Control;
            this.pb_Donate.BackgroundImage = global::CuteCharmIDGeniePlugin.Properties.Resources.ppdb;
            this.pb_Donate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Donate.Location = new System.Drawing.Point(406, 2);
            this.pb_Donate.Name = "pb_Donate";
            this.pb_Donate.Size = new System.Drawing.Size(80, 22);
            this.pb_Donate.TabIndex = 17;
            this.pb_Donate.TabStop = false;
            this.ToolTip1.SetToolTip(this.pb_Donate, "Donate and help incentivise me to develop more");
            this.pb_Donate.Click += new System.EventHandler(this.Pb_Donate_Click);
            this.pb_Donate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_Donate_MouseDown);
            this.pb_Donate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_Donate_MouseUp);
            // 
            // bt_Save
            // 
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(366, 308);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(103, 33);
            this.bt_Save.TabIndex = 27;
            this.bt_Save.Text = "Save";
            this.ToolTip1.SetToolTip(this.bt_Save, "Saves IDs");
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // lb_By
            // 
            this.lb_By.AutoSize = true;
            this.lb_By.Location = new System.Drawing.Point(2, 336);
            this.lb_By.Name = "lb_By";
            this.lb_By.Size = new System.Drawing.Size(19, 13);
            this.lb_By.TabIndex = 15;
            this.lb_By.Text = "By";
            // 
            // lklb_Author
            // 
            this.lklb_Author.AutoSize = true;
            this.lklb_Author.Location = new System.Drawing.Point(17, 336);
            this.lklb_Author.Name = "lklb_Author";
            this.lklb_Author.Size = new System.Drawing.Size(47, 13);
            this.lklb_Author.TabIndex = 16;
            this.lklb_Author.TabStop = true;
            this.lklb_Author.Text = "Regnum";
            this.lklb_Author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lklb_Author_LinkClicked);
            // 
            // lb_Lead
            // 
            this.lb_Lead.AutoSize = true;
            this.lb_Lead.Location = new System.Drawing.Point(14, 23);
            this.lb_Lead.Name = "lb_Lead";
            this.lb_Lead.Size = new System.Drawing.Size(34, 13);
            this.lb_Lead.TabIndex = 18;
            this.lb_Lead.Text = "Lead:";
            // 
            // lb_Game
            // 
            this.lb_Game.AutoSize = true;
            this.lb_Game.Location = new System.Drawing.Point(132, 23);
            this.lb_Game.Name = "lb_Game";
            this.lb_Game.Size = new System.Drawing.Size(38, 13);
            this.lb_Game.TabIndex = 22;
            this.lb_Game.Text = "Game:";
            // 
            // lb_TIDValue
            // 
            this.lb_TIDValue.AutoSize = true;
            this.lb_TIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TIDValue.Location = new System.Drawing.Point(43, 308);
            this.lb_TIDValue.Name = "lb_TIDValue";
            this.lb_TIDValue.Size = new System.Drawing.Size(17, 18);
            this.lb_TIDValue.TabIndex = 25;
            this.lb_TIDValue.Text = "0";
            // 
            // lb_SIDValue
            // 
            this.lb_SIDValue.AutoSize = true;
            this.lb_SIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SIDValue.Location = new System.Drawing.Point(146, 308);
            this.lb_SIDValue.Name = "lb_SIDValue";
            this.lb_SIDValue.Size = new System.Drawing.Size(17, 18);
            this.lb_SIDValue.TabIndex = 26;
            this.lb_SIDValue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 351);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.lb_SIDValue);
            this.Controls.Add(this.lb_TIDValue);
            this.Controls.Add(this.gb_TrainerID);
            this.Controls.Add(this.lb_Game);
            this.Controls.Add(this.cb_GameList);
            this.Controls.Add(this.cb_LeadList);
            this.Controls.Add(this.lb_Lead);
            this.Controls.Add(this.pb_Donate);
            this.Controls.Add(this.lb_SID);
            this.Controls.Add(this.lb_TID);
            this.Controls.Add(this.bt_Calculate);
            this.Controls.Add(this.lklb_Update);
            this.Controls.Add(this.gb_ShinyGroups);
            this.Controls.Add(this.gb_RandomChoice);
            this.Controls.Add(this.lklb_Author);
            this.Controls.Add(this.lb_By);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cute Charm Glitch ID Generator";
            this.gb_ShinyGroups.ResumeLayout(false);
            this.gb_ShinyGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShinyGroup1)).EndInit();
            this.gb_RandomChoice.ResumeLayout(false);
            this.gb_RandomChoice.PerformLayout();
            this.gb_TrainerID.ResumeLayout(false);
            this.gb_TrainerID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TrainerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Donate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gb_ShinyGroups;
        public System.Windows.Forms.PictureBox pb_ShinyGroup2;
        public System.Windows.Forms.PictureBox pb_ShinyGroup1;
        public System.Windows.Forms.PictureBox pb_ShinyGroup4;
        public System.Windows.Forms.PictureBox pb_ShinyGroup3;
        public System.Windows.Forms.RadioButton rb_ShinyGroup4;
        public System.Windows.Forms.RadioButton rb_ShinyGroup3;
        public System.Windows.Forms.RadioButton rb_ShinyGroup2;
        public System.Windows.Forms.RadioButton rb_ShinyGroup1;
        public System.Windows.Forms.GroupBox gb_RandomChoice;
        public System.Windows.Forms.RadioButton rb_Choose;
        public System.Windows.Forms.RadioButton rb_RandomPure;
        public System.Windows.Forms.RadioButton rb_RandomFixed;
        public System.Windows.Forms.LinkLabel lklb_Update;
        public System.Windows.Forms.Button bt_Calculate;
        public System.Windows.Forms.Label lb_TID;
        public System.Windows.Forms.Label lb_SID;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Label lb_By;
        public System.Windows.Forms.LinkLabel lklb_Author;
        public System.Windows.Forms.PictureBox pb_Donate;
        public System.Windows.Forms.Label lb_Lead;
        public System.Windows.Forms.ComboBox cb_LeadList;
        public System.Windows.Forms.ComboBox cb_GameList;
        public System.Windows.Forms.Label lb_Game;
        public System.Windows.Forms.GroupBox gb_TrainerID;
        public System.Windows.Forms.NumericUpDown nud_TrainerID;
        public System.Windows.Forms.RadioButton rb_ChooseTID;
        public System.Windows.Forms.RadioButton rb_RandomTID;
        public System.Windows.Forms.Label lb_TIDValue;
        public System.Windows.Forms.Label lb_SIDValue;
        public System.Windows.Forms.Button bt_Save;
    }
}

