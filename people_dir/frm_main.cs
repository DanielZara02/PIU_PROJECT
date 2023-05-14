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
        //forma principal a aplicatie
        public frm_main()
        {
            InitializeComponent();
        }

        //la incarcarea formei se apeleaza functiile de extragere si afisare a datelor din fisier
        //se afiseaza forma cu persoanele care isi serbeaza astazi ziua de naster
        private void frm_main_Load(object sender, EventArgs e)
        {
            data_fill();
            grid_fill();
            btn_show.Hide();

            frm_dob_info f = new frm_dob_info();
            f.ShowDialog();
        }

        //functia de incarcare a datelor din fisier si afisare in DataGridView
        private void data_fill()
        {
            data.data.load_data();
            DataTable dtbl = data.data.database_to_datagrid();
            grid.DataSource = dtbl;
        }

        //functia de adaugare a 2 coloane nou in DataGridView
        //Coloana EDIT - care va avea rolul de editare a datelor persoanei
        //Coloana DELETE - care va avea rolul de sterege a persoanei
        //modifica style - ul coloanelor din tabel

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

        //event-ul de inchidere a aplicatiei
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //filtrarea persoanelor dupa nume, prenume, numar de telefon
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_search.Text.Contains(" "))
                {
                    string[] line = txt_search.Text.Split(' ');
                    (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("NUME LIKE '%{0}%' AND PRENUME LIKE '%{1}%'", line[0], line[1]) ;

                }
                else
                {
                    (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("TELEFON LIKE '%{0}%' OR MAIL LIKE '%{0}%'", txt_search.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //event-ul de afisare a butoanelor pricipale
        private void btn_show_Click(object sender, EventArgs e)
        {
            pnl_control.Show();
            btn_show.Hide();
            btn_hide.Show();
        }

        //event-ul de ascudere a butoanelor pricipale
        private void btn_hide_Click(object sender, EventArgs e)
        {
            pnl_control.Hide();
            btn_show.Show();
            btn_hide.Hide();
        }

        //event-ul de mutare a formei
        //cand mouse-ul este pe forma si va fi apasat button -ul principal al mouse-ului forma se misca
        private void frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program. SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }

        //event-ul de adaugare a unei persoane
        private void btn_add_people_Click(object sender, EventArgs e)
        {
            frm_add_people f = new frm_add_people();
            f.ShowDialog();
            data_fill();
            return;
        }

        //event-ul de tastare pe DataGridView
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row Headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            //index-ul coloanelor EDIT si DELETE
            int edit_id = grid.Columns["EDIT"].Index;
            int delete_id = grid.Columns["DELETE"].Index;

            //valorile persoanei alese
            int id_people = Int32.Parse(grid.CurrentRow.Cells["ID"].Value.ToString());
            string name_people = grid.CurrentRow.Cells["NUME"].Value.ToString();
            string surname_people = grid.CurrentRow.Cells["PRENUME"].Value.ToString();

            //apelarea la forma de editare a persoanei
            if (e.ColumnIndex == edit_id)
            {
                frm_edit_people f = new frm_edit_people();

                //adaugam valorile persoanei alese in variabilele din form de editare
                f.id_people = id_people;
                f.name_people = name_people;
                f.surname_people = surname_people;

                try
                {
                    string message = string.Format("Doriți să modificați datele persoanei: [{0}] din fișier?", f.name_people + " " + f.surname_people);

                    if (MessageBox.Show(message, "Confirmați Modificarea!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //adaugam valorile persoanei alese in componentele din form de editare

                        f.txt_name.Text = grid.Rows[e.RowIndex].Cells["NUME"].Value.ToString();
                        f.txt_surname.Text = grid.Rows[e.RowIndex].Cells["PRENUME"].Value.ToString();
                        f.dtp_date_of_birth.Value = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells["DATA_NASTERII"].Value.ToString());
                        f.txt_t_number.Text = grid.Rows[e.RowIndex].Cells["TELEFON"].Value.ToString();

                        string mail = grid.Rows[e.RowIndex].Cells["MAIL"].Value.ToString();
                        string[] _mail = mail.Split('@');

                        f.txt_mail.Text = _mail[0];
                        f.cb_mail.SelectedIndex = f.cb_mail.FindStringExact("@" + _mail[1]);

                        //adaugam lista de grupuri in combobox-ul din forma de editare
                        foreach (string group in data.data.GroupDatabase)
                        {
                            f.cb_group.Items.Add(group);
                        }

                        f.cb_group.SelectedIndex = f.cb_group.FindStringExact(grid.Rows[e.RowIndex].Cells["GRUP"].Value.ToString());

                        f.ShowDialog();

                        data_fill();

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
                //apelam functia de stergere a persoanei
                try
                {
                    string message = string.Format("Doriți să ștergeți persoana: [{0}] din fișier?", name_people + " " + surname_people);

                    if (MessageBox.Show(message, "Confirmați Ștergerea!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PeopleController pc = new PeopleController();
                        pc.DeletePeople(id_people, name_people, surname_people);
                        data_fill();

                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //event-ul de filtare dupa luna si an
        private void btn_search_date_Click(object sender, EventArgs e)
        {
            frm_search_by_date f = new frm_search_by_date();
            f.ShowDialog();
        }

        //event-ul de filtare dupa grupe
        private void btn_people_group_Click(object sender, EventArgs e)
        {
            frm_group f = new frm_group();
            f.ShowDialog();
        }
    }
}
