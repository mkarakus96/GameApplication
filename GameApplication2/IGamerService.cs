using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    interface IGamerService
    {
        void Add(Gamers gamers);

        void Update(Gamers gamers);

        void Delete(Gamers gamers);
    }
}
