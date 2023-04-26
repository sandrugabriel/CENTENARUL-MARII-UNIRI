using CENTENARUL_MARII_UNIRI.Models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENTENARUL_MARII_UNIRI.Controllers
{
    internal class ControllerUtilizatori
    {

        private List<Utilizator> utilizatorii;

        public ControllerUtilizatori()
        {

            utilizatorii = new List<Utilizator>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/utilizatorii.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {

                Utilizator a = new Utilizator(text);

                utilizatorii.Add(a);

            }


            streamReader.Close();
        }

        public bool verifAut(string email, string parola)
        {

            for (int i = 0; i < utilizatorii.Count; i++)
            {

                if (utilizatorii[i].getemail() == email && utilizatorii[i].getparola() == parola)
                {
                    return true;
                }
            }

            return false;

        }




    }
}
