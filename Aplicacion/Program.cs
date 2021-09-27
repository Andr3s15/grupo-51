using System.Security.Permissions;
using System.IO.Pipes;
using System;
using Dominio;
namespace Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona nueva_persona = new Persona();
            nueva_persona.Nombre = "Andrés"
            nueva_persona.Edad = "17"
            nueva_persona.Peso = "54"
        }
    }
}
