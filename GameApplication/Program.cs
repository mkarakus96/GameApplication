using System;

namespace GameApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewValidation());
            gamerManager.Add(new Gamer { FirstName = "MUHAMMED", LastName = "KARAKUS", DateOfBirthYear = 1996, NationalityId = 12345 });
        }
    }
}
