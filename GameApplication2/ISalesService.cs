using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    interface ISalesService
    {
        void SalesWithOffer(Games games, Gamers gamers, Offers offer);
    }
}
