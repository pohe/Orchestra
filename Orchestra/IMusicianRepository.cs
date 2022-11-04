using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Orchestra
{
    public interface IMusicianRepository
    {
        public int Count { get; }
        void AddMusician(Musician aMusician);
        void DeleteMusician(Musician aMusician);
        void SearchMusician(string name, string address);
        void PrintAllMusicians();
    }
}
