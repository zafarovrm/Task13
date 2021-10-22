using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул.Обручевых д5", 30, 15, 60);
            building.Print();
            MultiBuilding multibuilding = new MultiBuilding("ул.Обручевых д7", 40, 20, 80, 3);
            multibuilding.Print();
            multibuilding.Print2();
            Console.ReadKey();
        }
    }
}
class Building
{
    public string Adress { get; set; }
    double length, width, height;
    public double Length
    {
        set
        {
            if (value > 5)
            {
                length = value;
            }
            else
            {
                Console.WriteLine("Длина не может быть отрицательной и меньше 5 метров");
            }
        }
        get
        {
            return length;
        }
    }
    public double Width
    {
        set
        {
            if (value > 5)
            {
                width = value;
            }
            else
            {
                Console.WriteLine("Ширина не может быть отрицательной и меньше 5 метров");
            }
        }
        get
        {
            return width;
        }
    }
    public double Height
    {
        set
        {
            if (value > 3)
            {
                height = value;
            }
            else
            {
                Console.WriteLine("Высота не может быть отрицательной и меньше 3 метров");
            }
        }
        get
        {
            return height;
        }
    }  
    public Building(string adress, double length, double width, double height)
    {
        Adress = adress;
        Length = length;
        Width = width;
        Height = height;
    }
    public void Print()
    {
        Console.WriteLine("Адрес дома: {0}", Adress);
        Console.WriteLine("Длина дома: {0}", Length);
        Console.WriteLine("Ширина дома: {0}", Width);
        Console.WriteLine("Высота дома: {0} ", Height);
    }
}
sealed class MultiBuilding : Building
{
    double floor;
    public double Floor
    {
        set
        {
            if (value > 0)
            {
                floor = value;
            }
            else
            {
                Console.WriteLine("Количество этажей не может быть меньше 1");
            }
        }
        get
        {
            return floor;
        }
    }
    public MultiBuilding(string adress, double length, double width, double height, double floor)
        : base(adress, length, width, height)
    {
        Floor = floor;
    }
    public void Print2()
    {
        Console.WriteLine("Этажность дома: {0}", Floor);
    }
}
