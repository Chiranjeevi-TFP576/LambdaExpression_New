using System;

namespace Lambda
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression");

            List<PersonInformation> listPersonInCity = new List<PersonInformation>();
            LambdaSamples.AddRecords(listPersonInCity);
            //LambdaSample.Retrieving_TopTwoRecord_ForAges_LessThanSixty(listPersonInCity);
            LambdaSamples.CheckingForTeenagerperson(listPersonInCity);
            //LambdaSample.AllpersonsAverageAge(listPersonInCity);
            //LambdaSample.CheckNameExitOrNot(listPersonInCity);
            //LambdaSample.Skip_Record_ForAges_LessThanSixty(listPersonInCity);
            //LambdaSample.Remove_Specific_Name_From_List(listPersonInCity);
            Console.ReadLine();

        }
    }
}