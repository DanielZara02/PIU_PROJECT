namespace people_dir
{
    partial class frm_search_by_date
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_year = new System.Windows.Forms.DataGridView();
            this.grid_month = new System.Windows.Forms.DataGridView();
            this.pnl_year_info = new System.Windows.Forms.Panel();
            this.lbl_year_text = new System.Windows.Forms.Label();
            this.pnl_month_info = new System.Windows.Forms.Panel();
            this.lbl_month_text = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_month)).BeginInit();
            this.pnl_year_info.SuspendLayout();
            this.pnl_month_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(732, 52);
            this.pnl_header.TabIndex = 5;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_search_by_date_MouseDown);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = global::people_dir.Properties.Resources.multiply_64px;
            this.btn_exit.Location = new System.Drawing.Point(672, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(48, 30);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 5;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.lbl_header.Size = new System.Drawing.Size(150, 52);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Căutare";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cb_year, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_month, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grid_year, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grid_month, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 374);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // cb_year
            // 
            this.cb_year.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_year.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cb_year.FormattingEnabled = true;
            this.cb_year.IntegralHeight = false;
            this.cb_year.ItemHeight = 25;
            this.cb_year.Location = new System.Drawing.Point(369, 45);
            this.cb_year.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(360, 33);
            this.cb_year.TabIndex = 27;
            this.cb_year.SelectedIndexChanged += new System.EventHandler(this.cb_year_SelectedIndexChanged);
            this.cb_year.TextChanged += new System.EventHandler(this.cb_year_SelectedIndexChanged);
            // 
            // cb_month
            // 
            this.cb_month.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_month.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cb_month.FormattingEnabled = true;
            this.cb_month.IntegralHeight = false;
            this.cb_month.ItemHeight = 25;
            this.cb_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cb_month.Location = new System.Drawing.Point(3, 45);
            this.cb_month.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(360, 33);
            this.cb_month.TabIndex = 26;
            this.cb_month.SelectedIndexChanged += new System.EventHandler(this.cb_month_SelectedIndexChanged);
            this.cb_month.TextChanged += new System.EventHandler(this.cb_month_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(369, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persoane născute în anul:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persoane născute în luna:";
            // 
            // grid_year
            // 
            this.grid_year.AllowUserToAddRows = false;
            this.grid_year.AllowUserToDeleteRows = false;
            this.grid_year.AllowUserToResizeColumns = false;
            this.grid_year.AllowUserToResizeRows = false;
            this.grid_year.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_year.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.grid_year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_year.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_year.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_year.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_year.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_year.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_year.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_year.EnableHeadersVisualStyles = false;
            this.grid_year.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.grid_year.Location = new System.Drawing.Point(369, 103);
            this.grid_year.MultiSelect = false;
            this.grid_year.Name = "grid_year";
            this.grid_year.ReadOnly = true;
            this.grid_year.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_year.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_year.RowHeadersVisible = false;
            this.grid_year.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_year.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_year.ShowCellToolTips = false;
            this.grid_year.ShowEditingIcon = false;
            this.grid_year.Size = new System.Drawing.Size(360, 268);
            this.grid_year.TabIndex = 24;
            // 
            // grid_month
            // 
            this.grid_month.AllowUserToAddRows = false;
            this.grid_month.AllowUserToDeleteRows = false;
            this.grid_month.AllowUserToResizeColumns = false;
            this.grid_month.AllowUserToResizeRows = false;
            this.grid_month.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_month.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.grid_month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_month.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_month.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_month.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_month.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_month.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_month.EnableHeadersVisualStyles = false;
            this.grid_month.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.grid_month.Location = new System.Drawing.Point(3, 103);
            this.grid_month.MultiSelect = false;
            this.grid_month.Name = "grid_month";
            this.grid_month.ReadOnly = true;
            this.grid_month.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_month.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_month.RowHeadersVisible = false;
            this.grid_month.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_month.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_month.ShowCellToolTips = false;
            this.grid_month.ShowEditingIcon = false;
            this.grid_month.Size = new System.Drawing.Size(360, 268);
            this.grid_month.TabIndex = 23;
            // 
            // pnl_year_info
            // 
            this.pnl_year_info.Controls.Add(this.lbl_year_text);
            this.pnl_year_info.Location = new System.Drawing.Point(369, 179);
            this.pnl_year_info.Name = "pnl_year_info";
            this.pnl_year_info.Size = new System.Drawing.Size(363, 268);
            this.pnl_year_info.TabIndex = 7;
            // 
            // lbl_year_text
            // 
            this.lbl_year_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_year_text.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_year_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl_year_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_year_text.Location = new System.Drawing.Point(0, 0);
            this.lbl_year_text.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_year_text.Name = "lbl_year_text";
            this.lbl_year_text.Size = new System.Drawing.Size(363, 268);
            this.lbl_year_text.TabIndex = 2;
            this.lbl_year_text.Text = "Nu sunt persoane născute în acest an";
            this.lbl_year_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_month_info
            // 
            this.pnl_month_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.pnl_month_info.Controls.Add(this.lbl_month_text);
            this.pnl_month_info.Location = new System.Drawing.Point(3, 179);
            this.pnl_month_info.Name = "pnl_month_info";
            this.pnl_month_info.Size = new System.Drawing.Size(360, 268);
            this.pnl_month_info.TabIndex = 8;
            // 
            // lbl_month_text
            // 
            this.lbl_month_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_month_text.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_month_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl_month_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_month_text.Location = new System.Drawing.Point(0, 0);
            this.lbl_month_text.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_month_text.Name = "lbl_month_text";
            this.lbl_month_text.Size = new System.Drawing.Size(360, 268);
            this.lbl_month_text.TabIndex = 2;
            this.lbl_month_text.Text = "Nu sunt persoane născute în această luna";
            this.lbl_month_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_search_by_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.pnl_month_info);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_year_info);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_search_by_date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_search_by_date";
            this.Load += new System.EventHandler(this.frm_search_by_date_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_search_by_date_MouseDown);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_month)).EndInit();
            this.pnl_year_info.ResumeLayout(false);
            this.pnl_month_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_year;
        private System.Windows.Forms.DataGridView grid_month;
        private System.Windows.Forms.Panel pnl_year_info;
        private System.Windows.Forms.Panel pnl_month_info;
        private System.Windows.Forms.Label lbl_year_text;
        private System.Windows.Forms.Label lbl_month_text;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.ComboBox cb_month;
    }
}