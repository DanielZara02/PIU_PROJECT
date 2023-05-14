namespace people_dir
{
    partial class frm_edit_people
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
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_mail = new System.Windows.Forms.ComboBox();
            this.dtp_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_t_number = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.cb_group = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::people_dir.Properties.Resources.multiply_64px;
            this.btn_close.Location = new System.Drawing.Point(379, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(48, 30);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 4;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_surname
            // 
            this.txt_surname.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txt_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txt_surname.Location = new System.Drawing.Point(41, 182);
            this.txt_surname.Multiline = true;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(347, 29);
            this.txt_surname.TabIndex = 2;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btn_ok.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ok.Location = new System.Drawing.Point(42, 494);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(346, 44);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "Modifică";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(38, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = "Grup";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(38, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "E - mail";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(38, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Număr telefon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(38, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data nașterii";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(38, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Prenume";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_mail
            // 
            this.cb_mail.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_mail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mail.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cb_mail.FormattingEnabled = true;
            this.cb_mail.ItemHeight = 25;
            this.cb_mail.Items.AddRange(new object[] {
            "@gmail.com",
            "@yahoo.com",
            "@mail.ru",
            "@yandex.ru",
            "@hotmail.com",
            "@aol.com",
            "@outlook.com"});
            this.cb_mail.Location = new System.Drawing.Point(243, 376);
            this.cb_mail.Name = "cb_mail";
            this.cb_mail.Size = new System.Drawing.Size(145, 33);
            this.cb_mail.TabIndex = 6;
            // 
            // dtp_date_of_birth
            // 
            this.dtp_date_of_birth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dtp_date_of_birth.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtp_date_of_birth.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtp_date_of_birth.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dtp_date_of_birth.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dtp_date_of_birth.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.dtp_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_of_birth.Location = new System.Drawing.Point(42, 243);
            this.dtp_date_of_birth.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dtp_date_of_birth.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtp_date_of_birth.Name = "dtp_date_of_birth";
            this.dtp_date_of_birth.Size = new System.Drawing.Size(346, 32);
            this.dtp_date_of_birth.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mail.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txt_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txt_mail.Location = new System.Drawing.Point(42, 376);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(194, 33);
            this.txt_mail.TabIndex = 5;
            // 
            // txt_t_number
            // 
            this.txt_t_number.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_t_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_t_number.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txt_t_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txt_t_number.Location = new System.Drawing.Point(42, 311);
            this.txt_t_number.Multiline = true;
            this.txt_t_number.Name = "txt_t_number";
            this.txt_t_number.Size = new System.Drawing.Size(346, 29);
            this.txt_t_number.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txt_name.Location = new System.Drawing.Point(42, 117);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(346, 29);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_header.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_header.Size = new System.Drawing.Size(285, 52);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Modifică";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(430, 52);
            this.pnl_header.TabIndex = 24;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_edit_people_MouseDown);
            // 
            // cb_group
            // 
            this.cb_group.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_group.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cb_group.FormattingEnabled = true;
            this.cb_group.ItemHeight = 25;
            this.cb_group.Location = new System.Drawing.Point(43, 445);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(345, 33);
            this.cb_group.TabIndex = 33;
            // 
            // frm_edit_people
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(430, 556);
            this.Controls.Add(this.cb_group);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_mail);
            this.Controls.Add(this.dtp_date_of_birth);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_t_number);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_edit_people";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_edit_people";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_edit_people_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Panel pnl_header;
        public System.Windows.Forms.TextBox txt_surname;
        public System.Windows.Forms.ComboBox cb_mail;
        public System.Windows.Forms.DateTimePicker dtp_date_of_birth;
        public System.Windows.Forms.TextBox txt_mail;
        public System.Windows.Forms.TextBox txt_t_number;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.ComboBox cb_group;
    }
}