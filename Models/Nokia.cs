namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
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
