using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotel.Models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes  = new List<Pessoa>();

       
        public int DiasReservados { get; set;}

        public Suite Suite { get; set; }

        public Reserva(){
        }

        public Reserva( int diasReservados){
          
            this.DiasReservados = diasReservados;
            
            this.Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(String nome,String sobreNome){

            if(Suite== null){
                throw new Exception("Não há suíte cadastrada");
            }
            else{
                if (this.Suite.Capacidade > Hospedes.Count)
            {
            this.Hospedes.Add(new Pessoa(nome, sobreNome));
            }
                else
                {
                throw new Exception("Suite não possui mais vagas")
    ;           }
;           
            }

           
        }

        public void listarHospedes(){
            foreach (Pessoa pessoa in Hospedes)
            {
                Console.WriteLine(pessoa);
            }}


        public int ObterQuantidadeHospedes(){
            return this.Hospedes.Count;
        
        }

        public decimal calcularValorDiaria(){

            // desconto de 10%
           if(DiasReservados > 10){
              decimal valorDiaria =  Suite.ValorDiaria * (decimal)0.9;
              return valorDiaria * Hospedes.Count;
           }
           else{
            return Suite.ValorDiaria * Hospedes.Count;
           }
        }

        public decimal calcularValorTotal(){
            if(DiasReservados > 10){
                decimal valorDiaria = Suite.ValorDiaria * (decimal)0.9;
                return valorDiaria * Hospedes.Count * DiasReservados;

            }

            return Suite.ValorDiaria * Hospedes.Count * DiasReservados;


         
        }
          

        

        public void CadastrarSuite(String tipoSuite, decimal valorDiaria, int capacidade){
            this.Suite = new Suite(tipoSuite,capacidade,valorDiaria);
        }
        


    }

}