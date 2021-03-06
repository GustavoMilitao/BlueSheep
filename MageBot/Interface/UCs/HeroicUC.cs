﻿namespace MageBot.Interface
{
    using MageBot.Core.Heroic;
    using MageBot.Util.Enums.Internal;
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Windows.Input;

    public class HeroicUC : MetroFramework.Controls.MetroUserControl
    {
        /// <summary>
        /// Represents the heroic mode tab of the main accountUC.
        /// </summary>

        #region Fields
        private IContainer components = null;
        private TextBox AllianceTxtBAgro;
        private SadikButton addAllianceAgro;
        private SadikLabel sadikLabel2;
        private NumericUpDown NUDLvlAgroMin;
        private NumericUpDown NUDLvlAgroMax;
        private SadikCheckbox sadikCheckbox1;
        public ListView LViewAgro;
        private GroupBox groupBox3;
        private SadikButton addAllianceRun;
        private TextBox AllianceTxtBRun;
        private SadikCombo UsedItem;
        private ListView LViewRun;
        private SadikLabel sadikLabel3;
        private SadikLabel sadikLabel4;
        private NumericUpDown NUDLvlRunMin;
        private NumericUpDown NUDLvlRunMax;
        private SadikRadioButton Disconnecting;
        private SadikRadioButton UsingItem;
        private SadikCheckbox sadikCheckbox2;
        private SadikLabel sadikLabel1;
        private GroupBox groupBox2;
        private SadikTabControl sadikTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private AccountUC accUserControl;
        private int[] SubAreaId = new int[] { 0x5f, 0x60, 0x61, 0x62, 0xad, 0x65 };
        #endregion

        #region Constructors
        public HeroicUC(AccountUC Account)
        {
            InitializeComponent();
            accUserControl = Account;
            accUserControl.Account.Heroic = new Heroic(accUserControl.Account);
        }
        #endregion

        #region Public Methods
        public void FillRecoveredConfig()
        {
            sadikCheckbox1.Checked = accUserControl.Account.Config.AgroConditionsSet;
            NUDLvlAgroMin.Value = accUserControl.Account.Config.MinLevelAgro;
            NUDLvlAgroMax.Value = accUserControl.Account.Config.MaxLevelAgro;
            foreach(string s in accUserControl.Account.Config.AlliancesNameAgro)
            {
                LViewAgro.Items.Add(new ListViewItem(s));
            }
            sadikCheckbox2.Checked = accUserControl.Account.Config.RunConditionsSet;
            NUDLvlRunMin.Value = accUserControl.Account.Config.MinLevelRun;
            NUDLvlRunMax.Value = accUserControl.Account.Config.MaxLevelRun;
            if (accUserControl.Account.Config.DisconnectWhenRun)
                Disconnecting.Checked = accUserControl.Account.Config.DisconnectWhenRun;
            else if (accUserControl.Account.Config.UseItemWhenRun)
                UsingItem.Checked = accUserControl.Account.Config.UseItemWhenRun;
            foreach (string s in accUserControl.Account.Config.AlliancesNameRun)
            {
                LViewRun.Items.Add(new ListViewItem(s));
            }
        }
        #endregion

        #region UI Methods
        private void addAllianceAgro_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(AllianceTxtBAgro.Text)) && (LViewAgro.Items.Count < 50))
            {
                LViewAgro.Items.Add(AllianceTxtBAgro.Text);
                accUserControl.Account.Config.AlliancesNameAgro.Add(AllianceTxtBAgro.Text);
                AllianceTxtBAgro.Text = "";
            }
        }

        private void addAllianceRun_Click(object sender, EventArgs e)
        {
            if ((AllianceTxtBRun.Text.Length > 0) && (LViewRun.Items.Count < 50))
            {
                LViewRun.Items.Add(AllianceTxtBRun.Text);
                accUserControl.Account.Config.AlliancesNameRun.Add(AllianceTxtBRun.Text);
                AllianceTxtBRun.Text = "";
            }
        }

        private void sadikCheckbox1_CheckedChanged(object sender)
        {
            accUserControl.Account.Config.AgroConditionsSet = sadikCheckbox1.Checked;
        }

        private void NUDLvlAgroMin_ValueChanged(object sender, EventArgs e)
        {
            accUserControl.Account.Config.MinLevelAgro = (long)NUDLvlAgroMin.Value;
        }

        private void NUDLvlAgroMax_ValueChanged(object sender, EventArgs e)
        {
            accUserControl.Account.Config.MaxLevelAgro = (long)NUDLvlAgroMax.Value;
        }

        private void sadikCheckbox2_CheckedChanged(object sender)
        {
            accUserControl.Account.Config.RunConditionsSet = sadikCheckbox2.Checked;
        }

        private void NUDLvlRunMin_ValueChanged(object sender, EventArgs e)
        {
            accUserControl.Account.Config.MinLevelRun = (long)NUDLvlRunMin.Value;
        }

        private void NUDLvlRunMax_ValueChanged(object sender, EventArgs e)
        {
            accUserControl.Account.Config.MaxLevelRun = (long)NUDLvlRunMax.Value;
        }

        private void Disconnecting_CheckedChanged(object sender)
        {
            accUserControl.Account.Config.DisconnectWhenRun = Disconnecting.Checked;
        }

        private void UsingItem_CheckedChanged(object sender)
        {
            accUserControl.Account.Config.UseItemWhenRun = UsingItem.Checked;
        }

        private void UsedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            accUserControl.Account.Config.ItemToUseWhenRun = (PotionEnum)UsedItem.SelectedIndex;
        }

        private void LViewRun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Key.Delete)
            {
                foreach (ListViewItem lvi in LViewRun.SelectedItems)
                {
                    accUserControl.Account.Config.AlliancesNameRun.RemoveAll(s => s == lvi.SubItems[0].Text);
                    LViewRun.Items.Remove(lvi);
                }
            }
        }

        private void LViewAgro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Key.Delete)
            {
                foreach (ListViewItem lvi in LViewAgro.SelectedItems)
                {
                    accUserControl.Account.Config.AlliancesNameAgro.RemoveAll(s => s == lvi.SubItems[0].Text);
                    LViewAgro.Items.Remove(lvi);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.AllianceTxtBAgro = new System.Windows.Forms.TextBox();
            this.addAllianceAgro = new MageBot.Interface.SadikButton();
            this.sadikLabel2 = new MageBot.Interface.SadikLabel();
            this.NUDLvlAgroMin = new System.Windows.Forms.NumericUpDown();
            this.NUDLvlAgroMax = new System.Windows.Forms.NumericUpDown();
            this.sadikCheckbox1 = new MageBot.Interface.SadikCheckbox();
            this.LViewAgro = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addAllianceRun = new MageBot.Interface.SadikButton();
            this.AllianceTxtBRun = new System.Windows.Forms.TextBox();
            this.UsedItem = new MageBot.Interface.SadikCombo();
            this.LViewRun = new System.Windows.Forms.ListView();
            this.sadikLabel3 = new MageBot.Interface.SadikLabel();
            this.sadikLabel4 = new MageBot.Interface.SadikLabel();
            this.NUDLvlRunMin = new System.Windows.Forms.NumericUpDown();
            this.NUDLvlRunMax = new System.Windows.Forms.NumericUpDown();
            this.Disconnecting = new MageBot.Interface.SadikRadioButton();
            this.UsingItem = new MageBot.Interface.SadikRadioButton();
            this.sadikCheckbox2 = new MageBot.Interface.SadikCheckbox();
            this.sadikLabel1 = new MageBot.Interface.SadikLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sadikTabControl1 = new MageBot.Interface.SadikTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlAgroMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlAgroMax)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlRunMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlRunMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.sadikTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllianceTxtBAgro
            // 
            this.AllianceTxtBAgro.Location = new System.Drawing.Point(18, 68);
            this.AllianceTxtBAgro.Name = "AllianceTxtBAgro";
            this.AllianceTxtBAgro.Size = new System.Drawing.Size(286, 20);
            this.AllianceTxtBAgro.TabIndex = 30;
            // 
            // addAllianceAgro
            // 
            this.addAllianceAgro.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.addAllianceAgro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAllianceAgro.Font = new System.Drawing.Font("Verdana", 8F);
            this.addAllianceAgro.Image = null;
            this.addAllianceAgro.Location = new System.Drawing.Point(18, 94);
            this.addAllianceAgro.Name = "addAllianceAgro";
            this.addAllianceAgro.RoundedCorners = false;
            this.addAllianceAgro.Size = new System.Drawing.Size(286, 22);
            this.addAllianceAgro.TabIndex = 29;
            this.addAllianceAgro.Text = "Add alliance / guild";
            this.addAllianceAgro.Click += new System.EventHandler(this.addAllianceAgro_Click);
            // 
            // sadikLabel2
            // 
            this.sadikLabel2.AutoSize = true;
            this.sadikLabel2.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel2.Location = new System.Drawing.Point(228, 47);
            this.sadikLabel2.Name = "sadikLabel2";
            this.sadikLabel2.Size = new System.Drawing.Size(18, 13);
            this.sadikLabel2.TabIndex = 20;
            this.sadikLabel2.Text = "to";
            // 
            // NUDLvlAgroMin
            // 
            this.NUDLvlAgroMin.Location = new System.Drawing.Point(171, 45);
            this.NUDLvlAgroMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUDLvlAgroMin.Name = "NUDLvlAgroMin";
            this.NUDLvlAgroMin.Size = new System.Drawing.Size(51, 20);
            this.NUDLvlAgroMin.TabIndex = 18;
            this.NUDLvlAgroMin.ValueChanged += new System.EventHandler(this.NUDLvlAgroMin_ValueChanged);
            // 
            // NUDLvlAgroMax
            // 
            this.NUDLvlAgroMax.Location = new System.Drawing.Point(248, 45);
            this.NUDLvlAgroMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUDLvlAgroMax.Name = "NUDLvlAgroMax";
            this.NUDLvlAgroMax.Size = new System.Drawing.Size(44, 20);
            this.NUDLvlAgroMax.TabIndex = 17;
            this.NUDLvlAgroMax.ValueChanged += new System.EventHandler(this.NUDLvlAgroMax_ValueChanged);
            // 
            // sadikCheckbox1
            // 
            this.sadikCheckbox1.Checked = false;
            this.sadikCheckbox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikCheckbox1.Location = new System.Drawing.Point(18, 19);
            this.sadikCheckbox1.Name = "sadikCheckbox1";
            this.sadikCheckbox1.Size = new System.Drawing.Size(210, 20);
            this.sadikCheckbox1.TabIndex = 16;
            this.sadikCheckbox1.Text = "Activate";
            this.sadikCheckbox1.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.sadikCheckbox1_CheckedChanged);
            // 
            // LViewAgro
            // 
            this.LViewAgro.Location = new System.Drawing.Point(18, 122);
            this.LViewAgro.Name = "LViewAgro";
            this.LViewAgro.Size = new System.Drawing.Size(286, 93);
            this.LViewAgro.TabIndex = 15;
            this.LViewAgro.UseCompatibleStateImageBehavior = false;
            this.LViewAgro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LViewAgro_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addAllianceRun);
            this.groupBox3.Controls.Add(this.AllianceTxtBRun);
            this.groupBox3.Controls.Add(this.UsedItem);
            this.groupBox3.Controls.Add(this.LViewRun);
            this.groupBox3.Controls.Add(this.sadikLabel3);
            this.groupBox3.Controls.Add(this.sadikLabel4);
            this.groupBox3.Controls.Add(this.NUDLvlRunMin);
            this.groupBox3.Controls.Add(this.NUDLvlRunMax);
            this.groupBox3.Controls.Add(this.Disconnecting);
            this.groupBox3.Controls.Add(this.UsingItem);
            this.groupBox3.Controls.Add(this.sadikCheckbox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 233);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flight";
            // 
            // addAllianceRun
            // 
            this.addAllianceRun.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.addAllianceRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAllianceRun.Font = new System.Drawing.Font("Verdana", 8F);
            this.addAllianceRun.Image = null;
            this.addAllianceRun.Location = new System.Drawing.Point(215, 132);
            this.addAllianceRun.Name = "addAllianceRun";
            this.addAllianceRun.RoundedCorners = false;
            this.addAllianceRun.Size = new System.Drawing.Size(148, 26);
            this.addAllianceRun.TabIndex = 28;
            this.addAllianceRun.Text = "Add alliance / guild";
            this.addAllianceRun.Click += new System.EventHandler(this.addAllianceRun_Click);
            // 
            // AllianceTxtBRun
            // 
            this.AllianceTxtBRun.Location = new System.Drawing.Point(12, 132);
            this.AllianceTxtBRun.Name = "AllianceTxtBRun";
            this.AllianceTxtBRun.Size = new System.Drawing.Size(197, 20);
            this.AllianceTxtBRun.TabIndex = 27;
            // 
            // UsedItem
            // 
            this.UsedItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UsedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsedItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.UsedItem.FormattingEnabled = true;
            this.UsedItem.ItemHeight = 20;
            this.UsedItem.Items.AddRange(new object[] {
            "Memory potion",
            "City potion: Bonta",
            "City potion: Brakmar"});
            this.UsedItem.Location = new System.Drawing.Point(155, 94);
            this.UsedItem.Name = "UsedItem";
            this.UsedItem.Size = new System.Drawing.Size(208, 26);
            this.UsedItem.TabIndex = 26;
            this.UsedItem.SelectedIndexChanged += new System.EventHandler(this.UsedItem_SelectedIndexChanged);
            // 
            // LViewRun
            // 
            this.LViewRun.Location = new System.Drawing.Point(9, 164);
            this.LViewRun.Name = "LViewRun";
            this.LViewRun.Size = new System.Drawing.Size(359, 63);
            this.LViewRun.TabIndex = 25;
            this.LViewRun.UseCompatibleStateImageBehavior = false;
            this.LViewRun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LViewRun_KeyPress);
            // 
            // sadikLabel3
            // 
            this.sadikLabel3.AutoSize = true;
            this.sadikLabel3.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel3.Location = new System.Drawing.Point(212, 47);
            this.sadikLabel3.Name = "sadikLabel3";
            this.sadikLabel3.Size = new System.Drawing.Size(18, 13);
            this.sadikLabel3.TabIndex = 24;
            this.sadikLabel3.Text = "to";
            // 
            // sadikLabel4
            // 
            this.sadikLabel4.AutoSize = true;
            this.sadikLabel4.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel4.Location = new System.Drawing.Point(15, 47);
            this.sadikLabel4.Name = "sadikLabel4";
            this.sadikLabel4.Size = new System.Drawing.Size(132, 13);
            this.sadikLabel4.TabIndex = 23;
            this.sadikLabel4.Text = "Characters from level";
            // 
            // NUDLvlRunMin
            // 
            this.NUDLvlRunMin.Location = new System.Drawing.Point(161, 45);
            this.NUDLvlRunMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUDLvlRunMin.Name = "NUDLvlRunMin";
            this.NUDLvlRunMin.Size = new System.Drawing.Size(45, 20);
            this.NUDLvlRunMin.TabIndex = 22;
            this.NUDLvlRunMin.ValueChanged += new System.EventHandler(this.NUDLvlRunMin_ValueChanged);
            // 
            // NUDLvlRunMax
            // 
            this.NUDLvlRunMax.Location = new System.Drawing.Point(232, 45);
            this.NUDLvlRunMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUDLvlRunMax.Name = "NUDLvlRunMax";
            this.NUDLvlRunMax.Size = new System.Drawing.Size(41, 20);
            this.NUDLvlRunMax.TabIndex = 21;
            this.NUDLvlRunMax.ValueChanged += new System.EventHandler(this.NUDLvlRunMax_ValueChanged);
            // 
            // Disconnecting
            // 
            this.Disconnecting.Checked = true;
            this.Disconnecting.Font = new System.Drawing.Font("Verdana", 8F);
            this.Disconnecting.Location = new System.Drawing.Point(9, 74);
            this.Disconnecting.Name = "Disconnecting";
            this.Disconnecting.Size = new System.Drawing.Size(140, 20);
            this.Disconnecting.TabIndex = 2;
            this.Disconnecting.Text = "Disconnect";
            this.Disconnecting.CheckedChanged += new MageBot.Interface.SadikRadioButton.CheckedChangedEventHandler(this.Disconnecting_CheckedChanged);
            // 
            // UsingItem
            // 
            this.UsingItem.Checked = false;
            this.UsingItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.UsingItem.Location = new System.Drawing.Point(9, 100);
            this.UsingItem.Name = "UsingItem";
            this.UsingItem.Size = new System.Drawing.Size(140, 20);
            this.UsingItem.TabIndex = 1;
            this.UsingItem.Text = "Take a potion";
            this.UsingItem.CheckedChanged += new MageBot.Interface.SadikRadioButton.CheckedChangedEventHandler(this.UsingItem_CheckedChanged);
            // 
            // sadikCheckbox2
            // 
            this.sadikCheckbox2.Checked = false;
            this.sadikCheckbox2.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikCheckbox2.Location = new System.Drawing.Point(18, 19);
            this.sadikCheckbox2.Name = "sadikCheckbox2";
            this.sadikCheckbox2.Size = new System.Drawing.Size(140, 20);
            this.sadikCheckbox2.TabIndex = 0;
            this.sadikCheckbox2.Text = "Activate";
            this.sadikCheckbox2.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.sadikCheckbox2_CheckedChanged);
            // 
            // sadikLabel1
            // 
            this.sadikLabel1.AutoSize = true;
            this.sadikLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel1.Location = new System.Drawing.Point(15, 47);
            this.sadikLabel1.Name = "sadikLabel1";
            this.sadikLabel1.Size = new System.Drawing.Size(132, 13);
            this.sadikLabel1.TabIndex = 19;
            this.sadikLabel1.Text = "Characters from level";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AllianceTxtBAgro);
            this.groupBox2.Controls.Add(this.addAllianceAgro);
            this.groupBox2.Controls.Add(this.sadikLabel2);
            this.groupBox2.Controls.Add(this.sadikLabel1);
            this.groupBox2.Controls.Add(this.NUDLvlAgroMin);
            this.groupBox2.Controls.Add(this.NUDLvlAgroMax);
            this.groupBox2.Controls.Add(this.sadikCheckbox1);
            this.groupBox2.Controls.Add(this.LViewAgro);
            this.groupBox2.Location = new System.Drawing.Point(29, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 221);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agress";
            // 
            // sadikTabControl1
            // 
            this.sadikTabControl1.Controls.Add(this.tabPage1);
            this.sadikTabControl1.Controls.Add(this.tabPage2);
            this.sadikTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sadikTabControl1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikTabControl1.ItemSize = new System.Drawing.Size(0, 30);
            this.sadikTabControl1.Location = new System.Drawing.Point(0, 0);
            this.sadikTabControl1.Name = "sadikTabControl1";
            this.sadikTabControl1.SelectedIndex = 0;
            this.sadikTabControl1.Size = new System.Drawing.Size(410, 283);
            this.sadikTabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aggression";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fuite";
            // 
            // HeroicUC
            // 
            this.Controls.Add(this.sadikTabControl1);
            this.Name = "HeroicUC";
            this.Size = new System.Drawing.Size(410, 283);
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlAgroMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlAgroMax)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlRunMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLvlRunMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sadikTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

