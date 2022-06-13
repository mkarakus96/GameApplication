using System;

namespace GameApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamersManager gamersManager = new GamersManager(new ValidationManager());
            gamersManager.Add(new Gamers
            {
                FirstName = "MUHAMMED",
                LastName = "KARAKUS",
                NationalityId = 12345,
                YearOfBirth = 1996
            });

            SalesManager salesManager = new SalesManager();
            salesManager.SalesWithOffer(new Games { GameName = "LOL" }, new Gamers { FirstName = "Muhammed" }, new Offers { OfferName = "Cuma" });

        }
    }
}
