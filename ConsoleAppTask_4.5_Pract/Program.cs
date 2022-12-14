using System;

namespace ConsoleAppTask_4._5_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Surname, String Login, int Loginlength, bool Pet, double Age, string[] Color) User;

            for (int numuser = 0; numuser < 3; numuser++)
            {
                Console.Write("Введите ваше имя: ");
                User.Name = Console.ReadLine();
                Console.Write("Введите вашу фамилию: ");
                User.Surname = Console.ReadLine();
                Console.Write("Введите ваш логин: ");
                User.Login = Console.ReadLine();
                User.Loginlength = User.Login.Length;
                Console.Write("У вас есть питомец да/нет?: ");
                if (Console.ReadLine().ToUpper() == "да".ToUpper())
                    User.Pet = true;
                else
                    User.Pet = false;
                Console.Write("Введите ваш возраст: ");
                User.Age = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите 3 ваших люимых цвета: ");
                User.Color = new string[3] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };

                Console.WriteLine("Ваше имя: " + User.Name);
                Console.WriteLine("Ваша фамилия: " + User.Surname);
                Console.WriteLine("Ваше логин: " + User.Login);
                Console.WriteLine("Длина вашего логина: " + User.Loginlength);
                if (User.Pet == true)
                    Console.WriteLine("У вас есть питомец");
                else
                    Console.WriteLine("У вас нет питомца");
                Console.WriteLine("Ваш возраст: " + User.Age);
                int numcolor = 1;
                foreach (var color in User.Color)
                {
                    Console.WriteLine("Ваш любимый цвет №{0}: {1} ", numcolor, color);
                    numcolor++;
                }
            }
        }
    }
}
