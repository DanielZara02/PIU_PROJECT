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
    public partial class frm_group : Form
    {
        public frm_group()
        {
            InitializeComponent();
        }

        private void frm_group_Load(object sender, EventArgs e)
        {
            foreach (string group in data.data.GroupDatabase)
            {
                cb_group.Items.Add(group);
            }

            cb_group.SelectedIndex = 0;
        }

        private void cb_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtbl = data.data.database_to_datagrid();

            dtbl.Columns.Remove("DATA NASTERII");
            dtbl.Columns.Remove("TELEFON");
            dtbl.Columns.Remove("MAIL");


            for (int i = dtbl.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dtbl.Rows[i];

                if (row["GRUP"].ToString() != cb_group.Text)
                {
                    row.Delete();
                    dtbl.AcceptChanges();
                }
                grid.DataSource = dtbl;

                this.grid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid.Columns["PRENUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid.Columns["GRUP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_group_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }
    }
}
