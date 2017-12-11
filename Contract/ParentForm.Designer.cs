﻿namespace Contract
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbrnContracts = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSingingDocs = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSupAgreements = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnAnexes = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDisAgreements = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bbtnContractors = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDepartments = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnActivityKind = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.bbtnNewContract = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRemoveContract = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgCats = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpContractWork = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.FloatPageDragMode = DevExpress.XtraTabbedMdi.FloatPageDragMode.Preview;
            this.xtraTabbedMdiManager1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.Windows;
            this.xtraTabbedMdiManager1.SelectedPageChanged += new System.EventHandler(this.xtraTabbedMdiManager1_SelectedPageChanged);
            this.xtraTabbedMdiManager1.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageRemoved);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 543);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1322, 27);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.AllowDrawArrow = false;
            this.ribbonControl1.ExpandCollapseItem.AllowDrawArrowInMenu = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbrnContracts,
            this.bbtnSingingDocs,
            this.bbtnSupAgreements,
            this.bbtnAnexes,
            this.bbtnDisAgreements,
            this.barStaticItem1,
            this.bbtnContractors,
            this.bbtnDepartments,
            this.bbtnActivityKind,
            this.barStaticItem2,
            this.bbtnNewContract,
            this.bbtnSave,
            this.barButtonItem3,
            this.bbtnRemoveContract,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 44;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMain,
            this.rpContractWork});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1322, 116);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbrnContracts
            // 
            this.bbrnContracts.Caption = "Договора";
            this.bbrnContracts.Glyph = ((System.Drawing.Image)(resources.GetObject("bbrnContracts.Glyph")));
            this.bbrnContracts.Id = 16;
            this.bbrnContracts.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbrnContracts.LargeGlyph")));
            this.bbrnContracts.Name = "bbrnContracts";
            this.bbrnContracts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbrnContracts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbrnContracts_ItemClick);
            // 
            // bbtnSingingDocs
            // 
            this.bbtnSingingDocs.Caption = "Договора на согласовании";
            this.bbtnSingingDocs.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSingingDocs.Glyph")));
            this.bbtnSingingDocs.Id = 17;
            this.bbtnSingingDocs.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnSingingDocs.LargeGlyph")));
            this.bbtnSingingDocs.Name = "bbtnSingingDocs";
            this.bbtnSingingDocs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbtnSingingDocs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSingingDocs_ItemClick);
            // 
            // bbtnSupAgreements
            // 
            this.bbtnSupAgreements.Caption = "Доп. соглашения";
            this.bbtnSupAgreements.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSupAgreements.Glyph")));
            this.bbtnSupAgreements.Id = 18;
            this.bbtnSupAgreements.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnSupAgreements.LargeGlyph")));
            this.bbtnSupAgreements.Name = "bbtnSupAgreements";
            this.bbtnSupAgreements.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbtnSupAgreements.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bbtnAnexes
            // 
            this.bbtnAnexes.Caption = "Приложения";
            this.bbtnAnexes.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnAnexes.Glyph")));
            this.bbtnAnexes.Id = 19;
            this.bbtnAnexes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnAnexes.LargeGlyph")));
            this.bbtnAnexes.Name = "bbtnAnexes";
            this.bbtnAnexes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbtnAnexes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnAnexes_ItemClick);
            // 
            // bbtnDisAgreements
            // 
            this.bbtnDisAgreements.Caption = "Протокол разногласий";
            this.bbtnDisAgreements.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnDisAgreements.Glyph")));
            this.bbtnDisAgreements.Id = 23;
            this.bbtnDisAgreements.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnDisAgreements.LargeGlyph")));
            this.bbtnDisAgreements.Name = "bbtnDisAgreements";
            this.bbtnDisAgreements.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbtnDisAgreements.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDisAgreements_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 26;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbtnContractors
            // 
            this.bbtnContractors.Caption = "Контрагенты";
            this.bbtnContractors.Id = 32;
            this.bbtnContractors.Name = "bbtnContractors";
            this.bbtnContractors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // bbtnDepartments
            // 
            this.bbtnDepartments.Caption = "Департаменты";
            this.bbtnDepartments.Id = 33;
            this.bbtnDepartments.Name = "bbtnDepartments";
            this.bbtnDepartments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDepartments_ItemClick);
            // 
            // bbtnActivityKind
            // 
            this.bbtnActivityKind.Caption = "Виды деятельности";
            this.bbtnActivityKind.Id = 34;
            this.bbtnActivityKind.Name = "bbtnActivityKind";
            this.bbtnActivityKind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnActivityKind_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Id = 35;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbtnNewContract
            // 
            this.bbtnNewContract.Caption = "Новый договор";
            this.bbtnNewContract.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnNewContract.Glyph")));
            this.bbtnNewContract.Id = 37;
            this.bbtnNewContract.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnNewContract.LargeGlyph")));
            this.bbtnNewContract.Name = "bbtnNewContract";
            // 
            // bbtnSave
            // 
            this.bbtnSave.Caption = "Сохранить договор";
            this.bbtnSave.Enabled = false;
            this.bbtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSave.Glyph")));
            this.bbtnSave.Id = 38;
            this.bbtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnSave.LargeGlyph")));
            this.bbtnSave.Name = "bbtnSave";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Отправить на согласование";
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 39;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // bbtnRemoveContract
            // 
            this.bbtnRemoveContract.Caption = "Пометить на удаление";
            this.bbtnRemoveContract.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnRemoveContract.Glyph")));
            this.bbtnRemoveContract.Id = 40;
            this.bbtnRemoveContract.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnRemoveContract.LargeGlyph")));
            this.bbtnRemoveContract.Name = "bbtnRemoveContract";
            this.bbtnRemoveContract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRemoveContract_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Вложения";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 42;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Связанные документы";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 43;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // rpMain
            // 
            this.rpMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rbgCats});
            this.rpMain.Name = "rpMain";
            this.rpMain.Text = "Главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbrnContracts);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnSingingDocs);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnSupAgreements);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnAnexes);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnDisAgreements);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Документы";
            // 
            // rbgCats
            // 
            this.rbgCats.ItemLinks.Add(this.bbtnContractors);
            this.rbgCats.ItemLinks.Add(this.bbtnDepartments);
            this.rbgCats.ItemLinks.Add(this.bbtnActivityKind);
            this.rbgCats.Name = "rbgCats";
            this.rbgCats.Text = "Справочники";
            // 
            // rpContractWork
            // 
            this.rpContractWork.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.rpContractWork.Name = "rpContractWork";
            this.rpContractWork.Text = "Договорная работа";
            this.rpContractWork.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnNewContract);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnRemoveContract);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Договора";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnSave);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Спецификации";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 22;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 570);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.IsMdiContainer = true;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParentForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.BarButtonItem bbrnContracts;
        private DevExpress.XtraBars.BarButtonItem bbtnSingingDocs;
        private DevExpress.XtraBars.BarButtonItem bbtnSupAgreements;
        private DevExpress.XtraBars.BarButtonItem bbtnAnexes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbtnDisAgreements;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpContractWork;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbtnContractors;
        private DevExpress.XtraBars.BarButtonItem bbtnDepartments;
        private DevExpress.XtraBars.BarButtonItem bbtnActivityKind;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgCats;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        public DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem bbtnNewContract;
        private DevExpress.XtraBars.BarButtonItem bbtnSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem bbtnRemoveContract;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}