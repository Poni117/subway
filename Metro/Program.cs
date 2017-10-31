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
            Branch branch = new Branch("Кировско-Выборгская", "красная", 1, new string[]
                {
                    "Девяткино",
                    "Гражданский проспект",
                    "Академическая",
                    "Политехническая",
                    "Площадь Мужества",
                    "Лесная",
                    "Выборгская",
                    "Площадь Ленина",
                    "Чернышевская",
                    "Площадь Восстания",
                    "Владимирская",
                    "Пушкинская",
                    "Технологический институт",
                    "Балтийская",
                    "Нарвская",
                    "Кировский завод",
                    "Автово",
                    "Ленинский проспект",
                    "Проспект Ветеранов"
                }
            );
            Console.WriteLine(branch.GetNumber() + branch.GetColor() + branch.GetName());
            for (int i = 0; i < branch.GetStations().Length; i++)
            {
                Console.WriteLine(branch.GetStations()[i]);
            }
        }
    }
}
