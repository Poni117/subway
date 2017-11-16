﻿using System;
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

        public Branch FindBranch(string stationIdentifier)
        {
            switch (stationIdentifier)
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

        public int CalculateTotalTime(Branch branch)
        {
            int _totalTime = 0;
            for (int i = 0; i < branch.GetStations().Length; i++)
            {
                _totalTime = _totalTime + branch.GetTimeStations();
            }
            return _totalTime;
        }

        public int CalculateTripTime(Branch branch, string startStation, string endStation)
        {
            int tripTime = 0;

            bool isStartStationExist = false;
            bool isEndStationExist = false;
            string[] arrayNames = branch.GetStations();
            int i = 0;
            int b = 0;
            for (; i < arrayNames.Length; i++)
            {
                if (startStation == arrayNames[i])
                {
                    isStartStationExist = true;
                    break;
                }
            }
            if (isStartStationExist != true )
            {
                return -1;
            }

            for (b = i; b < arrayNames.Length; b++)
            {
                if (endStation == arrayNames[b])
                {
                    isEndStationExist = true;
                    break;
                }
            }
            if (isEndStationExist != true)
            {
                return -1;
            }

            for (int a = i; a < b; a++)
            {
                tripTime = tripTime + branch.GetTimeStations();
            }
            return tripTime;
        }
    }
}


   

