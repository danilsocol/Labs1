using System;

namespace Labs1
{
    class Labs1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Привет {name},теперь тебе понадобиться ввести сегодняшнюю дату,для начала введи год ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("теперь номер месяца");
            int month = Convert.ToInt32(Console.ReadLine());
            if (month <= 0 & month > 12)
            {
                Console.Write("Такого месяца не существует ");
                return;
            }

            Console.WriteLine("число");
            int day = Convert.ToInt32(Console.ReadLine());
            if (month == 1 & month == 3 & month == 5 & month == 7 & month == 8 & month == 10 & month == 12)
            {
                if (day <= 0 & day > 31)
                {
                    Console.Write("В данном месяце такого дня нет ");
                    return;
                }

            }
            if (month == 4 & month == 6 & month == 9 & month == 11)
            {
                if (day <= 0 & day > 31)
                {
                    Console.Write("В данном месяце такого дня нет ");
                    return;
                }

            }
            if (month == 2)
            {
                if (year % 4 == 0)
                    if (day <= 0 & day > 29)
                    {
                        Console.Write("В данном месяце такого дня нет ");
                        return;
                    }

                    else
                    {
                        if (day <= 0 & day > 28)
                        {
                            Console.Write("В данном месяце такого дня нет ");
                            return;
                        }

                    }
            }
            Console.WriteLine($"Отлично {name},теперь введи год своего рождения ");
            int year1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("номер месяца");
            int month1 = Convert.ToInt32(Console.ReadLine());
            if (month1 <= 0 & month1 > 12)
            {
                Console.Write("Такого месяца не существует ");
                return;
            }
            Console.WriteLine("число");
            int day1 = Convert.ToInt32(Console.ReadLine());
            if (month1 == 1 & month1 == 3 & month1 == 5 & month1 == 7 & month1 == 8 & month1 == 10 & month1 == 12)
            {
                if (day1 <= 0 & day1 > 31)
                {
                    Console.Write("В данном месяце такого дня нет ");
                    return;
                }

            }
            if (month1 == 4 & month1 == 6 & month1 == 9 & month1 == 11)
            {
                if (day1 <= 0 & day1 > 31)
                {
                    Console.Write("В данном месяце такого дня нет ");
                    return;
                }

            }
            if (month1 == 2)
            {
                if (year1 % 4 == 0)
                    if (day1 <= 0 & day1 > 29)
                    {
                        Console.Write("В данном месяце такого дня нет ");
                        return;
                    }

                    else
                    {
                        if (day1 <= 0 & day1 > 28)
                        {
                            Console.Write("В данном месяце такого дня нет ");
                            return;
                        }

                    }
            }
            int age;
            if (month == month1)
            {
                if (day >= day1)
                {
                    age = year - year1;
                }
                else { age = year - year1 - 1; }
            }
            else
            {
                if (month > month1)
                {
                    age = year - year1;
                }
                else
                {
                    age = year - year1 - 1;
                }
            }
            Console.WriteLine($"{name} ваш возраст составляет {age}  ");

            Console.ReadKey();

        }
    }
}
