using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENTENARUL_MARII_UNIRI.Models
{
    internal class Evaluare
    {

        private int id_evaluare;
        private int id_elev;
        private DateTime date;
        private int nota;



        public Evaluare(int id_evaluare, int id_elev, DateTime date, int nota)
        {
            this.id_evaluare = id_evaluare;
            this.id_elev = id_elev;
            this.date = date;
            this.nota = nota;
        }

        public Evaluare(string text)
        {

            string[] prop = text.Split(';');

            this.id_evaluare = int.Parse(prop[0]);
            this.id_elev = int.Parse(prop[1]);
            this.date = DateTime.Parse(prop[2]);
            this.nota = int.Parse(prop[3]);

        }

        public int getId_evaluare()
        {
            return id_evaluare;
        }

        public int getId_elev()
        {
            return id_elev;
        }

        public DateTime getDate()
        {
            return date;
        }

        public int getNota()
        {
            return nota;
        }
    }
}
