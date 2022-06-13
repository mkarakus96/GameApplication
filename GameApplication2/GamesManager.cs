using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    class GamesManager : IGamesService
    {
        public void AddGame(Games games)
        {
            Console.WriteLine("Added new game : "+games.GameName);
        }

        public void DeleteGame(Games games)
        {
            Console.WriteLine("Deleted new game : " + games.GameName);
        }
    }
}
