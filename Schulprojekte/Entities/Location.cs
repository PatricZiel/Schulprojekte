using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Entities
{
    internal class Location
    {
        string zip;
        string name;

        public Location()
        {

        }

        public Location(string zip, string name)
        {
            setZip(zip);
            setName(name);
        }

        public void setZip(string zip)
        {
            this.zip = zip;
        }

        public string getZip()
        {
            return this.zip;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
