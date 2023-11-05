using ProjetoHotel.Models;

Reserva reserva = new Reserva();

while (true)
        {

            Console.WriteLine("=========================");
            Console.WriteLine("1 -> Criar Uma Reserva".ToUpper());
            Console.WriteLine("2 -> Criar uma suite".ToUpper());
            Console.WriteLine("3 -> Cadastrar Hospedes".ToUpper());
            Console.WriteLine("4 -> Quantidade de  Hospedes Cadrastrado".ToUpper());
            Console.WriteLine("5 -> Listar Hospedes".ToUpper());
            Console.WriteLine("6 -> valor a pagar da diaria dos hospesde".ToUpper());
            Console.WriteLine("7 -> Valor total a pagar da reserva".ToUpper());
            Console.WriteLine("0 -> Encerrar".ToUpper());
            Console.WriteLine("=========================");
            Console.Write("Digite a sua opção: ".ToUpper());
            int x = short.Parse(Console.ReadLine());

            if (x.Equals(0))
            {
                break;
            }

            else if (x.Equals(1))
            {   
                Console.WriteLine("Criando uma Reserva");
                Console.WriteLine("=========================");
                Console.WriteLine("Digite quantidade dias pra ser reservados: ".ToUpper());
                int dias = int.Parse(Console.ReadLine());
                reserva.DiasReservados = dias;
               

            }
            else if (x.Equals(2)){
                Console.WriteLine("Criando uma Suite");
                Console.WriteLine("=========================");
                Console.WriteLine("Digite o tipo da suite: ".ToUpper());
                string tipoSuite = Console.ReadLine();
                Console.WriteLine("Digite o valor da suite: ".ToUpper());
                decimal valorSuite = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite Capacidade da suite: ".ToUpper());
                int capacidade = int.Parse(Console.ReadLine());
                reserva.CadastrarSuite(tipoSuite, valorSuite, capacidade);
                Console.WriteLine("=========================");
                Console.WriteLine("Suite Cadastrada com sucesso");
            }
          

            else if(x.Equals(3)){
                Console.WriteLine("Cadastrando um Hospede");
                Console.WriteLine("=========================");
                Console.WriteLine("Digite o nome do hospede: ".ToUpper());
                string nome = Console.ReadLine();
              
          
                Console.WriteLine("Digite o sobrenome do hospede: ".ToUpper());
                string sobrenome = Console.ReadLine();

                reserva.CadastrarHospedes(nome,sobrenome);

                Console.WriteLine("=========================");
                Console.WriteLine("Hospede Cadastrado com sucesso");
                Console.WriteLine("=========================");
                

                
                }

                else if(x.Equals(4)){
                    Console.WriteLine("Quantidade de Hospedes Cadastrados");
                    Console.WriteLine("=========================");
                    Console.WriteLine(reserva.ObterQuantidadeHospedes());
                    Console.WriteLine("=========================");
                    
             
                }
                else if(x.Equals(5)){
                    Console.WriteLine("Listando os Hospedes");
                    Console.WriteLine("=========================");
                    reserva.listarHospedes();
                    Console.WriteLine("=========================");
                    
                }

                else if(x.Equals(6)){
                    Console.WriteLine("Valor total  a Pagar da diaria dos hospesde ");
                    Console.WriteLine("=========================");
                    Console.WriteLine(reserva.calcularValorDiaria());
                    Console.WriteLine("=========================");
                    
                
                }

                else if(x.Equals(7)){
                    Console.WriteLine("Valor total a pagar da reserva");
                    Console.WriteLine("=========================");
                    Console.WriteLine(reserva.calcularValorTotal());
                    Console.WriteLine("=========================");
                    
                
                

                }



           
            
            }



        















