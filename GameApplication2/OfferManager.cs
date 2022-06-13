using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    class OfferManager : IOffersService
    {
        public void AddOffer(Offers offers)
        {
            Console.WriteLine("Added New Offer :" + offers.OfferName);
        }

        public void DeleteOffer(Offers offers)
        {
            Console.WriteLine("Deleted Offer :" + offers.OfferName);
        }

        public void UpdateOffer(Offers offers)
        {
            Console.WriteLine("Updated Offer :" + offers.OfferName);
        }

    }
}
