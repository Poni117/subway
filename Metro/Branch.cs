using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    class Branch
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

       

    }
}
