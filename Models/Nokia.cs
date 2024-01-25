namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string marca) : base(numero, modelo, marca)
        {
        }
        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalação de aplicativo em um Nokia
            Console.WriteLine($"Instalando {nomeApp} na loja do {Modelo}!");
        }
    }
}
