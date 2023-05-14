using System;
using System.Collections.Generic;
using System.Data;

namespace people_dir.data
{
    internal class data
    {
        public static List<People> PeopleDatabase { get; set; }
        public static List<string> GroupDatabase { get; set; }


        public static void load_data()
        {
            PeopleController pc = new PeopleController();
            pc.PeopleFromFile();

            GroupDatabase = pc.retrieveGroupList();
            PeopleDatabase = pc.retrievePeopleList();
        }

        public static DataTable database_to_datagrid()
        {
            DataTable dtbl = new DataTable("People");

            dtbl.Columns.Add("ID");
            dtbl.Columns.Add("NUME");
            dtbl.Columns.Add("PRENUME");
            dtbl.Columns.Add("DATA NASTERII");
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
