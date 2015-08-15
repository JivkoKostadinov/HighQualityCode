using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming_Identifiers
{
    class _02
    {

        enum Gender
        {
            male,
            female
        };

        class Person
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public void makeNewPerson(int personId)
        {
            Person currentPerson = new Person();
            currentPerson.Age = personId;

            if (personId % 2 == 0)
            {
                currentPerson.Name = "Батката";
                currentPerson.Gender = Gender.male;
            }
            else
            {
                currentPerson.Name = "Мацето";
                currentPerson.Gender = Gender.female;
            }
        }
    }
}
