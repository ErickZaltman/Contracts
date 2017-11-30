namespace Contract
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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiContracts = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiSupAgreements = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiAdditions = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiAttachments = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiAgreementsDocs = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiContractors = new DevExpress.XtraNavBar.NavBarItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvContracts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvAgreements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiContractors = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDisagreements = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiActivityKinds = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDepartments = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgreements)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiContracts,
            this.nbiSupAgreements,
            this.nbiAdditions,
            this.nbiAttachments,
            this.nbiAgreementsDocs,
            this.nbiContractors,
            this.nbiDisagreements,
            this.nbiActivityKinds,
            this.nbiDepartments});
            this.navBarControl1.Location = new System.Drawing.Point(2, 33);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 185;
            this.navBarControl1.Size = new System.Drawing.Size(185, 300);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Договорная работа";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiContracts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiSupAgreements),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAdditions),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAttachments),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAgreementsDocs),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDisagreements)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiContracts
            // 
            this.nbiContracts.Caption = "Договора";
            this.nbiContracts.Name = "nbiContracts";
            this.nbiContracts.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiContracts_LinkPressed);
            // 
            // nbiSupAgreements
            // 
            this.nbiSupAgreements.Caption = "Доп. соглашения";
            this.nbiSupAgreements.Name = "nbiSupAgreements";
            this.nbiSupAgreements.Visible = false;
            // 
            // nbiAdditions
            // 
            this.nbiAdditions.Caption = "Приложения";
            this.nbiAdditions.Name = "nbiAdditions";
            this.nbiAdditions.Visible = false;
            // 
            // nbiAttachments
            // 
            this.nbiAttachments.Caption = "Вложения";
            this.nbiAttachments.Name = "nbiAttachments";
            this.nbiAttachments.Visible = false;
            // 
            // nbiAgreementsDocs
            // 
            this.nbiAgreementsDocs.Caption = "Договора на согласовании";
            this.nbiAgreementsDocs.Name = "nbiAgreementsDocs";
            this.nbiAgreementsDocs.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiAgreementsDocs_LinkPressed);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Справочники";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiContractors)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbiContractors
            // 
            this.nbiContractors.Caption = "Контрагенты";
            this.nbiContractors.Name = "nbiContractors";
            this.nbiContractors.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiContractors_LinkClicked);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(193, 33);
            this.gridControl1.MainView = this.gvContracts;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(543, 450);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContracts,
            this.gvAgreements});
            // 
            // gvContracts
            // 
            this.gvContracts.GridControl = this.gridControl1;
            this.gvContracts.Name = "gvContracts";
            this.gvContracts.OptionsBehavior.Editable = false;
            this.gvContracts.OptionsView.ShowGroupPanel = false;
            this.gvContracts.OptionsView.ShowIndicator = false;
            this.gvContracts.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvContracts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvContracts_RowClick);
            // 
            // gvAgreements
            // 
            this.gvAgreements.GridControl = this.gridControl1;
            this.gvAgreements.Name = "gvAgreements";
            this.gvAgreements.OptionsBehavior.Editable = false;
            this.gvAgreements.OptionsView.ShowGroupPanel = false;
            this.gvAgreements.OptionsView.ShowIndicator = false;
            this.gvAgreements.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAgreements_RowClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(764, 33);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Новый Договор";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUserName
            // 
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(0, 17);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Справочники";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiContractors),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiActivityKinds),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDepartments)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbiContractors
            // 
            this.nbiContractors.Caption = "Контрагенты";
            this.nbiContractors.Name = "nbiContractors";
            this.nbiContractors.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiContractors_LinkPressed);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Name = "navBarItem1";
            // 
            // nbiDisagreements
            // 
            this.nbiDisagreements.Caption = "Протоколы разногласий";
            this.nbiDisagreements.Name = "nbiDisagreements";
            // 
            // nbiActivityKinds
            // 
            this.nbiActivityKinds.Caption = "Виды деятельности";
            this.nbiActivityKinds.Name = "nbiActivityKinds";
            // 
            // nbiDepartments
            // 
            this.nbiDepartments.Caption = "Департаменты";
            this.nbiDepartments.Name = "nbiDepartments";
            // 
            // MainForm
            // 
            this.AllowMdiBar = true;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 509);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgreements)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiContracts;
        private DevExpress.XtraNavBar.NavBarItem nbiSupAgreements;
        private DevExpress.XtraNavBar.NavBarItem nbiAdditions;
        private DevExpress.XtraNavBar.NavBarItem nbiAttachments;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContracts;
        private DevExpress.XtraNavBar.NavBarItem nbiAgreementsDocs;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAgreements;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbiContractors;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem nbiDisagreements;
        private DevExpress.XtraNavBar.NavBarItem nbiActivityKinds;
        private DevExpress.XtraNavBar.NavBarItem nbiDepartments;
    }
}

