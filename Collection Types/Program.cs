
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ConsoleApplication1
{
    
    
    public class Program
    {
        public class PhoneBookUser
        {
            public string Name { get; set; }
            public int PhoneNumber { get; set; }
            public int PersonNumber { get; set; }

            public PhoneBookUser(int personNum, string name, int phoneNumber)
            {
                PersonNumber = personNum;
                Name = name;
                PhoneNumber = phoneNumber;
                
            }
        }

        static void Main(string[] args)
        {
            PhoneBookUser dragan = new PhoneBookUser(1, "Dragan", 070555666);
            PhoneBookUser aleksandar = new PhoneBookUser(2, "Dragan", 078213455);
            PhoneBookUser michael = new PhoneBookUser(3, "Michael", 077432544);
            PhoneBookUser jordan = new PhoneBookUser(4, "Jordan", 075666477);
            PhoneBookUser elliot = new PhoneBookUser(5, "Elliot", 072333555);



            Dictionary<int, PhoneBookUser> phoneBook = new Dictionary<int, PhoneBookUser>();
            phoneBook.Add(dragan.PersonNumber, dragan);
            phoneBook.Add(aleksandar.PersonNumber, aleksandar);
            phoneBook.Add(michael.PersonNumber, michael);
            phoneBook.Add(jordan.PersonNumber, jordan);
            phoneBook.Add(elliot.PersonNumber, elliot);

            Console.WriteLine("Enter the name: ");
            string userInput = Console.ReadLine();
            string userInputSec = char.ToUpper(userInput[0]) + userInput.Substring(1);
            bool NoFoundName = false;

            foreach (KeyValuePair<int, PhoneBookUser> keyValue in phoneBook)
            {
                PhoneBookUser user = keyValue.Value;
                if (userInputSec == user.Name)
                {
                    Console.WriteLine($"Phone number of the User {user.Name} is: {user.PhoneNumber}");
                    NoFoundName = true;
                }

                if (!NoFoundName)
                {
                    Console.WriteLine("ERROR..Name like this is not found in the Dictionary");
                    Console.WriteLine("Try again");
                    //string userIput = Console.ReadLine();
                    //string userInputSec = char.ToUpper(userInput[0]) + userInput.Substring(1);
                    //bool NoFoundName = false;
                }
                else
                {
                    Console.WriteLine("Task is done!!");
                }
            }
            Console.ReadLine();
        }
    }
}
