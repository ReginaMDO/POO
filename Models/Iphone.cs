namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
    public Iphone(string numero, string modelo, string marca) : base(numero, modelo, marca)
        {
        }
        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalação de aplicativo em um iPhone
            Console.WriteLine($"{nomeApp} está sendo instalado na loja do app store do {Modelo}!");
        }
    }
}
