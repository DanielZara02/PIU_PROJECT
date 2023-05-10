using System;
using System.Data;


namespace people_dir.data
{
    internal class data
    {

        public static DataTable file_to_datagrid()
        {

            PeopleController pc = new PeopleController();
            pc.PeopleFromFile();

            DataTable dtbl = new DataTable("People");

            dtbl.Columns.Add("ID");
            dtbl.Columns.Add("NUME");
            dtbl.Columns.Add("PRENUME");
            dtbl.Columns.Add("DATA NASTERII");
            dtbl.Columns.Add("TELEFON");
            dtbl.Columns.Add("MAIL");

            foreach (var people in pc.PeopleList)
            {
                DataRow row;
                row = dtbl.NewRow();
                row[People.ID] = people.ID_people;
                row[People.NAME] = people.NAME_people;
                row[People.SURNAME] = people.SURNAME_people;
                row[People.DATE_OF_BIRTH] = people.DATE_of_birth.ToString("yyyy-MM-dd");
                row[People.T_NUMBER] = people.T_NUMBER_people;
                row[People.EMAIL] = people.E_MAIL_people;
                dtbl.Rows.Add(row);
            }
            return dtbl;
        }
    }
}
