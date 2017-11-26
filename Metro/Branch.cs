using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    public class Branch
    {
        private string _name;
        private string _color;
        private int _number;
        private string[] _stations;
        private int[] _timeStations;

        public Branch(string name, string color, int number, string[] stations)
        {
            Random random = new Random();
            _name = name;
            _color = color;
            _number = number;
            _stations = stations;
            _timeStations = new int[stations.Length];
            for (int i = 0; i < _timeStations.Length - 1; i++)
            {
                _timeStations[i] = random.Next(1, 7);
            }
        }
       
        public string GetName()
        {
            return _name;
        }
        public string GetColor()
        {
            return _color;
        }
        public int GetNumber()
        {
            return _number;
        }
        public string[] GetStations()
        {
            return _stations;
        }
        public int[] GetTimeStations()
        {
            return _timeStations;
        }

        public int CalculateTotalTime()
        {
            int _totalTime = 0;
            for (int i = 0; i < GetStations().Length; i++)
            {
                _totalTime = _totalTime + GetTimeStations()[i];
            }
            return _totalTime;
        }

        public int CalculateTripTime(string startStation, string endStation)
        {
            int tripTime = 0;

            bool isStartStationExist = false;
            bool isEndStationExist = false;
            int i = 0;
            int b = 0;
            for (; i < _stations.Length; i++)
            {
                if (startStation == _stations[i])
                {
                    isStartStationExist = true;
                    break;
                }
            }
            if (isStartStationExist != true)
            {
                return -1;
            }

            for (b = i; b < _stations.Length; b++)
            {
                if (endStation == _stations[b])
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
                tripTime = tripTime + GetTimeStations()[a];
            }
            return tripTime;
        }

    }

}
