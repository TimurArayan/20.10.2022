using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace qweqwe
{

    abstract class Food
    {
        private string name;
        public void Getname(string name)
        {
            this.name = name;
        }
    }
    class Bread : Food
    {
        private byte tasty;
        public byte Tasty
        {
            get { return tasty; }
            set { tasty = value; }
        }
        private byte temperature = 20;
        public byte Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public byte pieces;
        public void Cut()
        {
            Console.WriteLine("На сколько частей порезать хлеб?");
            pieces = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Хлеб разрезан на {pieces} частей.");
        }
        public void DoMoreTasty()
        {
            if (tasty < 5)
            {
                Console.Write($"Вкусность: {tasty} → ");
                tasty += 1;
                price += 10;
                Console.WriteLine((tasty) + ". Это будет стоить 10 рублей. цена - " + price);
            }
            else
            {
                Console.WriteLine("Максимальное значение вкусности уже достигнуто");
            }

        }
        public void DoHeatter()
        {
            if (temperature < 71)
            {
                Console.Write($"Теспература изменена с {temperature} на ");
                temperature += 10;
                Console.WriteLine(temperature);
            }
            else
            {
                Console.WriteLine("Больше уже нельзя");
            }

        }
        public void Buy()
        {
            Console.WriteLine($"Вы купили хлеб с характеристиками: вкусность - {tasty}, свежесть - {temperature}, разреный на {pieces} частей(части) за {price} рублей.");
        }
        public Bread()
        {
            Console.WriteLine($"Вы заказали хлеб, его характеристики: вкусность - {tasty}, свежесть - {temperature}, цена - {price}");
            Console.WriteLine("Выберете, что хотите с ним сделать");
            string s = "";
            while (s.Equals("4") == false)
            {
                Console.WriteLine("Сделать вкуснее(10 руб.) - 1 / нагреть(бесплатно) - 2/ разрезать(бесплатно) - 3/ купить - 4");
                s = Console.ReadLine();
                if (s.Equals("1"))
                {
                    DoMoreTasty();
                }
                if (s.Equals("2"))
                {
                    DoHeatter();
                }
                if (s.Equals("3"))
                {
                    Cut();
                }

            }
            Console.Clear();
            Buy();
        }
    }
    class Cake : Food
    {
        private byte tasty;
        public byte Tasty
        {
            get { return tasty; }
            set { tasty = value; }
        }
        private int temperature = 20;
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        private int price = 120;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public byte pieces;
        public void Cut()
        {
            Console.WriteLine("На сколько частей порезать торт?");
            pieces = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Торт разрезан на {pieces} частей.");
        }
        public void DoMoreTasty()
        {

            if (tasty < 5)
            {
                Console.Write($"Вкусность: {tasty} → ");
                tasty += 1;
                price += 10;
                Console.WriteLine((tasty) + ". Это будет стоить 10 рублей. цена - " + price);
            }
            else
            {
                Console.WriteLine("Максимальное значение вкусности уже достигнуто");
            }

        }
        public void DoColder()
        {
            if (temperature > -10)
            {
                Console.Write($"Теспература изменена с {temperature} на ");
                temperature -= 10;
                Console.WriteLine(temperature);
            }
            else
            {
                Console.WriteLine("Ниже уже нельзя");
            }

        }
        public void Buy()
        {
            Console.WriteLine($"Вы купили торт с характеристиками: вкусность - {tasty}, темпераутура - {temperature}, разреный на {pieces} частей(части) за {price} рублей.");
        }
        public Cake()
        {
            Console.WriteLine($"Вы заказали торт, его характеристики: вкусность - {tasty}, температура - {temperature}, цена - {price}");
            Console.WriteLine("Выберете, что хотите с ним сделать");
            string s = "";
            while (s.Equals("4") == false)
            {
                Console.WriteLine("Сделать вкуснее(10 руб.) - 1 / охладить(бесплатно) - 2/ разрезать(бесплатно) - 3/ купить - 4");
                s = Console.ReadLine();
                if (s.Equals("1"))
                {
                    DoMoreTasty();
                }
                if (s.Equals("2"))
                {
                    DoColder();
                }
                if (s.Equals("3"))
                {
                    Cut();
                }

            }
            Console.Clear();
            Buy();

        }

    }
    abstract class Drinks
    {
        private string name;
        public void Getname(string name)
        {
            this.name = name;
        }
    }
    class Tea : Drinks
    {
        private byte sugar;
        public byte Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }
        private byte temperature = 50;
        public byte Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        private int price = 10;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public void PutSugar()
        {
            sugar += 1;
            price += 5;
            Console.WriteLine($"Вы добаили кубик сахара за 5 рубрей, теперь их стало {sugar}, это вам обойется в {price} рублей");
        }
        public void DoHeatter()
        {
            if (temperature < 120)
            {
                Console.Write($"Теспература изменена с {temperature} на ");
                temperature += 10;
                Console.WriteLine(temperature);
            }
            else
            {
                Console.WriteLine("Больше уже нельзя, и так горячий.");
            }

        }
        private bool trava;
        public void PutTrava()
        {

            trava = true;
            price += 10;
            Console.WriteLine("Трава добавлена, цена: " + price);
        }

        public void Buy()
        {
            Console.WriteLine($"Вы купили чай с {sugar} кубиками сахара с тмпературой {temperature} градусов, с травой - {trava} , за {price} рублей.");
        }
        public Tea()
        {
            Console.WriteLine($"Вы заказали чай, его характеристики: кубиов сахара - {sugar}, тмпература - {temperature}, с травой - {trava}, цена - {price}");
            Console.WriteLine("Выберете, что хотите с ним сделать");
            string s = "";
            while (s.Equals("4") == false)
            {
                Console.WriteLine("Добавить кубик сахара(5 руб.) - 1 / нагреть(бесплатно) - 2/ разрезать(бесплатно) - 3/ купить - 4");
                s = Console.ReadLine();
                if (s.Equals("1"))
                {
                    PutSugar();
                }
                if (s.Equals("2"))
                {
                    DoHeatter();
                }
                if (s.Equals("3"))
                {
                    PutTrava();
                }

            }
            Console.Clear();
            Buy();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("C:\\prices.txt");
            string[] s = f.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            Console.WriteLine("Что вы хотите купить?");
            string g = Console.ReadLine();
            if (g.Equals("Хлеб"))
            {
                Bread x = new Bread();
                x.Price = a;
            }
            else if (g.Equals("Торт"))
            {
                Cake y = new Cake();
                y.Price = b;
            }
            else if (g.Equals("Чай"))
            {
                Tea y = new Tea();
                y.Price = c;
            }

        }
    }
}
