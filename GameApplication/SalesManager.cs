using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication
{
    class SalesManager : ISalesService
    {
        IOfferService _offerService;
        public SalesManager(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public void Sold(Games games)
        {
           // games.UnitPrice = (games.UnitPrice - _offerService.appOffer);
           // Console.WriteLine("Game :"+games.GameName +" " + "Gamer : "+gamer.FirstName + " " + "Gamer Unit Price : "+games.UnitPrice + " " +"Discount: " +offer.Discount + " " + "New Price : "+(games.UnitPrice-offer.Discount));
        }
    }
}
