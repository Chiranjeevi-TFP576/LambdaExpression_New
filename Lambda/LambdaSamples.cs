using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class LambdaSamples
    {
        public static void AddRecords(List<PersonInformation> listPersonInCity)
        {
            listPersonInCity.Add(new PersonInformation("203456876", "John", "12 Main Street,Newyork,NY", 15));
            listPersonInCity.Add(new PersonInformation("203456878", "SAM", "13 Main Street,Newyork,NY", 17));
            listPersonInCity.Add(new PersonInformation("203456879", "Elan", "14 Main Street,Newyork,NY", 35));
            listPersonInCity.Add(new PersonInformation("203456312", "Smith", "12 Main Street,Newyork,NY", 45));
            listPersonInCity.Add(new PersonInformation("203456529", "SAM", "345 Main Ave,Dayton,OH", 55));
            listPersonInCity.Add(new PersonInformation("203456980", "Sue", "32 Cranbrook Rd,Newyork,NY", 65));
            listPersonInCity.Add(new PersonInformation("203456882", "Winston", "1208 Alex st,Newyork,NY", 65));
            listPersonInCity.Add(new PersonInformation("203456922", "Mac", "126 Provinc Ave,Baltimore,NY", 85));
            listPersonInCity.Add(new PersonInformation("203456822", "SAM", "126 Province Ave dayton,Baltimore,NY", 95));

        }
        public static void Retrieving_TopTwoRecord_ForAges_LessThanSixty(List<PersonInformation> listPersonInCity)
        {
            foreach (PersonInformation person in listPersonInCity.FindAll(e => e.Age < 60).Take(2))
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
        }
        public static void CheckingForTeenagerperson(List<PersonInformation> listPersonInCity)
        {
            foreach (PersonInformation person in listPersonInCity.FindAll(e => e.Age >= 13 && e.Age <= 19))
            {
                Console.WriteLine("Name :" + person.Name + "\t\tAge: " + person.Age);
            }
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Yes, We Found some Teen.agers in the list");
            }
            else
                Console.WriteLine("No, We Don't have any Teen.agers in the list");
        }
        public static void AllpersonsAverageAge(List<PersonInformation> listPersonInCity)
        {
            double average = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is :" + average);
        }
        public static void CheckNameExitOrNot(List<PersonInformation> listPersonInCity)
        {
            if (listPersonInCity.Exists(e => e.Name == "SAM"))
            {
                Console.WriteLine("Yes, A Person having name \"SAM\" exists in our list");
            }
        }
        public static void Skip_Record_ForAges_LessThanSixty(List<PersonInformation> listPersonInCity)
        {
            foreach (PersonInformation person in listPersonInCity.SkipWhile(e => (e.Age < 60)))//findAll also we can use here
            {
                Console.WriteLine("Name :" + person.Name + "\t\tAge :" + person.Age);
            }

        }
        public static void Remove_Specific_Name_From_List(List<PersonInformation> listPersonInCity)
        {
            var searchName = listPersonInCity.Find(e => e.Name == "SAM");
            if (searchName != null)
            {
                listPersonInCity.Remove(searchName);
            }
            //listPersonInCity.RemoveAll(e => e.Name == "SAM");
            foreach (PersonInformation person in listPersonInCity)
            {
                Console.WriteLine("Name :" + person.Name + "\t\tAge :" + person.Age);
            }

        }
    }
}
