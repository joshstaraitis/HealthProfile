using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTest
{
    class MainTest
    {
        static void Main(string[] args)
        {

            // Create instance of HealthPrpfile object
            HealthProfile healthprofile = new HealthProfile();
            Console.WriteLine("Hello, please enter your information so we can calculate your max and target heart rates!");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            // Prompt user to enter information and store in object
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            healthprofile.SetFirstName(firstName);

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            healthprofile.SetLastName(lastName);

            Console.WriteLine("Enter The Year You Were Born: ");
            int dob = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetDoB(dob);

            Console.WriteLine("Enter Your Height In Inches: ");
            int height = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetHeight(height);

            Console.WriteLine("Enter Your Weight In Pounds: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetWeight(weight);

            Console.WriteLine("Enter Your Gender: ");
            string gender = Console.ReadLine();
            healthprofile.SetGender(gender);

            Console.WriteLine("Enter The Current Year: ");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetYear(currentYear);


            // Calculate HeartRate / BPM
            int beatsperMin = 220;
            int Age = (currentYear - dob);
            int MaxHeartRate = beatsperMin - Age;
            double HeartMultiplier50 = 0.5;
            double HeartMultiplier75 = 0.75;
            double TargetHeartRateLow = Convert.ToDouble(HeartMultiplier50 * MaxHeartRate);
            double TargetHeartRateHigh = Convert.ToDouble(HeartMultiplier75 * MaxHeartRate);

            // Calculate BMI
            int BMI = (weight * 703) / (height * height);
            // Statement to calculate BMI Value
            string BMIValue;
            if (BMI <= 18.5)
            {
                BMIValue = "underweight";
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                BMIValue = "normal";
            }
            else if (BMI > 25 && BMI < 29.9)
                {
                BMIValue = "overweight";
            }
            else
            {
                BMIValue = "obese";
            }

            Console.WriteLine(
                "\nYou Entered\n"
                + "Name: " + firstName + " " + lastName + "\n"
                + "Birth Year: " + dob + "\n"
                + "Current Year: " + currentYear + "\n"
                + "You Are Currently: " + Age + " Years Old" + "\n"
                + "Your MAX Heart Rate Is: " + MaxHeartRate + "\n"
                + "Your Target Heart Rate Is Between: " + TargetHeartRateLow + " and " + TargetHeartRateHigh + "\n"
                + "Your BMI Is: " + BMI +"\n"
                + "Due to your BMI of: " + BMI + " ,you are considered to be " + BMIValue + "\n"
             ); 

            Console.ReadLine();
        }
    }
}
