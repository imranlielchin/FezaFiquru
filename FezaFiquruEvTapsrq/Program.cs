namespace FezaFiquruEvTapsrq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var konus = new Konus(3, 2);
            konus.Areaot();
            Console.WriteLine($"Konusun Sahesi: {konus.Sbase}");
            Console.WriteLine($"Konusun Sethinin Sahesi: {konus}");
            Console.WriteLine();

            var slindr=new Slindr(3,2);
            Console.WriteLine($"Slindrin Sahesi: {slindr}");
            Console.WriteLine($"Slindrin Oturacaginin Sahesi: {slindr.Areaot()}");
            Console.WriteLine($"Slindrin Sethinin Sahesi: {slindr.Areatam()}");
            Console.WriteLine();

            var paralepiped = new Paralepiped(2, 4, 6);
            Console.WriteLine($"Pralepipedin Sahesi: {paralepiped.Varea()}");
            Console.WriteLine($"Pralepipedin Sethinin Sahesi: {paralepiped.Areatam()}");

        }
    }
}