using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    interface IGamesService
    {
        void AddGame(Games games);

        void DeleteGame(Games games);
    }
}
