using System;
using System.Data;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_search_by_date : Form
    {
        //forma de filtare a datelor dupa luna si an
        public frm_search_by_date()
        {
            InitializeComponent();
        }

        //event-ul de inchidere a formei
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //event-ul de incarcare a formei
        private void frm_search_by_date_Load(object sender, EventArgs e)
        {
            //se va adauga in combobox-ul cb_year anii incepand cu 1920 pana la anul curent 

            for (int i = 1920; i < DateTime.Now.Year; i++)
            {
                cb_year.Items.Add(i);
            }

            cb_month.SelectedIndex = 0;
            cb_year.SelectedIndex = 0;
        }

        //event-ul de modificare a index-ului (valorii) a combobox-ului cb_month
        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            //extrage datele din fisier intr-un tabel "virtual"
            DataTable dtbl = data.data.database_to_datagrid();

            pnl_month_info.Hide();

            bool check = false;

            //sterge valorile care nu ne trebuie
            dtbl.Columns.Remove("TELEFON");
            dtbl.Columns.Remove("MAIL");
            dtbl.Columns.Remove("GRUP");

            //folosim ca sursa tabelul creat pentru a completa DataGridView-ul
            grid_month.DataSource = dtbl;

            //filtram datele
            (grid_month.DataSource as DataTable).DefaultView.RowFilter = string.Format("DATA_NASTERII LIKE '%-{0}-%'", cb_month.Text);

            if (grid_month.Rows.Count != 0)
            {
                check = true;
            }
            if (check)
            {
                //modificam style - ul tabelului
                this.grid_month.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid_month.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid_month.Columns["PRENUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid_month.Columns["DATA_NASTERII"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
                pnl_month_info.Show();
        }

        //event-ul de modificare a index-ului (valorii) a combobox-ului cb_year
        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            //extrage datele din fisier intr-un tabel "virtual"
            DataTable dtbl = data.data.database_to_datagrid();

            pnl_year_info.Hide();

            bool check = false;

            //sterge valorile care nu ne trebuie
            dtbl.Columns.Remove("TELEFON");
            dtbl.Columns.Remove("MAIL");
            dtbl.Columns.Remove("GRUP");

            //folosim ca sursa tabelul creat pentru a completa DataGridView-ul
            grid_year.DataSource = dtbl;

            //filtram datele
            (grid_year.DataSource as DataTable).DefaultView.RowFilter = string.Format("DATA_NASTERII LIKE '%{0}-%'", cb_year.Text);

            if (grid_year.Rows.Count != 0)
            {
                check = true;
            }
            if (check)
            { 
                //modificam style - ul tabelului
                this.grid_year.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.grid_year.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid_year.Columns["PRENUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.grid_month.Columns["DATA_NASTERII"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
                pnl_year_info.Show();
        }

        //event-ul de mutare a formei
        //cand mouse-ul este pe forma si va fi apasat button -ul principal al mouse-ului forma se misca
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
