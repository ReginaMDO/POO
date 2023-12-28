using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string marca)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            // TODO: Passar os parâmetros do construtor para as propriedades
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

        // Método abstrato que será sobrescrito nas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
