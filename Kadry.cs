using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_practicum
{
    /// <summary>
    /// ПЕРЕДЕЛАТЬ
    /// </summary>
    class Kadry
    {
        private string fam;
        private int age;
        private string dol;
        private int staj;
        public string Fam { get => fam; set => fam = value; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16)
                {
                    age = 16;
                }
                else if (value > 60)
                {
                    age = 60;
                }
                else
                {
                    age = value;
                }
            }
        }
        public int Staj
        {
            get { return staj; }
            set
            {
                if (value == 0)
                {
                    staj = 0;
                }
                else if (value > 60)
                {
                    age = 60;
                }
                else
                {
                    age = value;
                }
            }
        }


        public string Dol { get => dol; set => dol = value; }


    }
}
