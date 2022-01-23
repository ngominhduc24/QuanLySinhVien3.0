namespace Winform_QuanLySinhVien3._0
{
    partial class fStudent_Mark
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_FindClass = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ReportMark = new System.Windows.Forms.Button();
            this.datagrid_Mark = new System.Windows.Forms.DataGridView();
            this.textID = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Mark)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã sinh viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Họ và tên :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbb_FindClass);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_ReportMark);
            this.panel1.Controls.Add(this.datagrid_Mark);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 479);
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tìm kiếm theo lớp :";
            // 
            // cbb_FindClass
            // 
            this.cbb_FindClass.FormattingEnabled = true;
            this.cbb_FindClass.Location = new System.Drawing.Point(291, 16);
            this.cbb_FindClass.Name = "cbb_FindClass";
            this.cbb_FindClass.Size = new System.Drawing.Size(177, 24);
            this.cbb_FindClass.TabIndex = 41;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(772, 401);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(131, 64);
            this.btn_Exit.TabIndex = 40;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ReportMark
            // 
            this.btn_ReportMark.Location = new System.Drawing.Point(610, 401);
            this.btn_ReportMark.Name = "btn_ReportMark";
            this.btn_ReportMark.Size = new System.Drawing.Size(131, 64);
            this.btn_ReportMark.TabIndex = 39;
            this.btn_ReportMark.Text = "Báo cáo điểm";
            this.btn_ReportMark.UseVisualStyleBackColor = true;
            // 
            // datagrid_Mark
            // 
            this.datagrid_Mark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Mark.Location = new System.Drawing.Point(58, 59);
            this.datagrid_Mark.Name = "datagrid_Mark";
            this.datagrid_Mark.RowHeadersWidth = 51;
            this.datagrid_Mark.RowTemplate.Height = 24;
            this.datagrid_Mark.Size = new System.Drawing.Size(872, 326);
            this.datagrid_Mark.TabIndex = 38;
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(616, 21);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(30, 22);
            this.textID.TabIndex = 37;
            this.textID.Text = "ID";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(178, 21);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(56, 22);
            this.textName.TabIndex = 38;
            this.textName.Text = "Name";
            // 
            // fStudent_Mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 569);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fStudent_Mark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm";
            this.Load += new System.EventHandler(this.fStudent_Mark_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_FindClass;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ReportMark;
        private System.Windows.Forms.DataGridView datagrid_Mark;
        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.Label textName;
    }
}