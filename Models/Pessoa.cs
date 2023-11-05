using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotel.Models
{
    public class Pessoa
    {
        private String Nome{get;set;}
        private String Sobrenome{get;set;}


        public Pessoa(string nome, string sobrenome){
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

         public override string ToString()
    {
        return $"{Nome} {Sobrenome}";
    }


      
    
    }
}