using System;
using System.Collections.Generic;
using System.Text;

namespace The_Object_Of_Your_Affection
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private int dogsOwned;
        private string favoriteDog;
        private string[] hobbies;
        private string[] dogNames;

        public Profile(
            string name,
            int age,
            string city = "n/a",
            string country = "n/a",
            int dogsOwned = 0,
            string favoriteDog = "n/a",
            string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.dogsOwned = dogsOwned;
            this.favoriteDog = favoriteDog;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
            this.dogNames = new string[0];
        }

        public string VeiwProfile()
        {
            string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nDogs Owned: {dogsOwned}\nFavorite Dog: {favoriteDog}\nPronouns: {pronouns}\n";

            if(this.hobbies.Length > 0)
            {
                bio += "Hobbies:\n";
                foreach (string hobby in hobbies)
                {
                    bio += $"- {hobby}\n";
                }
            }
            
            if(this.dogNames.Length > 0)
            {
                bio += "Dog Names:\n";
                foreach (string name in dogNames)
                {
                    bio += $"- {name}\n";
                }
            }
            

            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

        public void SetDogNames(string[] dogNames)
        {
            this.dogNames = dogNames;
        }
    }
}
