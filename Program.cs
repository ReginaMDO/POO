using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Criando instâncias de Nokia e Iphone
            Nokia nokia = new Nokia("91234-5678", "Nokia XYZ", "Nokia");
            Iphone iPhone = new Iphone("98765-4321", "Iphone 12", "Apple");

            // Chamando métodos
            Console.WriteLine("\n-----------------------------------------------------------------");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("\n-----------------------------------------------------------------");
            iPhone.Ligar();
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Instagram");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
