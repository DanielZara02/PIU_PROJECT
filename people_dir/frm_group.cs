using System;
using System.Data;
using System.Windows.Forms;

namespace people_dir
{
    public partial class frm_group : Form
    {
        //forma de filtrare a datelor dupa grupe
        public frm_group()
        {
            InitializeComponent();
        }

        //la incarcarea formei se va adauga in combobox-ul cb_group datele din lista GroupDatabase
        private void frm_group_Load(object sender, EventArgs e)
        {
            foreach (string group in data.data.GroupDatabase)
            {
                cb_group.Items.Add(group);
            }

            cb_group.SelectedIndex = 0;
        }

        //cand se va modifica index-ul (valoarea) combobox - ului, va avea loc filtrarea datelor
        private void cb_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            //creeaza un tabel "virtual" cu datele din fisier
            DataTable dtbl = data.data.database_to_datagrid();

            //sterge coloanele care nu ne intereseaza
            dtbl.Columns.Remove("DATA_NASTERII");
            dtbl.Columns.Remove("TELEFON");
            dtbl.Columns.Remove("MAIL");

            //atribuie in DataGridView datele din tabelul creat
            grid.DataSource = dtbl;

            //filtreaza datele dupa o anumita conditie (grup)
            (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("GRUP LIKE '%{0}%'", cb_group.Text);

            //modifica style - ul coloanelor din tabel
            this.grid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns["PRENUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns["GRUP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        //event-ul de inchidere a formei
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //event-ul de mutare a formei
        //cand mouse-ul este pe forma si va fi apasat button -ul principal al mouse-ului forma se misca
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
