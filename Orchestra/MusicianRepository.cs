using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class MusicianRepository : IMusicianRepository
    {
        private List<Musician> _musicians;
        public int Count
        {
            get { return _musicians.Count; }
        }

        public void AddMusician(Musician aMusician)
        {
            _musicians.Add(aMusician);
        }

        public void DeleteMusician(Musician aMusician)
        {
            _musicians.Remove(aMusician);
        }

        public void PrintAllMusicians()
        {
            foreach (Musician musician in _musicians)
            {
                Console.WriteLine(musician);
            }
        }

        public void SearchMusician(string name, string address)
        {
            foreach (Musician musician in _musicians)
            {
                if (musician.Name == name && musician.Address == address)
                {
                    Console.WriteLine($"Musikeren med navnet {name} og adressen {address} findes");
                }
            }
        }
    }
}
