using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePractice
{
    class Student
    {

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string  State   { get; set; }

        public bool Active { get; set; }

        public DateTime HireDate { get; set; }


        public void SetHireDate(int Year, int Month, int Day)
        {

            if(Year <1950 || Year > 2200)
            {
                Console.WriteLine( $"Year must be between 1950 and 2200");
                return;
            }
            if(Month <1 || Month > 12)
            {
                Console.WriteLine("Look at a calendar");
                return;
            }
            if (Day <1 || Day > 31)
            {

                Console.WriteLine("Invalid Day");
                return;
            }

            HireDate = new DateTime(Year, Month, Day);

        }








        public  void print()
        {

            Console.WriteLine($" {Firstname}, {Lastname} Hired {HireDate.ToString("mm/dd/yyyy")}");
        }







    }
}
