using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    class SalesManager : ISalesService
    {

        public void SalesWithOffer(Games games, Gamers gamers, Offers offer)
        {
            Console.WriteLine(games.GameName + " " + "oyunu"+" "+gamers.FirstName +" "+"tarafından"+offer.OfferName+" "+"kampanyasıyla"+" "+"satın alındı");
        }
    }
}
