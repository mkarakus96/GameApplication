using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    class ValidationManager : IValidationService
    {
        public bool Validation(Gamers gamers)
        {
            if (gamers.FirstName == "MUHAMMED" && gamers.LastName == "KARAKUS" && gamers.NationalityId == 12345 && gamers.YearOfBirth == 1996)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
