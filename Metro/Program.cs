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

            branchesList.GetBranchInfo(branch);


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
    }
}
