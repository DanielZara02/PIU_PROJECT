using people_dir.data;
using System;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_add_people : Form
    {
        //forma de adaugare a unei persoane

        public frm_add_people()
        {
            InitializeComponent();
        }

        //event-ul de inchidere a formei
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //event-ul de mutare a formei
        //cand mouse-ul este pe forma si va fi apasat button -ul principal al mouse-ului forma se misca
        private void frm_add_people_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }

        //la incarcarea formei se va adauga valorile din lista GroupDatabase in combobox-ul cb_group
        private void frm_add_people_Load(object sender, EventArgs e)
        {
            foreach (string group in data.data.GroupDatabase)
            {
                cb_group.Items.Add(group);
            }

            cb_group.SelectedIndex = 0;
            cb_mail.SelectedIndex = 0;

        }

        //apelarea functiei de adaugare a persoanei cu valorile din componentele formei ca parametre
        private void btn_ok_Click(object sender, EventArgs e)
        {
            PeopleController pc = new PeopleController();

            if(txt_name.Text.Length == 0 || txt_surname.Text.Length == 0 || txt_t_number.Text.Length == 0 || txt_mail.Text.Length == 0)
            {
                MessageBox.Show("Completați toate căsuțele!", "Alert!");
            }
            else if (txt_name.Text.Length < 3 || txt_surname.Text.Length < 3 || txt_t_number.Text.Length < 3 || txt_mail.Text.Length < 3)
            {
                MessageBox.Show("Completați cu minim 3 caractere!", "Alert!");
            }
            else
            {
                MessageBox.Show("Persoana a fost adăugată cu success!", "Success!");

                pc.AddPeople(txt_name.Text, txt_surname.Text, dtp_date_of_birth.Value, txt_t_number.Text, txt_mail.Text + cb_mail.Text, cb_group.Text);

                txt_name.Text = null;
                txt_surname.Text = null;
                txt_t_number.Text = null;
                txt_mail.Text = null;
                cb_group.SelectedIndex = 0;
                cb_mail.SelectedIndex = 0;

                this.Dispose();
            }
        }
    }
}
