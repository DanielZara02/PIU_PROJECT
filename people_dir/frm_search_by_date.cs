using people_dir.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_search_by_date : Form
    {
        public frm_search_by_date()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_search_by_date_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i <= DateTime.Today.Year; i++)
            {
                cb_year.Items.Add(i);
            }

            cb_month.SelectedIndex = 0;
            cb_year.SelectedIndex = 0;
        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtbl = data.data.database_to_datagrid();

            pnl_month_info.Hide();

            bool check = false;

            dtbl.Columns.Remove("TELEFON");
            dtbl.Columns.Remove("MAIL");
            dtbl.Columns.Remove("GRUP");


            for (int i = dtbl.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dtbl.Rows[i];

                string value = DateTime.Parse(row["DATA NASTERII"].ToString()).ToString("MM");

                if (value != cb_month.Text)
                {
                    row.Delete();
                    dtbl.AcceptChanges();
                }
                else
                    check = true;
            }
            if (check)
            {
                grid_month.DataSource = dtbl;

                this.grid_month.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid_month.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid_month.Columns["PRENUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid_month.Columns["DATA NASTERII"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
                pnl_month_info.Show();
            
        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtbl = data.data.database_to_datagrid();

            pnl_year_info.Hide();

            bool check = false;

            dtbl.Columns.Remove("TELEFON");
            dtbl.Columns.Remove("MAIL");
            dtbl.Columns.Remove("GRUP");


            for (int i = dtbl.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dtbl.Rows[i];

                string value = DateTime.Parse(row["DATA NASTERII"].ToString()).ToString("yyyy");

                if (value != cb_year.Text)
                {
                    row.Delete();
                    dtbl.AcceptChanges();
                }
                else
                    check = true;
            }
            if (check)
            {
                grid_year.DataSource = dtbl;

                this.grid_year.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid_year.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid_year.Columns["PRENUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid_year.Columns["DATA NASTERII"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
                pnl_year_info.Show();
        }

        private void frm_search_by_date_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }
    }
}
