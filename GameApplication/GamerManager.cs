using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if(_validationService.Validation(gamer)==true)
            {
                Console.WriteLine("Gamer Added : "+ gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Validation Error : " + gamer.FirstName);
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated : " + gamer.FirstName);
        }
    }
}
