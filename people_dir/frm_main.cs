using people_dir.data;
using people_dir.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            data.data.load_data();
            grid_fill();
            pnl_control.Hide();
            btn_hide.Hide();

            frm_dob_info f = new frm_dob_info();
            f.ShowDialog();
        }

        private void grid_fill()
        {
            DataTable dtbl = data.data.database_to_datagrid();
            grid.DataSource = dtbl;

            DataGridViewImageColumn edit = new DataGridViewImageColumn();
            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            Image image;

            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                DataGridViewRow row = grid.Rows[i];

                string value = DateTime.Parse(row.Cells[People.DATE_OF_BIRTH].Value.ToString()).ToString("MM-dd");

                if (value == DateTime.Today.ToString("MM-dd"))
                {
                    grid.Rows[row.Index].DefaultCellStyle.ForeColor = Color.FromArgb(235, 42, 83);
                }
            }

            image = Resources.pencil_64px;
            edit.Image = image;
            grid.Columns.Add(edit);
            edit.HeaderText = "EDIT";
            edit.Name = "EDIT";
            this.grid.Columns["EDIT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ((DataGridViewImageColumn)grid.Columns["EDIT"]).ImageLayout = DataGridViewImageCellLayout.Zoom;


            image = Resources.trash_can_64px;
            delete.Image = image;
            grid.Columns.Add(delete);
            delete.HeaderText = "DELETE";
            delete.Name = "DELETE";
            this.grid.Columns["DELETE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ((DataGridViewImageColumn)grid.Columns["DELETE"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            this.grid.Columns[People.ID].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.SURNAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.DATE_OF_BIRTH].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns[People.T_NUMBER].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns[People.EMAIL].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.GROUP_NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["EDIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["DELETE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void add_person_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("NUME LIKE '%{0}%' OR TELEFON LIKE '%{0}%' OR MAIL LIKE '%{0}%'", txt_search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            pnl_control.Show();
            btn_show.Hide();
            btn_hide.Show();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            pnl_control.Hide();
            btn_show.Show();
            btn_hide.Hide();
        }

        private void frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program. SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }

        private void btn_add_people_Click(object sender, EventArgs e)
        {
            frm_add_people f = new frm_add_people();
            f.ShowDialog();
        }
    }
}
