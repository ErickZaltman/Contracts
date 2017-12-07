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
        //reba

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
            this.nbiAnnexes = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiAttachments = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiSigningDocs = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDisagreements = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiActivityKinds = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDepartments = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiContractors = new DevExpress.XtraNavBar.NavBarItem();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.gvAnnexes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvSupAgreements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvContracts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvSignings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvAttachments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvDisagreements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnnexes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupAgreements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSignings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisagreements)).BeginInit();
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
            this.nbiAnnexes,
            this.nbiAttachments,
            this.nbiSigningDocs,
            this.nbiDisagreements,
            this.nbiActivityKinds,
            this.nbiDepartments,
            this.nbiContractors});
            this.navBarControl1.Location = new System.Drawing.Point(2, -1);
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAnnexes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAttachments),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiSigningDocs),
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
            this.nbiSupAgreements.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiSupAgreements_LinkPressed);
            // 
            // nbiAnnexes
            // 
            this.nbiAnnexes.Caption = "Приложения";
            this.nbiAnnexes.Name = "nbiAnnexes";
            this.nbiAnnexes.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiAnnexes_LinkPressed);
            // 
            // nbiAttachments
            // 
            this.nbiAttachments.Caption = "Прикрепленные документы";
            this.nbiAttachments.Name = "nbiAttachments";
            this.nbiAttachments.Visible = false;
            // 
            // nbiSigningDocs
            // 
            this.nbiSigningDocs.Caption = "Договора на согласовании";
            this.nbiSigningDocs.Name = "nbiSigningDocs";
            this.nbiSigningDocs.Visible = false;
            this.nbiSigningDocs.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiSigningDocs_LinkPressed);
            // 
            // nbiDisagreements
            // 
            this.nbiDisagreements.Caption = "Протоколы разногласий";
            this.nbiDisagreements.Name = "nbiDisagreements";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Справочники";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiActivityKinds),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDepartments),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiContractors)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbiActivityKinds
            // 
            this.nbiActivityKinds.Caption = "Виды деятельности";
            this.nbiActivityKinds.Name = "nbiActivityKinds";
            this.nbiActivityKinds.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiActivityKinds_LinkPressed);
            // 
            // nbiDepartments
            // 
            this.nbiDepartments.Caption = "Департаменты";
            this.nbiDepartments.Name = "nbiDepartments";
            this.nbiDepartments.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDepartments_LinkPressed);
            // 
            // nbiContractors
            // 
            this.nbiContractors.Caption = "Контрагенты";
            this.nbiContractors.Name = "nbiContractors";
            this.nbiContractors.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiContractors_LinkPressed);
            // 
            // gcMain
            // 
            this.gcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMain.Location = new System.Drawing.Point(193, -1);
            this.gcMain.MainView = this.gvAnnexes;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(584, 507);
            this.gcMain.TabIndex = 1;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnnexes,
            this.gvSupAgreements,
            this.gvContracts,
            this.gvSignings,
            this.gvAttachments,
            this.gvDisagreements});
            // 
            // gvAnnexes
            // 
            this.gvAnnexes.GridControl = this.gcMain;
            this.gvAnnexes.Name = "gvAnnexes";
            this.gvAnnexes.OptionsBehavior.Editable = false;
            this.gvAnnexes.OptionsView.ShowGroupPanel = false;
            this.gvAnnexes.OptionsView.ShowIndicator = false;
            this.gvAnnexes.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvAnnexes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAnnexes_RowClick);
            // 
            // gvSupAgreements
            // 
            this.gvSupAgreements.GridControl = this.gcMain;
            this.gvSupAgreements.Name = "gvSupAgreements";
            this.gvSupAgreements.OptionsBehavior.Editable = false;
            this.gvSupAgreements.OptionsView.ShowGroupPanel = false;
            this.gvSupAgreements.OptionsView.ShowIndicator = false;
            this.gvSupAgreements.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSupAgreements.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvSupAgreements_RowClick);
            // 
            // gvContracts
            // 
            this.gvContracts.GridControl = this.gcMain;
            this.gvContracts.Name = "gvContracts";
            this.gvContracts.OptionsBehavior.Editable = false;
            this.gvContracts.OptionsView.ShowGroupPanel = false;
            this.gvContracts.OptionsView.ShowIndicator = false;
            this.gvContracts.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvContracts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvContracts_RowClick);
            // 
            // gvSignings
            // 
            this.gvSignings.GridControl = this.gcMain;
            this.gvSignings.Name = "gvSignings";
            this.gvSignings.OptionsBehavior.Editable = false;
            this.gvSignings.OptionsView.ShowGroupPanel = false;
            this.gvSignings.OptionsView.ShowIndicator = false;
            this.gvSignings.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAgreements_RowClick);
            // 
            // gvAttachments
            // 
            this.gvAttachments.GridControl = this.gcMain;
            this.gvAttachments.Name = "gvAttachments";
            this.gvAttachments.OptionsBehavior.Editable = false;
            this.gvAttachments.OptionsView.ShowGroupPanel = false;
            this.gvAttachments.OptionsView.ShowIndicator = false;
            this.gvAttachments.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gvDisagreements
            // 
            this.gvDisagreements.GridControl = this.gcMain;
            this.gvDisagreements.Name = "gvDisagreements";
            this.gvDisagreements.OptionsBehavior.Editable = false;
            this.gvDisagreements.OptionsView.ShowGroupPanel = false;
            this.gvDisagreements.OptionsView.ShowIndicator = false;
            this.gvDisagreements.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(783, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Новый Договор";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Name = "navBarItem1";
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
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gcMain);
            this.Controls.Add(this.navBarControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnnexes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupAgreements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSignings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisagreements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiContracts;
        private DevExpress.XtraNavBar.NavBarItem nbiSupAgreements;
        private DevExpress.XtraNavBar.NavBarItem nbiAnnexes;
        private DevExpress.XtraNavBar.NavBarItem nbiAttachments;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContracts;
        private DevExpress.XtraNavBar.NavBarItem nbiSigningDocs;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSignings;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem nbiDisagreements;
        private DevExpress.XtraNavBar.NavBarItem nbiActivityKinds;
        private DevExpress.XtraNavBar.NavBarItem nbiDepartments;
        private DevExpress.XtraNavBar.NavBarItem nbiContractors;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupAgreements;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnnexes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAttachments;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDisagreements;
    }
    //tteststskjagdsf
}

