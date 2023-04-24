using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENTENARUL_MARII_UNIRI.Models
{
    internal class Utilizator
    {

        private int id;
        private string email;
        private string name;
        private string password;
        private string clasa;

        public Utilizator(int id, string email, string name, string password, string clasa)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
            this.clasa = clasa;
        }

        public Utilizator(string text)
        {

            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.password = prop[2];
            this.email = prop[3];
            this.clasa = prop[4];

        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getparola()
        {
            return password;
        }

        public string getemail()
        {
            return email;
        }

        public string getclasa()
        {
            return clasa;
        }

    }
}
