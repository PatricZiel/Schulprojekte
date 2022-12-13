using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Entities
{
    internal class Company
    {
        int id;
        string name;

        public Company()
        {

        }

        public Company(int id, string name)
        {
            setId(id);
            setName(name);
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
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
