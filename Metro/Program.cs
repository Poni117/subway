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

            branchesList.ShowBranchInfo(Console.ReadLine());    
        }
    }
}
