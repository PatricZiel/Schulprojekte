using Schulprojekte.EntitieHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Entities
{
    internal class Contact
    {
        int id;
        string firstName;
        string surName;
        string street;
        string departement;
        int tel;
        int mobile;
        Salutation salutation;
        Location location;
        Company company;
        ContactType contactType;

        public Contact()
        {

        }

        public Contact(int id, string firstName, string surName, 
            string street, string departement, int tel, int mobile, 
            int salutaionNo, string zip, int compNo, int type_no)
        {
            this.id = id;
            setFirstName(firstName);
            setSurName(surName);
            setStreet(street);
            setDepartement(departement);
            setTel(tel);
            setMobile(mobile);
            setSalutationByNo(salutaionNo);
            setLocationByZip(zip);
            setCompanyByNo(compNo);
            setContactTypeByNo(type_no);
        }

        /* foreign key handeling */
        private void setSalutationByNo(int salutationNo)
        {
            setSalutation(EHSalutation.getSalutationById(salutationNo));
        }

        private void setLocationByZip(string zip)
        {
            setLocation(EHLocation.getLocaionByZip(zip));
        }

        private void setCompanyByNo(int compNo)
        {
            setCompany(EHCompany.getCompanyById(compNo));
        }

        private void setContactTypeByNo(int typeNo)
        {
            setContactType(EHContactType.getContactTypeById(typeNo));
        }

        /* Getter und Setter */
        public int getId()
        {
            return this.id;
        }

        private void setId(int id)
        {
            this.id = id;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getSurName()
        {
            return this.surName;
        }

        public void setSurName(string surName)
        {
            this.surName = surName;
        }

        public string getStreet()
        {
            return this.street;
        }

        public void setStreet(string street)
        {
            this.street = street;
        }

        public string getDepartement()
        {
            return this.departement;
        }

        public void setDepartement(string departement)
        {
            this.departement = departement;
        }

        public int getTel()
        {
            return this.tel;
        }

        public void setTel(int tel)
        {
            this.tel = tel;
        }

        public int getMobile()
        {
            return this.mobile;
        }

        public void setMobile(int mobile)
        {
            this.mobile = mobile;
        }

        public Salutation getSalutation()
        {
            return this.salutation;
        }

        public void setSalutation(Salutation salutation)
        {
            this.salutation = salutation;
        }

        public Location getLocation()
        {
            return this.location;
        }

        public void setLocation(Location location)
        {
            this.location = location;
        }

        public Company getCompany()
        {
            return this.company;
        }

        public void setCompany(Company company)
        {
            this.company = company;
        }

        public ContactType getContactType()
        {
            return this.contactType;
        }

        public void setContactType(ContactType contactType)
        {
            this.contactType = contactType;
        }
    }
}
