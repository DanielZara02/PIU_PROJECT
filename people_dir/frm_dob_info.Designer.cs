namespace people_dir
{
    partial class frm_dob_info
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
            this.lbl_congratulations = new System.Windows.Forms.Label();
            this.pnl_separator = new System.Windows.Forms.Panel();
            this.lbl_text = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pnl_none = new System.Windows.Forms.Panel();
            this.lbl_none_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pnl_none.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_congratulations
            // 
            this.lbl_congratulations.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_congratulations.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_congratulations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl_congratulations.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_congratulations.Location = new System.Drawing.Point(0, 0);
            this.lbl_congratulations.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbl_congratulations.Name = "lbl_congratulations";
            this.lbl_congratulations.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_congratulations.Size = new System.Drawing.Size(580, 69);
            this.lbl_congratulations.TabIndex = 0;
            this.lbl_congratulations.Text = "Felicitări!";
            this.lbl_congratulations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_congratulations.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_dob_info_MouseDown);
            // 
            // pnl_separator
            // 
            this.pnl_separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnl_separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator.Location = new System.Drawing.Point(0, 69);
            this.pnl_separator.Name = "pnl_separator";
            this.pnl_separator.Size = new System.Drawing.Size(580, 5);
            this.pnl_separator.TabIndex = 3;
            // 
            // lbl_text
            // 
            this.lbl_text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_text.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl_text.Location = new System.Drawing.Point(0, 87);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lbl_text.Size = new System.Drawing.Size(580, 45);
            this.lbl_text.TabIndex = 4;
            this.lbl_text.Text = "Persoanele care își serbează ziua de naștere la data curentă:\r\n";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.grid.Location = new System.Drawing.Point(0, 132);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.ShowCellToolTips = false;
            this.grid.ShowEditingIcon = false;
            this.grid.Size = new System.Drawing.Size(580, 165);
            this.grid.TabIndex = 7;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_ok.Location = new System.Drawing.Point(0, 297);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(580, 54);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pnl_none
            // 
            this.pnl_none.Controls.Add(this.lbl_none_text);
            this.pnl_none.Location = new System.Drawing.Point(0, 0);
            this.pnl_none.Name = "pnl_none";
            this.pnl_none.Size = new System.Drawing.Size(580, 297);
            this.pnl_none.TabIndex = 9;
            // 
            // lbl_none_text
            // 
            this.lbl_none_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_none_text.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_none_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl_none_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_none_text.Location = new System.Drawing.Point(0, 0);
            this.lbl_none_text.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lbl_none_text.Name = "lbl_none_text";
            this.lbl_none_text.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_none_text.Size = new System.Drawing.Size(580, 297);
            this.lbl_none_text.TabIndex = 1;
            this.lbl_none_text.Text = "Nu sunt persoanele care își serbează ziua de naștere la data curentă (\r\n";
            this.lbl_none_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_none_text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_dob_info_MouseDown);
            // 
            // frm_dob_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(580, 351);
            this.Controls.Add(this.pnl_none);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.pnl_separator);
            this.Controls.Add(this.lbl_congratulations);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dob_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dob_info";
            this.Load += new System.EventHandler(this.frm_dob_info_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_dob_info_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pnl_none.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_congratulations;
        private System.Windows.Forms.Panel pnl_separator;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel pnl_none;
        private System.Windows.Forms.Label lbl_none_text;
    }
}