using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    public class Branch
    {
        private string _nameBranch;
        private string _color;
        private int _numberBranch;
        private string[] _stations;
        private int _timeStation;

        public Branch(string name, string color, int number, string[] stations)
        {
            _nameBranch = name;
            _color = color;
            _numberBranch = number;
            _stations = stations;
            _timeStation = 1;
        }
       
        public string GetNameBranch()
        {
            return _nameBranch;
        }
        public string GetColor()
        {
            return _color;
        }
        public int GetNumberBranch()
        {
            return _numberBranch;
        }
        public string[] GetStations()
        {
            return _stations;
        }
        public int GetTimeStations()
        {
            return _timeStation;
        }

        public int CalculateTotalTime()
        {
            int _totalTime = 0;
            for (int i = 0; i < GetStations().Length; i++)
            {
                _totalTime = _totalTime + GetTimeStations();
            }
            return _totalTime;
        }

        public int CalculateTripTime(string startStation, string endStation)
        {
            int tripTime = 0;

            bool isStartStationExist = false;
            bool isEndStationExist = false;
            string[] arrayNames = GetStations();
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
            if (isStartStationExist != true)
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
                tripTime = tripTime + GetTimeStations();
            }
            return tripTime;
        }

    }

}
