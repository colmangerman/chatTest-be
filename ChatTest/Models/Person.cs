using ChatTest.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatTest.Models
{
    public class Person
    {
        public TypeEnum Type { get; set; }
        public StateEnum State { get; set; }

        public string Response()
        {
            return String.Format("Hola, soy el {0} en que puedo ayudarle.", this.Type);

        }

    }

}