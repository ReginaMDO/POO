using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Criando instâncias de Nokia e Iphone
            Nokia nokia = new Nokia("123456789", "Nokia XYZ", "Nokia");
            Iphone iPhone = new Iphone("987654321", "iPhone 12", "Apple");

            // Chamando métodos
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            iPhone.Ligar();
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Instagram");
        }
    }
}
