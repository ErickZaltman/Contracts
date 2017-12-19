namespace Contract.Forms
{
    partial class CustomMessageBox
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
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbNoSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // sbSave
            // 
            this.sbSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.sbSave.Location = new System.Drawing.Point(12, 60);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(105, 23);
            this.sbSave.TabIndex = 0;
            this.sbSave.Text = "Сохранить";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // sbNoSave
            // 
            this.sbNoSave.DialogResult = System.Windows.Forms.DialogResult.No;
            this.sbNoSave.Location = new System.Drawing.Point(123, 60);
            this.sbNoSave.Name = "sbNoSave";
            this.sbNoSave.Size = new System.Drawing.Size(105, 23);
            this.sbNoSave.TabIndex = 1;
            this.sbNoSave.Text = "Не сохранять";
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(234, 60);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(105, 23);
            this.sbCancel.TabIndex = 2;
            this.sbCancel.Text = "Отмена";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Сохранить изменения?";
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 95);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sbCancel);
            this.Controls.Add(this.sbNoSave);
            this.Controls.Add(this.sbSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomMessageBox_FormClosing);
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.SimpleButton sbNoSave;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}