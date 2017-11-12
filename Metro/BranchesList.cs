using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    public class BranchesList
    {
        private Branch _branch1;
        private Branch _branch2;
        private Branch _branch3;
        private Branch _branch4;
        private Branch _branch5;

        public BranchesList()
        {
            _branch1 = new Branch("Кировско-Выборгская ", "Красный", 1, new string[]
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

            _branch2 = new Branch("Московско-Петроградская", "синий", 2, new string[]
            {
                "Парнас",
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
             });

            _branch3 = new Branch("Невско-Василеостровская", "Зеленый", 3, new string[]
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

            _branch4 = new Branch("Правобережная", "Оранжевый", 4, new string[]
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

            _branch5 = new Branch("Фрунзенско-Приморская", "Фиолетовый", 5, new string[]
            {
                "Комендантский проспект",
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
                "Международная",
            });
        }

        private void InputBranches(Branch branch)
        {

            Console.WriteLine("Введите станцию отправки. ");
            string startStation = Console.ReadLine();

            Console.WriteLine("Введите станцию остановки. ");
            string endStation = Console.ReadLine();

            int timeWay = 0;
            
            
            for (int i = 0; i < branch.GetStations().Length; i++)
            {
                string[] arrayNames = branch.GetStations();
                if (startStation == arrayNames[i])
                {
                    for (int b = 0; b < arrayNames.Length; b++)
                    {
                        if (endStation == arrayNames[b])
                        {
                            for (int a = i; endStation != arrayNames[a] && a < branch.GetStations().Length; a++)
                            {
                                timeWay = timeWay + branch.GetTimeStations();
                            }
                            Console.WriteLine("Время пути состовляет - " + timeWay + " мин");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("нет одной или несколько станции в этой ветке. ЧИТАЙ СПИСОК ВНИМАТЕЛЬНЕЕ!!!");
        }

        public void GetBranchInfo(Branch branch)
        {
            int _totalTime = 0;
            Console.WriteLine("Назавние направления - " + branch.GetNameBranch());
            Console.WriteLine("Цвет линни - " + branch.GetColor());
            Console.WriteLine("Номер линии - " + branch.GetNumberBranch());
            Console.WriteLine("Список станций - ");
            for (int i = 0; i < branch.GetStations().Length; i++)
            {
                Console.WriteLine(branch.GetStations()[i]);
                _totalTime = _totalTime + branch.GetTimeStations();
            }
            Console.WriteLine("Время всего пути - " + _totalTime + " мин");
        }



        public Branch FindBranch(string userAnswer)
        {
            switch (userAnswer)
            {
                case "Кировско-Выборгская":
                case "Красный":
                case "1":
                {
                    return _branch1;
                }

                case "Московско-Петроградская":
                case "Синий":
                case "2":

                {
                    return _branch2;
                }

                case "Невско-Василеостровская":
                case "Зеленый":
                case "3":
                {
                    return _branch3;
                }

                case "Правобережное":
                case "Оранжевый":
                case "4":
                {
                    return _branch3;
                }

                case "Фрунзенско-Приморская":
                case "Фиолетовый":
                case "5":
                {
                    return _branch3;
                }
            }

            return null;
        }
    }
}


   

