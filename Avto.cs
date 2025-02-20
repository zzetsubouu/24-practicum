using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_practicum
{
    class Avto
    {
        private string model;
        private string color;
        private int skor;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value=="")
                    model = "ПУСТОЕ ЗНАЧЕНИЕ MODEL";
                else
                {
                    model = value;
                }
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
                if (value=="")
                    color = "ПУСТОЕ ЗНАЧЕНИЕ COLOR";
                else
                {
                    color = value;
                }
            }
        }

        //public string Color
        //{
        //    get
        //    {
        //        return color;
        //    }
        //    set
        //    {
        //        if (String.IsNullOrEmpty(value))
        //            color = "ПУСТОЕ ЗНАЧЕНИЕ COLOR";
        //        else
        //        {
        //            color = value;
        //        }
        //    }
        //}
        public int Skor
        {
            get
            {
                return skor;
            }
            set
            {
                if (value < 60)
                {
                    skor = 60;
                }
                else if (value > 150)
                {
                    skor = 150;
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
        public Avto(string model, string color, int skor)
        {
            this.model = model;
            this.color = color;
            this.skor = skor;
        }
        public override string ToString()
        {
            return $"модель: {model}, цвет: {color}, скорость: {skor}";
        }
    }
}
