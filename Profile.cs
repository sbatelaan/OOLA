using System;

namespace DatingProfile
{ 
    class Profile
    {
        //fields (attributes) of the Profile class
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;


            // Constructor to create a Profile object with basic information
        public Profile( string name, int age, string city, string country, string pronouns = "they/them")
        {

            // Assigning the values passed as arguments to the respective fields
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;

            // Initializing the 'hobbies' array with an empty array
            this.hobbies = new string[0];
        }

        //Method to view the profile information as a formatted string
        public string ViewProfile()
        {
            // creating a string to store the information
            string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}";

                //Adding the hobbies information to the profile
            bio += "\nHobbies:\n";
            foreach (string hobby in hobbies)
            {
                bio += $"- {hobby}\n";

            }

            // Returning the complete profile information as a formatted string
            return bio;
        }

            //Method to set the hobbies for the profile
        public void SetHobbies(string[] hobbies)
        {
            //Assigning the provided hgobbies array to the 'hobbies' field
            this.hobbies = hobbies;
        }
    }
}