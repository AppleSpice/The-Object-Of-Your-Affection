using System;

namespace The_Object_Of_Your_Affection
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", 2, "Golden Retriever", "he/him");

            sam.SetHobbies(new string[] {"Writing", "Reading", "texting" });

            sam.SetDogNames(new string[] { "Jerry", "Bobby", "Harold", "Gilbert" });

            Console.WriteLine(sam.VeiwProfile());

        }
    }
}
