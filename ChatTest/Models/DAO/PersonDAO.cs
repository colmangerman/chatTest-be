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

        public Message getResponse()
        {
            this.initialize();
            var msg = new Message();

            var person = this.getPersonResponse();

            if(person != null)
            {
                msg.Body = person.Response();
                msg.Creator = person.Type.ToString();
            }
            else
            {
                msg.Body = "Por favor aguarde en linea..";
                msg.Creator = "Bot";
            }

            return msg;
        }

        private Person getPersonResponse()
        {
            var freeOperator = this.people.FirstOrDefault(x => x.State == StateEnum.Libre && x.Type == TypeEnum.Operador);
            if (freeOperator != null)
                return freeOperator;

            var freeSupervisor = this.people.FirstOrDefault(x => x.State == StateEnum.Libre && x.Type == TypeEnum.Supervisor);
            if (freeSupervisor != null)
                return freeSupervisor;

            var freeGerente = this.people.FirstOrDefault(x => x.State == StateEnum.Libre && x.Type == TypeEnum.Gerente);
            if (freeGerente != null)
                return freeGerente;

            return null;

        }

    }

}