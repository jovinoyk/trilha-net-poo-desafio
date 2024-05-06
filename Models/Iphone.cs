namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        // Construtor por herança
        public Iphone (string numero, string modelo, string imei, int memoria) :base(numero,modelo,imei,memoria){
            
        }

        //  Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo \"{aplicativo}\" no Iphone");
        }
    }
}