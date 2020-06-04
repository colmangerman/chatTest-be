# ChatTest-be

Proyecto creado usando C# .NET, es el backend del proyecto de chatTest (https://github.com/chaba87/chatTest)

Proyecto listo para compilar, es un WebApi donde el controller de Message recibe una peticion y responde con uno de los mensajes seteados.

La decision de quien responde se toma en la clase PersonDAO, donde se crea un listado de personas posibles con puestos y estados aleatorios, cada vez que se recibe una peticion se reinicia este listado dando mayor aleatoriedad al sistema.
