using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BranchesList branchesList = new BranchesList();

            Console.WriteLine("Для получения иформации введите направление,цвет или номер ветки.");

            string userAnswer = Console.ReadLine();
            // TODO: Validate userAnswer

            Branch branch = branchesList.FindBranch(userAnswer);
            // TODO: Validate branch

            GetBranchInfo(branch, branchesList);
            InputBranches(branch, branchesList);
            /*
             * 1. запросить номер ветки
             * 2. сформировать инфо ветки - обращение к BranchesList
             * 2. вывести на экран инфо о ветке
             * 3. запросить начальную и конечную станции
             * 4. посчитать время пути - обращение к BranchesList
             * 5. вывести время пути
             * 
             * 
             */
        }

        public static void GetBranchInfo(Branch branch, BranchesList branchesList)
        {
            Console.WriteLine("Назавние направления - " + branch.GetNameBranch());
            Console.WriteLine("Цвет линни - " + branch.GetColor());
            Console.WriteLine("Номер линии - " + branch.GetNumberBranch());
            Console.WriteLine("Список станций - ");

            for(int i = 0; i < branch.GetStations().Length;i++)
            {
                Console.WriteLine("\t" + branch.GetStations()[i]);
            }
            Console.WriteLine("Время всего пути - " + branch.CalculateTotalTime() + " мин");
        }

        private static void InputBranches(Branch branch, BranchesList branchesList)
        {
            Console.WriteLine("Введите станцию отправки. ");
            string startStation = Console.ReadLine();

            Console.WriteLine("Введите станцию остановки. ");
            string endStation = Console.ReadLine();

            int tripTime = branch.CalculateTripTime(startStation, endStation);
            if (tripTime != -1)
            {
                Console.WriteLine("Время пути состовляет - " + tripTime + " мин");
            }
            else
            {
                Console.WriteLine("нет одной или несколько станции в этой ветке. ЧИТАЙ СПИСОК ВНИМАТЕЛЬНЕЕ!!!");
            }
        }

    }
}
