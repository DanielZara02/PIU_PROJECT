using System;
using System.Data;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_dob_info : Form
    {
        //forma care va arata lista de persoane care serbeaza data de naster astazi
        public frm_dob_info()
        {
            InitializeComponent();
        }

        //event-ul de incarcare a formei
        private void frm_dob_info_Load(object sender, EventArgs e)
        {
            //creeaza un tabel "virtual" cu datele din fisier

            DataTable dtbl = data.data.database_to_datagrid();

            pnl_none.Hide();

            bool check = false;

            //sterge coloanele care nu ne intereseaza
            dtbl.Columns.Remove("TELEFON");
            dtbl.Columns.Remove("MAIL");
            dtbl.Columns.Remove("GRUP");

            //atribuie ca sursa pentru DataGridView tabelul creat
            grid.DataSource = dtbl;

            //filtreaza datele dupa data de nastere, ca sa satisfaca conditia data
            (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("DATA_NASTERII LIKE '%{0}%'", DateTime.Today.ToString("MM-dd"));

            if(grid.Rows.Count != 0)
            {
                check = true;
            }
            if (check)
            {
                //modifica style - ul coloanelor din tabel
                this.grid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid.Columns["PRENUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid.Columns["DATA_NASTERII"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
                pnl_none.Show();
        }

        //event-ul de inchidere a aplicatiei
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //event-ul de mutare a formei
        //cand mouse-ul este pe forma si va fi apasat button -ul principal al mouse-ului forma se misca
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
