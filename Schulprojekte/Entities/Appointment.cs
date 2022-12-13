using Org.BouncyCastle.Bcpg;
using Schulprojekte.EntitieHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Entities
{
    internal class Appointment
    {
        int id;
        string description;
        DateTime time;
        Contact contact;

        public Appointment()
        {

        }

        public Appointment(int id, string description, DateTime time, int contactId)
        {
            setId(id);
            setDescription(description);
            setTime(time);
            setContactById(contactId);
        }

        /* Foreign key handling */
        private void setContactById(int id)
        {
            setContact(EHContact.getContactById(id));
        }

        /* Getter und Sette */
        public int getId() { return id; }
        private void setId(int id) { this.id = id; }
        public string getDescription() { return description; }
        private void setDescription(string description) { this.description = description; }
        public DateTime getTime() { return time; }
        private void setTime(DateTime time) { this.time = time; }
        public Contact getContact() { return contact; }
        public void setContact(Contact contact) { this.contact = contact; }
    }
}
