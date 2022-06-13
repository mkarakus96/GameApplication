using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication
{
    class Gamer:IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int NationalityId { get; set; }

        public int DateOfBirthYear { get; set; }
    }
}
