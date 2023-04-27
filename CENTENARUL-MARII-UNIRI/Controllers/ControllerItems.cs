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
    internal class ControllerItems
    {

        private List<Item> items;


        public ControllerItems() { 
        
            items = new List<Item>();

            load();
        
        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/itemi.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {

                Item a = new Item(text);

                items.Add(a);
            }

            streamReader.Close();   
        }


        public List<Item> getItemi()
        {
            return items;
        }


    }
}
