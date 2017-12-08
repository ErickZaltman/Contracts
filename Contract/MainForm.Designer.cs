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
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.gvAnnexes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvSupAgreements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvContracts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvSignings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvAttachments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvDisagreements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnnexes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupAgreements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSignings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisagreements)).BeginInit();
            this.SuspendLayout();
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
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContracts;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSignings;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupAgreements;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnnexes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAttachments;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDisagreements;
    }
    //tteststskjagdsf
}

