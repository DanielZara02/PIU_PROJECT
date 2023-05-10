using System;

namespace people_dir.data
{
    internal class People
    {

        public static int count = 0;

        public const int ID = 0;
        public const int NAME = 1;
        public const int SURNAME = 2;
        public const int DATE_OF_BIRTH = 3;
        public const int T_NUMBER = 4;
        public const int EMAIL = 5;

        private int id_people;
        private string name_people;
        private string surname_people;
        private DateTime date_of_birth;
        private string t_number_people;
        private string e_mail_people;

        public int ID_people
        {
            get
            {
                return this.id_people;
            }

            set
            {
                this.id_people = value;
            }
        }

        public string NAME_people
        {
            get
            {
                return this.name_people;
            }

            set
            {
                this.name_people = value;
            }
        }


        public string SURNAME_people
        {
            get
            {
                return this.surname_people;
            }

            set
            {
                this.surname_people = value;
            }
        }

        public DateTime DATE_of_birth
        {
            get
            {
                return this.date_of_birth;
            }

            set
            {
                this.date_of_birth = value;
            }
        }


        public string T_NUMBER_people
        {
            get
            {
                return this.t_number_people;
            }

            set
            {
                this.t_number_people = value;
            }
        }

        public string E_MAIL_people
        {
            get
            {
                return this.e_mail_people;
            }

            set
            {
                this.e_mail_people = value;
            }
        }


        public People()
        {
            name_people = surname_people = e_mail_people = t_number_people = string.Empty;
        }

        public People(int id_people, string name_people, string surname_people, DateTime date_of_birth, string t_number_people, string e_mail_people)
        {
            this.id_people = id_people;
            this.name_people = name_people;
            this.surname_people = surname_people;
            this.date_of_birth = date_of_birth;
            this.t_number_people = t_number_people;
            this.e_mail_people = e_mail_people;

            People.count++;
        }
    }
}
