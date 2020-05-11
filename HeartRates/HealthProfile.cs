using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTest
{
    class HealthProfile
    {

        public string firstName;
        public string lastName;
        public int DoB;
        public int currentYear;
        public int height;
        public int weight;
        public string gender;

        // Following methods set information in HealthProfile object

        public void SetFirstName(string FirstName)
        {
            firstName = FirstName;
        }

        public void SetLastName(string LastName)
        {
            lastName = LastName;
        }

        public void SetDoB(int DateofBirth)
        {
            DoB = DateofBirth;
        }

        public void SetYear(int CurrentYear)
        {
            currentYear = CurrentYear;
        }

        public void SetHeight(int Height)
        {
            height = Height;
        }

        public void SetWeight(int Weight)
        {
            weight = Weight;
        }

        public void SetGender(string Gender)
        {
            gender = Gender;
        }

        // following methods retrieves the information from the object
        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public int GetDoB()
        {
            return DoB;
        }

        public int GetYear()
        {
            return currentYear;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetWeight()
        {
            return weight;
        }

        public string GetGender()
        {
            return gender;
        }
    }
}
