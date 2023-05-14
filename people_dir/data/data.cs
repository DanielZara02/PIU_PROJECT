using System.Collections.Generic;
using System.Data;

namespace people_dir.data
{
    internal class data
    {
        //lista persoanelor si a grup -urilor salvate in .txt
        public static List<People> PeopleDatabase { get; set; }
        public static List<string> GroupDatabase { get; set; }


        //apelul functiei de extragere a datelor din fisier si le adauga in liste
        public static void load_data()
        {
            PeopleController pc = new PeopleController();
            pc.PeopleFromFile();

            GroupDatabase = pc.retrieveGroupList();
            PeopleDatabase = pc.retrievePeopleList();
        }

        //creaza un tabel "virtual" cu datele extrase
        public static DataTable database_to_datagrid()
        {
            DataTable dtbl = new DataTable("People");

            dtbl.Columns.Add("ID");
            dtbl.Columns.Add("NUME");
            dtbl.Columns.Add("PRENUME");
            dtbl.Columns.Add("DATA_NASTERII");
            dtbl.Columns.Add("TELEFON");
            dtbl.Columns.Add("MAIL");
            dtbl.Columns.Add("GRUP");

            foreach (var people in PeopleDatabase)
            {
                DataRow row;
                row = dtbl.NewRow();
                row[People.ID] = people.id_people;
                row[People.NAME] = people.name_people;
                row[People.SURNAME] = people.surname_people;
                row[People.DATE_OF_BIRTH] = people.date_of_birth.ToString("yyyy-MM-dd");
                row[People.T_NUMBER] = people.t_number_people;
                row[People.EMAIL] = people.e_mail_people;
                row[People.GROUP_NAME] = people.group_people_name;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
    }
}
