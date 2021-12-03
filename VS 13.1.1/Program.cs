using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_13._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Москва, Ворошилова 11", 25.58, 4.45, 6.88);
            building.Print();
            MultiBuilding multiBuilding = new MultiBuilding("Москва, Ворошилова 15", 45.12, 8.42, 9.5, 3);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        private double length;
        private double width;
        private double height;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }

                else
                {
                    Console.WriteLine("Значение не может быть отрицательным или ровняться нулю");
                }
            }
        }
        public double Width

        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }

                else
                {
                    Console.WriteLine("Значение не может быть отрицательным или равняться нулю");
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }

                else
                {
                    Console.WriteLine("Значение не может быть отрицательным или равняться нулю");
                }
            }
        }

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес: {0},\nдлина здания: {1:f2} м, ширина здания: {2:f2} м, высота здания: {3:f2} м", Address, Length, Width, Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        private double floor;
        public double Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > 0)
                {
                    floor = value;
                }

                else
                {
                    Console.WriteLine("Значение не может быть отрицательным или равняться нулю");
                }
            }
        }

        public MultiBuilding(string address, double length, double width, double height, double floor)
            : base(address, length, width, height)
        {
            Floor = floor;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("этажей {0}", Floor);
        }

    }
}


