using System;
using System.Linq;
using System.Collections.Generic;

//Есть список учеников школы с разбивкой по классам:
//Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
namespace Практика_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(s => s.Students).ToArray();
        }
    }
}
