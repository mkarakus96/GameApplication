using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication
{
    class ValidationManager : IValidationService
    {
        public bool Validation(Gamer gamer)
        {
            {
                if (gamer.FirstName == "MUHAMMED" && gamer.LastName == "KARAKUS" && gamer.DateOfBirthYear == 1996 && gamer.NationalityId == 12345)
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
}
