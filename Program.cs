using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Criando instâncias de Nokia e Iphone
            Nokia nokia = new Nokia("91234-5678", "Nokia XYZ",  "105689243750975", 64);
            Iphone iPhone = new Iphone("98765-4321", "Iphone 12", "739884273890471", 128);

            // Chamando métodos
            Console.WriteLine("-----------------------------------------------------------------");
            nokia.info();
            Console.WriteLine("-----------------------------------------------------------------");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("\n-----------------------------------------------------------------");
            iPhone.info();
            Console.WriteLine("-----------------------------------------------------------------");
            iPhone.Ligar();
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Instagram");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
