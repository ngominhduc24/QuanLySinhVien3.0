namespace Winform_QuanLySinhVien3._0
{
    partial class fTeacher_Mark
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
            this.txt_FindID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FindName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_FindClass = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ReplaceMark = new System.Windows.Forms.Button();
            this.datagrid_Mark = new System.Windows.Forms.DataGridView();
            this.btn_Find = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Mark)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_FindID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_FindName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbb_FindClass);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Find);
            this.panel1.Controls.Add(this.btn_ReplaceMark);
            this.panel1.Controls.Add(this.datagrid_Mark);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 539);
            this.panel1.TabIndex = 42;
            // 
            // txt_FindID
            // 
            this.txt_FindID.Location = new System.Drawing.Point(272, 19);
            this.txt_FindID.Name = "txt_FindID";
            this.txt_FindID.Size = new System.Drawing.Size(177, 22);
            this.txt_FindID.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tìm kiếm theo ID :";
            // 
            // txt_FindName
            // 
            this.txt_FindName.Location = new System.Drawing.Point(711, 19);
            this.txt_FindName.Name = "txt_FindName";
            this.txt_FindName.Size = new System.Drawing.Size(177, 22);
            this.txt_FindName.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tìm kiếm theo tên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tìm kiếm theo lớp :";
            // 
            // cbb_FindClass
            // 
            this.cbb_FindClass.FormattingEnabled = true;
            this.cbb_FindClass.Location = new System.Drawing.Point(474, 76);
            this.cbb_FindClass.Name = "cbb_FindClass";
            this.cbb_FindClass.Size = new System.Drawing.Size(101, 24);
            this.cbb_FindClass.TabIndex = 48;
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
            // btn_ReplaceMark
            // 
            this.btn_ReplaceMark.Location = new System.Drawing.Point(609, 456);
            this.btn_ReplaceMark.Name = "btn_ReplaceMark";
            this.btn_ReplaceMark.Size = new System.Drawing.Size(131, 64);
            this.btn_ReplaceMark.TabIndex = 39;
            this.btn_ReplaceMark.Text = "Lưu điểm";
            this.btn_ReplaceMark.UseVisualStyleBackColor = true;
            // 
            // datagrid_Mark
            // 
            this.datagrid_Mark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Mark.Location = new System.Drawing.Point(25, 114);
            this.datagrid_Mark.Name = "datagrid_Mark";
            this.datagrid_Mark.RowHeadersWidth = 51;
            this.datagrid_Mark.RowTemplate.Height = 24;
            this.datagrid_Mark.Size = new System.Drawing.Size(911, 326);
            this.datagrid_Mark.TabIndex = 38;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(444, 456);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(131, 64);
            this.btn_Find.TabIndex = 39;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // fTeacher_Mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 569);
            this.Controls.Add(this.panel1);
            this.Name = "fTeacher_Mark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTeacher_Mark";
            this.Load += new System.EventHandler(this.fTeacher_Mark_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Mark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ReplaceMark;
        private System.Windows.Forms.DataGridView datagrid_Mark;
        private System.Windows.Forms.TextBox txt_FindID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FindName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_FindClass;
        private System.Windows.Forms.Button btn_Find;
    }
}