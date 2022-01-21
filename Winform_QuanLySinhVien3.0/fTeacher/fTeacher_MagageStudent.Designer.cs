namespace Winform_QuanLySinhVien3._0
{
    partial class fTeacher_MagageStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_FindName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_FindClass = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ReplaceInfo = new System.Windows.Forms.Button();
            this.datagrid_Mark = new System.Windows.Forms.DataGridView();
            this.txt_FindID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Mark)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_FindID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_FindName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbb_FindClass);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ReplaceInfo);
            this.panel1.Controls.Add(this.datagrid_Mark);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 539);
            this.panel1.TabIndex = 43;
            // 
            // txt_FindName
            // 
            this.txt_FindName.Location = new System.Drawing.Point(712, 17);
            this.txt_FindName.Name = "txt_FindName";
            this.txt_FindName.Size = new System.Drawing.Size(177, 22);
            this.txt_FindName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tìm kiếm theo tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tìm kiếm theo lớp :";
            // 
            // cbb_FindClass
            // 
            this.cbb_FindClass.FormattingEnabled = true;
            this.cbb_FindClass.Location = new System.Drawing.Point(475, 74);
            this.cbb_FindClass.Name = "cbb_FindClass";
            this.cbb_FindClass.Size = new System.Drawing.Size(101, 24);
            this.cbb_FindClass.TabIndex = 41;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(771, 456);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(131, 64);
            this.btn_Exit.TabIndex = 40;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ReplaceInfo
            // 
            this.btn_ReplaceInfo.Location = new System.Drawing.Point(609, 456);
            this.btn_ReplaceInfo.Name = "btn_ReplaceInfo";
            this.btn_ReplaceInfo.Size = new System.Drawing.Size(131, 64);
            this.btn_ReplaceInfo.TabIndex = 39;
            this.btn_ReplaceInfo.Text = "Lưu thông tin";
            this.btn_ReplaceInfo.UseVisualStyleBackColor = true;
            // 
            // datagrid_Mark
            // 
            this.datagrid_Mark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Mark.Location = new System.Drawing.Point(57, 114);
            this.datagrid_Mark.Name = "datagrid_Mark";
            this.datagrid_Mark.RowHeadersWidth = 51;
            this.datagrid_Mark.RowTemplate.Height = 24;
            this.datagrid_Mark.Size = new System.Drawing.Size(872, 326);
            this.datagrid_Mark.TabIndex = 38;
            // 
            // txt_FindID
            // 
            this.txt_FindID.Location = new System.Drawing.Point(276, 18);
            this.txt_FindID.Name = "txt_FindID";
            this.txt_FindID.Size = new System.Drawing.Size(177, 22);
            this.txt_FindID.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tìm kiếm theo ID :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 39;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fTeacher_MagageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 569);
            this.Controls.Add(this.panel1);
            this.Name = "fTeacher_MagageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTeacher_MagageStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Mark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_FindID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FindName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_FindClass;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ReplaceInfo;
        private System.Windows.Forms.DataGridView datagrid_Mark;
        private System.Windows.Forms.Button button1;
    }
}