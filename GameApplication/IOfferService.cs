using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication
{
    interface IOfferService
    {
        void AddOffer(Offers offers);

        void DeleteOffer(Offers offers);

        void UpdateOffer(Offers offers);

        int appOffer(Offers offers);
    }
}
