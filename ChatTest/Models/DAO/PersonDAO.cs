using ChatTest.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatTest.Models.DAO
{
    public class PersonDAO
    {
        private List<Person> people;
        private Array stateValues = Enum.GetValues(typeof(StateEnum));
        private Array typeValues = Enum.GetValues(typeof(TypeEnum));
        private Random random = new Random();

        public PersonDAO()
        {
            this.initialize();

        }

        private void addPerson()
        {
            var person = new Person();
            person.State = (StateEnum)this.stateValues.GetValue(random.Next(stateValues.Length));
            person.Type = (TypeEnum)this.typeValues.GetValue(random.Next(stateValues.Length));

            this.people.Add(person);

        }

        private void initialize()
        {
            this.people = new List<Person>();
            this.addPerson();
            this.addPerson();
            this.addPerson();
            this.addPerson();
            this.addPerson();
            this.addPerson();

        }

        public Person getFreePersonByType(TypeEnum type)
        {
            return this.people.FirstOrDefault(x => x.State == StateEnum.Libre && x.Type == type);
        }

    }

}