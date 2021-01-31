using System;
namespace Hw_26_01_01
{
    class Program
    {

        static void Main()
        {


            //Дз.3 класс Rectangle 

            Console.Write("Фарход введите длину прямоугольника >>> ");
            string x = Console.ReadLine();
            double side1 = Int32.Parse(x);

            Console.Write("Фарход введите ширина  прямоугольника >>> ");
            string y = Console.ReadLine();
            double side2 = Int32.Parse(y);

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine("Площадь = {0}", rectangle.Area);
            Console.WriteLine("Периметр = {0}", rectangle.Perimeter);
            Console.ReadLine();


            // Дз3. класс Book Задания 3.

            var book = new Book(
                new Author("А.С.Пушкин"),

                new Title("Стр: 320"),

                new Content("Содержания: Юношу отправили служить в крепость захватили и он сбежал с девушкой"));


            Console.WriteLine("Книга:'Капитанская дочь' ");
            Console.WriteLine();
            book.Show();

            Console.ReadLine();

            // 1) Вводим имя животного 
            // 2) Вводим возраст
            // 3) Вводим цвет 


            Console.WriteLine(" Введите имя животного!  Введите возраст животного!   Введите цвет животного!");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            string color = Console.ReadLine();

            new Animal(name, age, color);

            Console.WriteLine(" Animal ");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"color: {color}");
            Console.ReadLine();




            //Дз.3.2 Класс Employee Задания 3 
            var employee = new Employee("Фарходжон", "Мухитдинов") { Position = Employee.Место.Братишка2, Опыт = 1 };
            Console.WriteLine($"Имя: {employee.Name}");
            Console.WriteLine($"Фамилия: {employee.Surname}");
            Console.WriteLine($"Зарплата: ${employee.GetЗарплата()}");
            Console.WriteLine($"Налог: ${employee.GetНалог()}");

            var conv = new Converter(0.080, 0.070, 7.22);
            Console.ReadLine();


            //Дз3.2 класс Convert Задания 2

            Console.WriteLine($"990 usd-tjk: {conv.UsdToTjk(990)}");
            Console.WriteLine($"990 tjk-usd: {conv.TjkToUsd(990)}");
            Console.WriteLine($"380 eur-tjk: {conv.EurToTjk(100)}");
            Console.WriteLine($"100 tjk-eur: {conv.TjkToEur(1380)}");
            Console.WriteLine($"10000 rub-tjk: {conv.RubToTjk(10000)}");
            Console.WriteLine($"1000 tjk=rub: {conv.TjkToRub(6664)}");



        }
    }



    //Дз.3 Задания 2
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public Rectangle() { }

        double AreaCalculator()
        {
            return side1 * side2;
        }

        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area { get { return this.AreaCalculator(); } }
        public double Perimeter { get { return this.PerimeterCalculator(); } }
    }


    //Дз 3. класс Book Задания 3
    class Book
    {
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }

        public Book(Author author, Title title, Content content)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public Book()
        {

        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Title.Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            Author.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Content.Show();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }

    class Title
    {
        private string data;
        public void Show()
        {
            Console.WriteLine($"\"{data}\"");
        }

        public Title(string data)
        {
            this.data = data;
        }
    }

    class Author
    {
        private string data;
        public void Show()
        {
            Console.WriteLine($"Автор: {data}");
        }

        public Author(string data)
        {
            this.data = data;
        }
    }

    class Content
    {
        private string data;
        public void Show()
        {
            Console.WriteLine(data);
        }

        public Content(string data)
        {
            this.data = data;
        }
    }







    class Animal
    {

        public string name { get; set; }
        public int age { get; set; }
        public string color { get; set; }
        public Animal(string name, int age, string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }
    }

    //Дз3.2 класс Employee Задания 3
    public class Employee
    {

        public enum Место
        {
            Братишка1 = 30,
            Братишка2 = 31,
            Братишка3 = 32,
            Шогирд1 = 33,
            Шогирд2 = 34,
            Шогирд3 = 35,
            Шеф1 = 36,
            Шеф2 = 37,
            Шеф = 38
        }



        private const double InitialЗарплата = 708.0;


        private const double Dengi = 5.0;


        private const double Налог = 13.0;

        private const double Pention = 1.0;

        public string Name { get; }
        public string Surname { get; }
        public Место Position { get; set; }

        //Было бы у нас такое в Тчк   
        public int Опыт { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        private double GetFullЗарплата()
        {
            return InitialЗарплата + (50.0 * (double)+
                   InitialЗарплата * (Опыт * Dengi) / 100);
        }

        public double GetЗарплата()
        {
            return GetFullЗарплата() - GetНалог();
        }

        public double GetНалог()
        {
            return GetFullЗарплата() * (Налог + Pention) / 100.0;
        }

    }

    //Дз3.2 Задания 2
    class Converter
    {
        public Converter()
        {

        }
        public Converter(double usd, double rub, double eur)
        {
            this.usd = usd;
            this.rub = rub;
            this.eur = eur;
        }
        public double usd { get; set; }
        public double rub { get; set; }
        public double eur { get; set; }

        public double TjkToUsd(double tjk)
        {
            return tjk / usd;
        }
        public double TjkToEur(double tjk)
        {
            return tjk / eur;
        }
        public double TjkToRub(double tjk)
        {
            return tjk / rub;
        }
        public double RubToTjk(double tjk)
        {
            return tjk * rub;
        }
        public double UsdToTjk(double tjk)
        {
            return tjk * usd;
        }
        public double EurToTjk(double tjk)
        {
            return tjk * eur;
        }

    }


}