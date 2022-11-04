using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class CertifiedConductor: Conductor
    {
		private string _certification;

		public string Certification
		{
			get { return _certification; }
			set { _certification = value; }
		}

		private int _level;

		public int Level
		{
			get { return _level; }
			set { _level = value; }
		}


		public CertifiedConductor(string name, string titel, string certification, int level):base(name, titel)
		{
			_certification = certification;
			_level = level;
		}

	}
}
