using people_dir.data;
using System;
using System.Data;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_dob_info : Form
    {
        public frm_dob_info()
        {
            InitializeComponent();
        }
        private void frm_dob_info_Load(object sender, EventArgs e)
        {
            pnl_none.Hide();

            bool check = false;

            DataTable dtbl = data.data.database_to_datagrid();


            for (int i = dtbl.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dtbl.Rows[i];

                string value = DateTime.Parse(row[People.DATE_OF_BIRTH].ToString()).ToString("MM-dd");

                if (value != DateTime.Today.ToString("MM-dd"))
                {
                    row.Delete();
                    dtbl.AcceptChanges();
                }
                else
                    check = true;
            }

            if (check)
            {
                grid.DataSource = dtbl;

                this.grid.Columns[People.ID].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns[People.NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns[People.SURNAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns[People.DATE_OF_BIRTH].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns[People.T_NUMBER].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns[People.EMAIL].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
                pnl_none.Show();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_dob_info_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }
    }
}
