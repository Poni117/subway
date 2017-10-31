using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    class BlueBranch
    {
        private int[] _stationsTime;
        private string[] _stationsName;

        public BlueBranch()
        {
            _stationsTime = new int[18];
            for (int i = 0; i < 18; i++)
            {
                _stationsTime[i] = 1; 
            }

            _stationsName = new string[]
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
                "Купчино"
            };

        }

        public void ShowAllStationsNames()
        {
            for (int i = 0; i < 18; i++)
            {
                string a = _stationsName[i];
                Console.WriteLine(a);
            }
        }

        public void ShowFullTime()
        {
            int a = 0;
            for(int i = 0; i < 18; i++)
            {
                a = a + _stationsTime[i];
            }
            Console.WriteLine(a);
        }

        
        public void ShowTime(string startStationName, string endStationName)
        {
            int result = 0;
            for (int i = 0; i < _stationsName.Length; i++) 
            {
                if (startStationName == _stationsName[i])
                {
                    for (int a = i; endStationName != _stationsName[a]; a++)
                    {
                        result = result + 1;
                    }
                }
            }
            Console.WriteLine(result);
        }

    }
}
