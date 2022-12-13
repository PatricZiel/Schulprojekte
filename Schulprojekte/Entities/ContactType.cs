using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Entities
{
    internal class ContactType
    {
        int id;
        string name;

        public ContactType()
        {

        }

        public ContactType(int id, string name)
        {
            setId(id);
            setName(name);
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getId()
        {
            return this.id;
        }

        private void setId(int id)
        {
            this.id = id;
        }
    }
}
