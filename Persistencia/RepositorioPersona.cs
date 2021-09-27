using System.Net.Sockets;
using System;
using Persistencia;
using Dominio;
using System.Collections.Generic;


namespace Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {

        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext){
            _appContext = appContext;
        }

        public Persona addPersona(Persona persona){
            
            var new_persona = _appContext.personas.Add(persona);
            _appContext.SaveChanges();
            return new_persona.persona;


        }  

        
    }
}