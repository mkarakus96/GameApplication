using System;
using System.Collections.Generic;
using System.Text;

namespace GameApplication2
{
    class Gamers:IEntity
    {
        public int Id { get; set; }

        public int YearOfBirth { get; set; }

        public long NationalityId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
