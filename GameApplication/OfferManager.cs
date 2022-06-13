using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication
{
    class OfferManager : IOfferService
    {
        public void AddOffer(Offers offers)
        {
            Console.WriteLine("New Offer Added");
        }

        public int appOffer(Offers offers)
        {
            return 5;
        }

        public void DeleteOffer(Offers offers)
        {
            Console.WriteLine("Offer is Deleted");
        }

        public void UpdateOffer(Offers offers)
        {
            Console.WriteLine("Offer is Updated");
        }
    }
}
