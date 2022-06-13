using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication
{
    class NewValidation : IValidationService
    {
        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
