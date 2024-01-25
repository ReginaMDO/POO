using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void info()
        {
            Console.WriteLine($"Número:{Numero}");
            Console.WriteLine($"Modelo:{Modelo}");
            Console.WriteLine($"IMEI:{IMEI}");
            Console.WriteLine($"Memória:{Memoria}GB");
        }

        // Método abstrato que será sobrescrito nas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
