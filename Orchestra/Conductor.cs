using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class Conductor
    {

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _titel;

		public string Titel
		{
			get { return _titel; }
			set { _titel = value; }
		}

		public Conductor(string name, string titel)
		{
			_name = name;
			_titel = titel;
		}

		public override string ToString()
		{
			return $"Titel {_titel} Name {_name}";
		}

	}
}
