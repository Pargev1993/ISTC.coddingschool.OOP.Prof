using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISTC.Codingschool.OOP.Homework
{
    class Program
    {
        public static List<string> GetPhonesText(string Path)
        {
            Phones phones = new Phones();
            List<string> PhoneModel = new List<string>();

            List<string> PhoneText = File.ReadLines(Path).ToList();
            foreach (var Phones in PhoneText)
            {

                PhoneModel.Add(Phones);

            }
            foreach (var item in PhoneModel)
            {
                var s = item.Split('|');
                phones.Brend = s[0];
                phones.Model = s[1];
                phones.PhoneId = Convert.ToInt32(s[2]);
            }

            return PhoneModel;
        }
        public static Person GetPersoneText(string Path)
        {
            Person person = new Person();
            string PersonText = File.ReadAllText(Path);
            string[] words = PersonText.Split('|');
            person.PersonId = Convert.ToInt32(words[0]);
            person.FirstName = words[1];
            person.LastName = words[2];
            person.Age = Convert.ToInt32(words[3]);
            person.Gender = words[4];
            return person;

        }
        static void Main(string[] args)
        {

            string PersonPath = @"C:\Users\pqoal\Downloads\people.txt";
            var AboutPerson = GetPersoneText(PersonPath);

            string PhonePath = @"C: \Users\pqoal\Downloads\Phone.txt";
            var AboutPhon = GetPhonesText(PhonePath);

        }
    }
}
