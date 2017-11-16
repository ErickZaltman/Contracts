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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiContracts,
            this.nbiSupAgreements,
            this.nbiAdditions,
            this.nbiAttachments});
            this.navBarControl1.Location = new System.Drawing.Point(13, 13);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 300);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiContracts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiSupAgreements),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAdditions),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAttachments)});
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
            // 
            // nbiAdditions
            // 
            this.nbiAdditions.Caption = "Приложения";
            this.nbiAdditions.Name = "nbiAdditions";
            // 
            // nbiAttachments
            // 
            this.nbiAttachments.Caption = "Вложения";
            this.nbiAttachments.Name = "nbiAttachments";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(177, 13);
            this.gridControl1.MainView = this.gvMain;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(493, 300);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // gvMain
            // 
            this.gvMain.GridControl = this.gridControl1;
            this.gvMain.Name = "gvMain";
            this.gvMain.OptionsBehavior.Editable = false;
            this.gvMain.OptionsView.ShowGroupPanel = false;
            this.gvMain.OptionsView.ShowIndicator = false;
            this.gvMain.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 440);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiContracts;
        private DevExpress.XtraNavBar.NavBarItem nbiSupAgreements;
        private DevExpress.XtraNavBar.NavBarItem nbiAdditions;
        private DevExpress.XtraNavBar.NavBarItem nbiAttachments;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
    }
}

