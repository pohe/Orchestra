using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class Musician
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _experience;

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public Musician(string name, string address, int experience)
        {
            _name = name;
            _address = address;
            _experience = experience;
        }

        public double Salary()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return $"Name {_name} Address {_address} Experence {_experience}";
        }



    }
}
