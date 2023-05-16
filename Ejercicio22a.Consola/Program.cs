namespace Ejercicio22a.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversión de Temperaturas");
            Console.Write("Ingrese la temperatura:");
            var temperatura=double.Parse(Console.ReadLine());
            Console.Write("Ingrese la escala de la temperatura (C)elsius o (F)ahrenheit:");
            var escala=Console.ReadLine();
            if (escala.ToLower()=="c")
            {
                var fahrenheit = ConvertirCelsiusFahrenheit(temperatura);
                Console.WriteLine($"{temperatura} grados C equivalen a {fahrenheit} grados F");
            }else if (escala.ToLower()=="f") {
                var celsius = ConvertirFahrenheitCelsius(temperatura);
                Console.WriteLine($"{temperatura} grados F equivalen a {celsius} grados C");

            }
            else
            {
                Console.WriteLine("Escala no válida");
            }
        }

        private static double ConvertirFahrenheitCelsius(double temperatura) => (temperatura - 32) * 5 / 9;
        

        private static double ConvertirCelsiusFahrenheit(double temperatura) => 1.8 * temperatura + 32;
    }
}