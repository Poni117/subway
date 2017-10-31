using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    class Branch
    {
        private string _name;
        private string _color;
        private int _number;
        private string[] _stations;

        public Branch(string name, string color, int number, string[] stations)
        {
            _name = name;
            _color = color;
            _number = number;
            _stations = stations;
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
    }

    
}
