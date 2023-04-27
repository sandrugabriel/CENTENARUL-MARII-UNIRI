using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENTENARUL_MARII_UNIRI.Models
{
    internal class Item
    {

        private int id;
        private int tipItem;
        private string enunt;
        private string raspunsItem1;
        private List<string> varItem2 = new List<string>();
        private int raspunsItem2;
        private List<string> varItem3 = new List<string>();
        private int raspunsItem3;
        private int raspunsItem4;

        public Item(int id, int tipItem, string enunt, string raspunsItem1)
        {
            this.id = id;
            this.tipItem = tipItem;
            this.enunt = enunt;
            this.raspunsItem1 = raspunsItem1;
        }

        public Item(int id, int tipItem, string enunt, List<string> varItem2, int raspunsItem2)
        {
            this.id = id;
            this.tipItem = tipItem;
            this.enunt = enunt;
            this.varItem2 = varItem2;
            this.raspunsItem2 = raspunsItem2;
        }

        public Item(int id, int tipItem, string enunt, int raspunsItem4)
        {
            this.id = id;
            this.tipItem = tipItem;
            this.enunt = enunt;
            this.raspunsItem4 = raspunsItem4;
        }

        public Item(string textul)
        {

            string[] prop = textul.Split(';');

            this.id = int.Parse(prop[0]);
            this.tipItem = int.Parse(prop[1]);
            this.enunt = prop[2];

            int dim = prop.Length - 1;
            if (tipItem == 1)
            {
                this.raspunsItem1 = prop[3];
            }
            if (tipItem == 2)
            {

                for (int i = 3; i < dim; i++)
                {
                    this.varItem2.Add(prop[i]);
                }

                this.raspunsItem2 = int.Parse(prop[dim]);
            }
            if (tipItem == 3)
            {

                for (int i = 3; i < dim; i++)
                {
                    this.varItem3.Add(prop[i]);
                }

                this.raspunsItem3 = int.Parse(prop[dim]);
            }

            if (tipItem == 4)
            {
                this.raspunsItem4 = int.Parse(prop[3]);
            }

        }

        public int getid()
        {
            return this.id;
        }

        public int gettipitem()
        {
            return this.tipItem;
        }

        public string getenunt()
        {
            return this.enunt;
        }

        public string getraspunsitem1()
        {
            return this.raspunsItem1;
        }

        public List<string> getvalitem2()
        {
            return this.varItem2;
        }

        public int getraspunsitem2()
        {
            return this.raspunsItem2;
        }

        public List<string> getvalitem3()
        {
            return this.varItem3;
        }

        public int getraspunsitem3()
        {
            return this.raspunsItem3;
        }

        public int getraspunsitem4()
        {
            return this.raspunsItem4;
        }
    }
}
