using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotel.Models
{
    public class Suite
    {
        private string TipoSuite{get;set;}
        public int Capacidade{get;set;}
        public decimal ValorDiaria{get;set;}

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria){
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;
    }

    public override string ToString(){
        return $"Tipo de Suite: {TipoSuite}\nCapacidade: {Capacidade}\nValor da Diária: {ValorDiaria}";
    }
    
    }}
