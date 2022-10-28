using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class Orchestra
    {
        private List<Musician> _musicians;
        private Conductor _theConductor;
        private string _orchestraName;
        private int _id;
        public Conductor TheConductor
        {
            get { return _theConductor; }
            set { _theConductor = value; }
        }

        public string OrchestraName
        {
            get { return _orchestraName; }
            set { _orchestraName = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Orchestra( Conductor theConductor, string orchestraName, int id)
        {
            _musicians = new List <Musician>();
            _theConductor = theConductor;
            _orchestraName = orchestraName;
            _id = id;
        }

        public void AddMusician(Musician aMusician)
        {
            _musicians.Add(aMusician);
        }

        public void AddConductor(Conductor aConductor)
        {
            _theConductor = aConductor;
        } 

        public void PrintAllMusicians()
        {
            foreach (Musician musician in _musicians)
            {
                Console.WriteLine(musician);
            }
        }
        public override string ToString()
        {
            return $"ID {_id} OrchestraName {_orchestraName} Conductor {_theConductor.Name} ";
        }

    }
}
