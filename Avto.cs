using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_practicum
{
    class Avto
    {
        private string brand;
        private string color;
        private int skor;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Skor
        {
            get
            {
                return skor;
            }
            set
            {
                if (value < 20)
                {
                    skor = 20;
                }
                else if (value > 120)
                {
                    skor = 120;
                }
                else
                {
                    skor = value;
                }
            }
        }
        public Avto()
        {

        }
        public Avto(string brand, string color, int skor)
        {
            this.brand = brand;
            this.color = color;
            this.skor = skor;
        }
        public override string ToString()
        {
            return $"марка: {brand}, цвет: {color}, скорость: {skor}";
        }
    }
}
