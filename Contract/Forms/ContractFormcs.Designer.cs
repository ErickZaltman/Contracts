namespace Contract.Forms
{
    partial class ContractForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbContractNumber = new System.Windows.Forms.TextBox();
            this.tbContractTheme = new System.Windows.Forms.TextBox();
            this.tbContractNote = new System.Windows.Forms.TextBox();
            this.tbSumm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.beDepartment = new DevExpress.XtraEditors.ButtonEdit();
            this.beContractCategory = new DevExpress.XtraEditors.ButtonEdit();
            this.deContractDateStart = new DevExpress.XtraEditors.DateEdit();
            this.deContractDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.beContractual = new DevExpress.XtraEditors.ButtonEdit();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpMainInfo = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tnpSigning = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tnpAttachments = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.hzhz = new System.Windows.Forms.ComboBox();
            this.lueExtensions = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.beDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beContractCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beContractual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tnpMainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueExtensions.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер договора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Предмет договора:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Период с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "по:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Продление:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Договорник:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Комментарий:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Сумма:";
            // 
            // tbContractNumber
            // 
            this.tbContractNumber.Location = new System.Drawing.Point(126, 12);
            this.tbContractNumber.Name = "tbContractNumber";
            this.tbContractNumber.ReadOnly = true;
            this.tbContractNumber.Size = new System.Drawing.Size(100, 21);
            this.tbContractNumber.TabIndex = 10;
            // 
            // tbContractTheme
            // 
            this.tbContractTheme.Location = new System.Drawing.Point(129, 13);
            this.tbContractTheme.Multiline = true;
            this.tbContractTheme.Name = "tbContractTheme";
            this.tbContractTheme.Size = new System.Drawing.Size(305, 93);
            this.tbContractTheme.TabIndex = 11;
            // 
            // tbContractNote
            // 
            this.tbContractNote.Location = new System.Drawing.Point(564, 98);
            this.tbContractNote.Name = "tbContractNote";
            this.tbContractNote.Size = new System.Drawing.Size(100, 21);
            this.tbContractNote.TabIndex = 16;
            // 
            // tbSumm
            // 
            this.tbSumm.Location = new System.Drawing.Point(564, 71);
            this.tbSumm.Name = "tbSumm";
            this.tbSumm.Size = new System.Drawing.Size(100, 21);
            this.tbSumm.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Категория:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Подразделение:";
            // 
            // beDepartment
            // 
            this.beDepartment.Location = new System.Drawing.Point(126, 66);
            this.beDepartment.Name = "beDepartment";
            this.beDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beDepartment.Size = new System.Drawing.Size(255, 20);
            this.beDepartment.TabIndex = 25;
            this.beDepartment.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDepartment_ButtonClick);
            // 
            // beContractCategory
            // 
            this.beContractCategory.Location = new System.Drawing.Point(126, 40);
            this.beContractCategory.Name = "beContractCategory";
            this.beContractCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beContractCategory.Size = new System.Drawing.Size(255, 20);
            this.beContractCategory.TabIndex = 26;
            this.beContractCategory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beContractCategory_ButtonClick);
            // 
            // deContractDateStart
            // 
            this.deContractDateStart.EditValue = null;
            this.deContractDateStart.Location = new System.Drawing.Point(564, 13);
            this.deContractDateStart.Name = "deContractDateStart";
            this.deContractDateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deContractDateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deContractDateStart.Size = new System.Drawing.Size(100, 20);
            this.deContractDateStart.TabIndex = 27;
            // 
            // deContractDateEnd
            // 
            this.deContractDateEnd.EditValue = null;
            this.deContractDateEnd.Location = new System.Drawing.Point(699, 13);
            this.deContractDateEnd.Name = "deContractDateEnd";
            this.deContractDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deContractDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deContractDateEnd.Size = new System.Drawing.Size(100, 20);
            this.deContractDateEnd.TabIndex = 28;
            // 
            // beContractual
            // 
            this.beContractual.Location = new System.Drawing.Point(129, 117);
            this.beContractual.Name = "beContractual";
            this.beContractual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beContractual.Size = new System.Drawing.Size(305, 20);
            this.beContractual.TabIndex = 29;
            this.beContractual.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beContractual_ButtonClick);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(57, 0);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(75, 23);
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tnpMainInfo);
            this.tabPane1.Controls.Add(this.tnpSigning);
            this.tabPane1.Controls.Add(this.tnpAttachments);
            this.tabPane1.Location = new System.Drawing.Point(12, 106);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpMainInfo,
            this.tnpSigning,
            this.tnpAttachments});
            this.tabPane1.RegularSize = new System.Drawing.Size(1244, 519);
            this.tabPane1.SelectedPage = this.tnpMainInfo;
            this.tabPane1.Size = new System.Drawing.Size(1244, 519);
            this.tabPane1.TabIndex = 31;
            this.tabPane1.Text = "tabPane1";
            // 
            // tnpMainInfo
            // 
            this.tnpMainInfo.Caption = "Основная информация";
            this.tnpMainInfo.Controls.Add(this.hzhz);
            this.tnpMainInfo.Controls.Add(this.label12);
            this.tnpMainInfo.Controls.Add(this.tbAuthor);
            this.tnpMainInfo.Controls.Add(this.tbContractTheme);
            this.tnpMainInfo.Controls.Add(this.label3);
            this.tnpMainInfo.Controls.Add(this.deContractDateEnd);
            this.tnpMainInfo.Controls.Add(this.deContractDateStart);
            this.tnpMainInfo.Controls.Add(this.beContractual);
            this.tnpMainInfo.Controls.Add(this.tbSumm);
            this.tnpMainInfo.Controls.Add(this.label7);
            this.tnpMainInfo.Controls.Add(this.tbContractNote);
            this.tnpMainInfo.Controls.Add(this.label4);
            this.tnpMainInfo.Controls.Add(this.label6);
            this.tnpMainInfo.Controls.Add(this.label9);
            this.tnpMainInfo.Controls.Add(this.label8);
            this.tnpMainInfo.Controls.Add(this.label5);
            this.tnpMainInfo.Controls.Add(this.lueExtensions);
            this.tnpMainInfo.Name = "tnpMainInfo";
            this.tnpMainInfo.Size = new System.Drawing.Size(1226, 474);
            // 
            // tnpSigning
            // 
            this.tnpSigning.Caption = "Согласования";
            this.tnpSigning.Name = "tnpSigning";
            this.tnpSigning.Size = new System.Drawing.Size(1226, 474);
            // 
            // tnpAttachments
            // 
            this.tnpAttachments.Caption = "Вложения";
            this.tnpAttachments.Name = "tnpAttachments";
            this.tnpAttachments.Size = new System.Drawing.Size(1226, 474);
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(281, 13);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Size = new System.Drawing.Size(100, 20);
            this.deDate.TabIndex = 32;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(564, 126);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(100, 21);
            this.tbAuthor.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Автор:";
            // 
            // hzhz
            // 
            this.hzhz.FormattingEnabled = true;
            this.hzhz.Location = new System.Drawing.Point(821, 45);
            this.hzhz.Name = "hzhz";
            this.hzhz.Size = new System.Drawing.Size(301, 21);
            this.hzhz.TabIndex = 33;
            // 
            // lueExtensions
            // 
            this.lueExtensions.Location = new System.Drawing.Point(564, 45);
            this.lueExtensions.Name = "lueExtensions";
            this.lueExtensions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueExtensions.Properties.PopupSizeable = false;
            this.lueExtensions.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueExtensions.Size = new System.Drawing.Size(235, 20);
            this.lueExtensions.TabIndex = 34;
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 622);
            this.Controls.Add(this.deDate);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.beContractCategory);
            this.Controls.Add(this.beDepartment);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbContractNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Договор №";
            this.Load += new System.EventHandler(this.tbContractDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beContractCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deContractDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beContractual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tnpMainInfo.ResumeLayout(false);
            this.tnpMainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueExtensions.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbContractNumber;
        private System.Windows.Forms.TextBox tbContractTheme;
        private System.Windows.Forms.TextBox tbContractNote;
        private System.Windows.Forms.TextBox tbSumm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.ButtonEdit beDepartment;
        private DevExpress.XtraEditors.ButtonEdit beContractCategory;
        private DevExpress.XtraEditors.DateEdit deContractDateStart;
        private DevExpress.XtraEditors.DateEdit deContractDateEnd;
        private DevExpress.XtraEditors.ButtonEdit beContractual;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpMainInfo;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpSigning;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpAttachments;
        private DevExpress.XtraEditors.DateEdit deDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.ComboBox hzhz;
        private DevExpress.XtraEditors.LookUpEdit lueExtensions;
    }
}