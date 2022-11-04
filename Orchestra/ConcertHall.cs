using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Orchestra
{
    public class ConcertHall
    {
		private string _address;

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		private int _numberSpectators;

		public int NumberSpectators
		{
			get { return _numberSpectators; ; }
			set { _numberSpectators = value; }
		}

		public ConcertHall(string address, int numberSpectators)
		{
			
			_address = address;
			_numberSpectators = numberSpectators;
		}

		public override string ToString()
		{
            return $"Address {_address}  NumberOfSpectators {_numberSpectators}";
        }
    }
}
