using people_dir.data;
using people_dir.Properties;
using System;
using System.Data;
using System.Drawing;
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
            fill_data();
            grid_fill();
            btn_show.Hide();

            frm_dob_info f = new frm_dob_info();
            f.ShowDialog();
        }

        private void fill_data()
        {
            data.data.load_data();
            DataTable dtbl = data.data.database_to_datagrid();
            grid.DataSource = dtbl;
        }
        private void grid_fill()
        {
            if (grid.Columns.Contains("EDIT") == false && grid.Columns.Contains("DELETE") == false)
            {

                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                DataGridViewImageColumn delete = new DataGridViewImageColumn();
                Image image;

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

                this.grid.Columns["EDIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns["DELETE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            this.grid.Columns[People.ID].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.SURNAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.DATE_OF_BIRTH].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns[People.T_NUMBER].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns[People.EMAIL].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns[People.GROUP_NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
           
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
            fill_data();
            return;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row Headers

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            int edit_id = grid.Columns["EDIT"].Index;
            int delete_id = grid.Columns["DELETE"].Index;

            int id_people = Int32.Parse(grid.CurrentRow.Cells["ID"].Value.ToString());
            string name_people = grid.CurrentRow.Cells["NUME"].Value.ToString();
            string surname_people = grid.CurrentRow.Cells["PRENUME"].Value.ToString();

            if (e.ColumnIndex == edit_id)
            {
                frm_edit_people f = new frm_edit_people();


                f.id_people = id_people;
                f.name_people = name_people;
                f.surname_people = surname_people;

                try
                {
                    string message = string.Format("Doriți să modificați datele persoanei: [{0}] din fișier?", f.name_people + " " + f.surname_people);

                    if (MessageBox.Show(message, "Confirmați Modificarea!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        f.txt_name.Text = grid.Rows[e.RowIndex].Cells["NUME"].Value.ToString();
                        f.txt_surname.Text = grid.Rows[e.RowIndex].Cells["PRENUME"].Value.ToString();
                        f.dtp_date_of_birth.Value = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells["DATA NASTERII"].Value.ToString());
                        f.txt_t_number.Text = grid.Rows[e.RowIndex].Cells["TELEFON"].Value.ToString();

                        string mail = grid.Rows[e.RowIndex].Cells["MAIL"].Value.ToString();
                        string[] _mail = mail.Split('@');

                        f.txt_mail.Text = _mail[0];
                        f.cb_mail.Text = "@" + _mail[1];

                        f.cb_group.Text = grid.Rows[e.RowIndex].Cells["GRUP"].Value.ToString();

                        f.ShowDialog();

                        fill_data();

                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == delete_id)
            {
                try
                {
                    string message = string.Format("Doriți să ștergeți persoana: [{0}] din fișier?", name_people + " " + surname_people);

                    if (MessageBox.Show(message, "Confirmați Ștergerea!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PeopleController pc = new PeopleController();
                        pc.DeletePeople(id_people, name_people, surname_people);
                        fill_data();

                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_search_date_Click(object sender, EventArgs e)
        {
            frm_search_by_date f = new frm_search_by_date();
            f.ShowDialog();
        }

        private void btn_people_group_Click(object sender, EventArgs e)
        {
            frm_group f = new frm_group();
            f.ShowDialog();
        }
    }
}
