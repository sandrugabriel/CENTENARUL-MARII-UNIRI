using CENTENARUL_MARII_UNIRI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENTENARUL_MARII_UNIRI.Controllers
{
    internal class ControllerEvaluari
    {

        private List<Evaluare> evaluari;


        public ControllerEvaluari() { 
        
        evaluari = new List<Evaluare>();

            load();
        
        }

        public void load()
        {

            string patrh = Application.StartupPath + @"/data/evaluari.txt";
            StreamReader streamReader = new StreamReader(patrh);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {

                Evaluare a = new Evaluare(text);

                evaluari.Add(a);


            }

            streamReader.Close();
        }

        public List<Evaluare> getEvaluariById(int id)
        {
            List<Evaluare> list = new List<Evaluare>();

            for(int i = 0; i < evaluari.Count; i++)
            {
                if (evaluari[i].getId_elev() == id)
                {
                    list.Add(evaluari[i]);
                }
            }
            
            return list;
        }

        public int getmediaClasa(List<int> list )
        {
            int suma = 0;
            int nr = 0;

            for(int i=0;i< list.Count; i++)
            {
                for(int j=0;j<evaluari.Count;j++)
                {
                    if (evaluari[j].getId_elev() == list[i])
                    {
                        suma += evaluari[i].getNota();
                        nr++;
                    }
                }
            }

            return suma / nr;
        }

        public List<int> getNoteById(int id)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < evaluari.Count; i++)
            {
                if (evaluari[i].getId_elev() == id)
                {
                    list.Add(evaluari[i].getNota());
                }
            }

            return list;
        }


    }
}
