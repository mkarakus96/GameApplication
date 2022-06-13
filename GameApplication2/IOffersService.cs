using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    interface IOffersService
    {
        void AddOffer(Offers offers);

        void UpdateOffer(Offers offers);

        void DeleteOffer(Offers offers);
    }
}
