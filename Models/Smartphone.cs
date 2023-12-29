using System.Runtime.InteropServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
       public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
         public void NumeroSmartphone()
        {
            Console.WriteLine($"Numero desse dispositivo é {Numero}");
        }
         public void TrocarNumero()
        {
            bool condicao = true;

            while(condicao ==true){

            Console.WriteLine($"Esse aparelho trocou de número? (sim ou nao)");
            string resposta = Console.ReadLine();

            if(resposta == "sim"){

                Console.WriteLine("Digite o novo número:");
                Numero = Console.ReadLine();
                NumeroSmartphone();
                condicao = false;

            } else if ( resposta== "nao"){
                Console.WriteLine("OK!");
                condicao = false;

            }else{
                Console.WriteLine("Digite uma resposta válida");
            }
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}