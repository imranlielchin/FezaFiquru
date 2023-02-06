namespace FezaFiquruEvTapsrq
{
    public class Slindr : FezaFiquru
    {
        protected double l;
        public Slindr(double r,double l) : base(r)
        {
            this.l = l;
        }

        public override double Varea()
        {
            double pi = Math.PI;
            double piRound = Math.Round(pi, 2);
            double V = piRound * r * r * this.l;
            V=Math.Round(V,2);
            return V;
        }
        public  double Areaot()
        {
            double pi = Math.PI;
            double piRound = Math.Round(pi, 2);
            double area = piRound * r * r;
            area = Math.Round(area, 2);
            return area;
        } 
        public double Areatam()
        {
            double pi = Math.PI;
            double piRound = Math.Round(pi, 2);
            double AreaTam = 2 * Areaot() + 2 * piRound * r * this.l;
            AreaTam = Math.Round(AreaTam, 2);
            return AreaTam;
        }
    }
}
