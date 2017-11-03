using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    public
    class BranchesList
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

        Branch branch2 = new Branch("Московско-Петроградская", "синий", 2, new string[]
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

        Branch branch3 = new Branch("Невско-Василеостровская", "Зеленый", 3, new string[]
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

        Branch branch4 = new Branch("Правобережная", "Оранжевый", 4, new string[]
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

        Branch branch5 = new Branch("Фрунзенско-Приморская", "Фиолетовый", 5, new string[]
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

        int totalTime = 0;

        public void ShowBranchInfo(string userAnswer)
        {
            switch (userAnswer)
            {

                case "Кировско-Выборгская":
                case "Красный":
                case "1":
                {
                        Console.WriteLine("Назавние направления - " + branch1.GetNameBranch());
                        Console.WriteLine("Цвет линни - " + branch1.GetColor());
                        Console.WriteLine("Номер линии - " + branch1.GetNumberBranch());
                        Console.WriteLine("Список станций - ");
                        for (int i = 0; i < branch1.GetStations().Length; i++)
                        {
                           Console.WriteLine(branch1.GetStations()[i]);
                           totalTime = totalTime + branch1.GetTimeStations();
                        }
                        Console.WriteLine("Время всего пути - " + totalTime + " мин");

                        Console.WriteLine("Введите станцию отправки. ");
                        string startStation = Console.ReadLine();

                        Console.WriteLine("Введите станцию остановки. ");
                        string endStation = Console.ReadLine();

                        int timeWay = 0;

                        for (int i = 0; i <branch1.GetStations().Length;  i++)
                        {
                            string[] arrayNames = branch1.GetStations();
                            if (startStation == arrayNames[i])
                            {
                                for(int a = i; endStation != arrayNames[a]; a++)
                                {
                                    timeWay = timeWay + branch1.GetTimeStations();
                                }
                                Console.WriteLine("Время пути состовляет - " + timeWay + " мин");
                            }
                        }

                       

                        break;
                }

                case "Московско-Петроградская":
                case "Синий":
                case "2":

                {
                        Console.WriteLine("Назавние направления - " + branch2.GetNameBranch());
                        Console.WriteLine("Цвет линни - " + branch2.GetColor());
                        Console.WriteLine("Номер линии - " + branch2.GetNumberBranch());
                        Console.WriteLine("Список станций - ");
                        for (int i = 0; i < branch2.GetStations().Length; i++)
                        {
                            Console.WriteLine(branch2.GetStations()[i]);
                            totalTime = totalTime + branch2.GetTimeStations();
                        }
                        Console.WriteLine("Время пути - " + totalTime + " мин");

                        Console.WriteLine("Введите станцию отправки. ");
                        string startStation = Console.ReadLine();

                        Console.WriteLine("Введите станцию остановки. ");
                        string endStation = Console.ReadLine();

                        int timeWay = 0;

                        for (int i = 0; i < branch2.GetStations().Length; i++)
                        {
                            string[] arrayNames = branch2.GetStations();
                            if (startStation == arrayNames[i])
                            {
                                for (int a = i; endStation != arrayNames[a]; a++)
                                {
                                    timeWay = timeWay + branch2.GetTimeStations();
                                }
                                Console.WriteLine("Время пути состовляет - " + timeWay + " мин");
                            }
                        }
                        break;
                }

                case "Невско-Василеостровская":
                case "Зеленый":
                case "3":
                {
                        Console.WriteLine("Назавние направления - " + branch3.GetNameBranch());
                        Console.WriteLine("Цвет линни - " + branch3.GetColor());
                        Console.WriteLine("Номер линии - " + branch3.GetNumberBranch());
                        Console.WriteLine("Список станций - ");
                        for (int i = 0; i < branch3.GetStations().Length; i++)
                        {
                            Console.WriteLine(branch3.GetStations()[i]);
                            totalTime = totalTime + branch3.GetTimeStations();
                        }

                        Console.WriteLine("Время пути - " + totalTime + " мин");

                        Console.WriteLine("Введите станцию отправки. ");
                        string startStation = Console.ReadLine();

                        Console.WriteLine("Введите станцию остановки. ");
                        string endStation = Console.ReadLine();

                        int timeWay = 0;

                        for (int i = 0; i < branch3.GetStations().Length; i++)
                        {
                            string[] arrayNames = branch3.GetStations();
                            if (startStation == arrayNames[i])
                            {
                                for (int a = i; endStation != arrayNames[a]; a++)
                                {
                                    timeWay = timeWay + branch3.GetTimeStations();
                                }
                                Console.WriteLine("Время пути состовляет - " + timeWay + " мин");
                            }
                        }
                        break;

                    }

                case "Правобережное":
                case "Оранжевый":
                case "4":
                {
                    Console.WriteLine("Назавние направления - " + branch4.GetNameBranch());
                    Console.WriteLine("Цвет линни - " + branch4.GetColor());
                    Console.WriteLine("Номер линии - " + branch4.GetNumberBranch());
                    Console.WriteLine("Список станций - ");
                    for (int i = 0; i < branch4.GetStations().Length; i++)
                    {
                        Console.WriteLine(branch4.GetStations()[i]);
                        totalTime = totalTime + branch4.GetTimeStations();
                    }
                        Console.WriteLine("Время пути - " + totalTime + " мин");

                        Console.WriteLine("Введите станцию отправки. ");
                        string startStation = Console.ReadLine();

                        Console.WriteLine("Введите станцию остановки. ");
                        string endStation = Console.ReadLine();

                        int timeWay = 0;

                        for (int i = 0; i < branch4.GetStations().Length; i++)
                        {
                            string[] arrayNames = branch4.GetStations();
                            if (startStation == arrayNames[i])
                            {
                                for (int a = i; endStation != arrayNames[a]; a++)
                                {
                                    timeWay = timeWay + branch4.GetTimeStations();
                                }
                                Console.WriteLine("Время пути состовляет - " + timeWay + " мин");
                            }
                        }
                        break;
                }

                case "Фрунзенско-Приморская":
                case "Фиолетовый":
                case "5":
                {
                        Console.WriteLine("Назавние направления - " + branch5.GetNameBranch());
                        Console.WriteLine("Цвет линни - " + branch5.GetColor());
                        Console.WriteLine("Номер линии - " + branch5.GetNumberBranch());
                        Console.WriteLine("Список станций - ");
                        for (int i = 0; i < branch5.GetStations().Length; i++)
                        {
                            Console.WriteLine(branch5.GetStations()[i]);
                            totalTime = totalTime + branch5.GetTimeStations();
                        }
                        Console.WriteLine("Время пути - " + totalTime + " мин");

                        Console.WriteLine("Введите станцию отправки. ");
                        string startStation = Console.ReadLine();

                        Console.WriteLine("Введите станцию остановки. ");
                        string endStation = Console.ReadLine();

                        int timeWay = 0;

                        for (int i = 0; i < branch5.GetStations().Length; i++)
                        {
                            string[] arrayNames = branch5.GetStations();
                            if (startStation == arrayNames[i])
                            {
                                for (int a = i; endStation != arrayNames[a]; a++)
                                {
                                    timeWay = timeWay + branch5.GetTimeStations();
                                }
                                Console.WriteLine("Время пути состовляет - " + timeWay + " мин");
                            }
                        }
                        break;
                    }
            }
        }
    }
}


   

