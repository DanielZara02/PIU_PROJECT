using people_dir.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
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
            DataTable dtbl = data.data.file_to_datagrid();
            grid.DataSource = dtbl;

            //la deschiderea aplicației vor fi afișate persoanele care își serbează ziua de naștere la data curentă
            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                DataGridViewRow row = grid.Rows[i];

                string value = DateTime.Parse(row.Cells[People.DATE_OF_BIRTH].Value.ToString()).ToString("MM-dd");

                if (value == DateTime.Today.ToString("MM-dd"))
                {
                    grid.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Red;
                    grid.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
        }

        private void add_person_Click(object sender, EventArgs e)
        {

        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            //functia de cautare a persoanelor dupa nume, prenume etc.
            try
            {
                (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("NUME LIKE '%{0}%' OR TELEFON LIKE '%{0}%' OR MAIL LIKE '%{0}%'", txt_search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
