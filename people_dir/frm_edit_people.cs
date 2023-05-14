using people_dir.data;
using System;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_edit_people : Form
    {
        //forma de modificare a datelor unei persoane
        public frm_edit_people()
        {
            InitializeComponent();
        }

        //variabile datelor (nemodificate) persoanei alese
        public int id_people;
        public string name_people;
        public string surname_people;

        //apelarea functiei de editare cu variabilele de mai sus si cu datele din componente ca parametre
        private void btn_ok_Click(object sender, EventArgs e)
        {
            PeopleController pc = new PeopleController();

            if (txt_name.Text.Length == 0 || txt_surname.Text.Length == 0 || txt_t_number.Text.Length == 0 || txt_mail.Text.Length == 0)
            {
                MessageBox.Show("Completați toate căsuțele!", "Alert!");
            }
            else if (txt_name.Text.Length < 3 || txt_surname.Text.Length < 3 || txt_t_number.Text.Length < 3 || txt_mail.Text.Length < 3)
            {
                MessageBox.Show("Completați cu minim 3 caractere!", "Alert!");
            }
            else
            {
                MessageBox.Show("Datele persoanei au fost modificate cu success!", "Success!");

                pc.EditPeople(id_people, name_people, surname_people, txt_name.Text, txt_surname.Text, dtp_date_of_birth.Value, txt_t_number.Text, txt_mail.Text + cb_mail.Text, cb_group.Text);

                this.Dispose();
            }
        }

        //event-ul de inchidere a formei
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //event-ul de mutare a formei
        //cand mouse-ul este pe forma si va fi apasat button -ul principal al mouse-ului forma se misca
        private void frm_edit_people_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }
    }
}
