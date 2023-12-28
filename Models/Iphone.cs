namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Sobrescreve o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalação de aplicativo em um iPhone
            Console.WriteLine($"Instalando {nomeApp} no iPhone {Modelo}");
        }
    }
}