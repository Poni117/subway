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
            Branch branch1 = new Branch("Кировско-Выборгская ", "Красный", 1, new string[]
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
                });

            Console.WriteLine("Направление: - " + branch1.GetNameBranch());   
            Console.WriteLine("Номер линии: - " + branch1.GetNumberBranch());
            Console.WriteLine("Цвет: - " + branch1.GetColor());
            for (int a = 0; a < branch1.GetStations().Length; a++)
            {
               Console.WriteLine ("Список станций - " + branch1.GetStations()[a]);
            }
            Console.WriteLine();

            Branch branch2 = new Branch("Московско-Петроградская", "синий", 2, new string[]
            {
                    
                    "Проспект Просвещения",
                    "Озерки",
                    "Удельная",
                    "Пионерская",
                    "Чёрная речка",
                    "Петроградская",
                    "Горьковская",
                    "Невский проспект",
                    "Сенная площадь",
                    "Технологический институт",
                    "Фрунзенская",
                    "Московские ворота",
                    "Электросила",
                    "Парк Победы",
                    "Московская",
                    "Звёздная",
                    "Купчино",
                    "Невско-Василеостровская ветка метро",
                    "Приморская",
                    "Василеостровская",
                    "Гостиный двор",
                    "Маяковская",
                    "Площадь Александра Невского",
                    "Елизаровская",
                    "Ломоносовская",
                    "Пролетарская",
                    "Обухово",
                    "Рыбацкое"
            });

            Console.WriteLine("Направление: - " + branch2.GetNameBranch());
            Console.WriteLine("Номер линии: - " + branch2.GetNumberBranch());
            Console.WriteLine("Цвет: - " + branch2.GetColor());
            for (int b = 0; b < branch2.GetStations().Length; b++)
            {
                Console.WriteLine("Список станций - " + branch2.GetStations()[b]);
            }
            Console.WriteLine();

            Branch branch3 = new Branch("Кировско-Выборгская ", "Зеленый", 3, new string[]
                {
                    "Приморская",
                    "Василеостровская",
                    "Гостиный двор",
                    "Маяковская",
                    "Площадь Александра Невского",
                    "Елизаровская",
                    "Ломоносовская",
                    "Пролетарская",
                    "Обухово",
                    "Рыбацкое",
                });

            Console.WriteLine("Направление: - " + branch3.GetNameBranch());
            Console.WriteLine("Номер линии: - " + branch3.GetNumberBranch());
            Console.WriteLine("Цвет: - " + branch3.GetColor());
            for (int с = 0; с < branch3.GetStations().Length; с++)
            {
                Console.WriteLine("Список станций - " + branch3.GetStations()[с]);
            }
            Console.WriteLine();


            Branch branch4 = new Branch("Правобережное ", "Оранжевый", 4, new string[]
               {
                    "Спасская",
                    "Достоевская",
                    "Лиговский проспект",
                    "Площадь Александра Невского",
                    "Новочеркасская",
                    "Ладожская",
                    "Проспект Большевиков",
                    "Улица Дыбенко",
               });

            Console.WriteLine("Направление: - " + branch4.GetNameBranch());
            Console.WriteLine("Номер линии: - " + branch4.GetNumberBranch());
            Console.WriteLine("Цвет: - " + branch4.GetColor());
            for (int d = 0; d < branch4.GetStations().Length; d++)
            {
                Console.WriteLine("Список станций: - " + branch4.GetStations()[d]);
            }
            Console.WriteLine();


            Branch branch5 = new Branch("Фрунзенско-Приморская ", "Фиолетовый", 5, new string[]
               {
                    "Комендантский проспектя",
                    "Старая Деревня",
                    "Крестовский остров",
                    "Чкаловская",
                    "Спортивная",
                    "Адмиралтейская",
                    "Садовая",
                    "Звенигородская",
                    "Обводный канал",
                    "Волковская",
                    "Бухарестская",
                    "Международная"
               });

            Console.WriteLine("Направление - " + branch5.GetNameBranch());
            Console.WriteLine("Номер линии - " + branch5.GetNumberBranch());
            Console.WriteLine("Цвет - " + branch5.GetColor());
            for (int e = 0; e < branch5.GetStations().Length; e++)
            {
                Console.WriteLine("Список станций - " + branch5.GetStations()[e]);
            }
        }
    }
}
