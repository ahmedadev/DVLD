using System;

using System.Data;
using Database;
namespace Business
{
   public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public bool Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }



        public clsPerson()

        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = false;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsPerson(int PersonID, string FirstName, string SecondName,
     string ThirdName, string LastName, DateTime DateOfBirth, bool Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;

        }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPeopleData.AddNewPerson( this.FirstName, this.SecondName,
     this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID,  this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPeopleData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        public static clsPerson Find(int PersonID)
        {

            string FirstName = "", SecondName = "", ThirdName = "",  LastName = "", Address = "" ,Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            bool Gendor = false;

            if (clsPeopleData.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName,
    ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))

                return new clsPerson(PersonID, FirstName, SecondName,
     ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }




            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();

        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleData.DeletePerson(PersonID);
        }

        public static bool isPersonExist(int PersonID)
        {
            return clsPeopleData.IsPersonExist(PersonID);
        }

    }
}
