namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalação de aplicativo em um Nokia
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo}");
        }
    }
}
