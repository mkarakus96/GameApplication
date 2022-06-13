using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    class GamersManager : IGamerService
    {
        IValidationService validationService;

        public GamersManager(IValidationService validationService)
        {
            this.validationService = validationService;
        }

        public void Add(Gamers gamers)
        {
            if (validationService.Validation(gamers) == true)
            {
                Console.WriteLine("Gamers Added : " + gamers.FirstName);
            }
            else
            {
                Console.WriteLine("Validation Error! : " + gamers.FirstName);
            }

        }

        public void Delete(Gamers gamers)
        {
            Console.WriteLine("Gamers Deleted : " + gamers.FirstName);
        }

        public void Update(Gamers gamers)
        {
            Console.WriteLine("Gamers Updated : " + gamers.FirstName);
        }
    }
}
