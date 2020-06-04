using ChatTest.Models;
using ChatTest.Models.DAO;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatTest.Services
{
    public class MessageService
    {
        PersonDAO personDAO = new PersonDAO();

        public Message getResponse()
        {
            var msg = new Message();

            var person = this.getPersonResponse();

            if (person != null)
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
            var freeOperator = personDAO.getFreePersonByType(Models.Helpers.TypeEnum.Operador);
            if (freeOperator != null)
                return freeOperator;

            var freeSupervisor = personDAO.getFreePersonByType(Models.Helpers.TypeEnum.Supervisor);
            if (freeSupervisor != null)
                return freeSupervisor;

            var freeGerente = personDAO.getFreePersonByType(Models.Helpers.TypeEnum.Gerente);
            if (freeGerente != null)
                return freeGerente;

            return null;

        }

    }

}