using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_02_Struct
{
    class Program
    {
        struct User
        {
            public string name;
            public int age;

            public User(string name, int age)  // Определение конструктора в структуре
            {
                this.name = name;
                this.age = age;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {name},  Age: {age}");
            }
        }
        static void Main(string[] args)
        {
            User user;

            Console.WriteLine("Enter your name:");
            user.name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            user.age = int.Parse(Console.ReadLine());

            user.Display();

            User tom = new User();  // При использовании конструктора по умолчанию не надо явным образом инициализировать поля структуры.
            tom.Display();

            User bob = new User("Bob", 33);  //  При определении конструктора в структуре необходимо инициализировать все поля
            bob.Display();


            User person = new User { name = "Sam", age = 31 };   // Использование инициализатора для создания структуры
            person.Display();

            Console.ReadKey();
        }
    }
}
