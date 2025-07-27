
using System;

namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method
{
    //Factory Method
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Country { get; private set; }

        private User(string name, string email, string country)
        {
            Name = name;
            Email = email;
            Country = country;
        }

        public override string ToString()
        {
            return $"{{ \"name\": \"{Name}\", \"email\": \"{Email}\", \"country\": \"{Country}\" }}";
        }

        public static class Factory
        {
            public static User CreateWithDefaultEmail(string name, string country)
            {
                var email = $"{name.ToLower()}.{new Random().Next(1024)}@email.com";
                return new User(name, email, country);
            }

            public static User CreateWithDefaultCountry(string name, string email)
            {
                return new User(name, email, "El Salvador");
            }
        }
    }
}
