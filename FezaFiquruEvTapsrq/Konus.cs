namespace FezaFiquruEvTapsrq
{
    public class Konus : FezaFiquru
    {
        public double Sbase { get; set; }
        private double h;
        public Konus(double r,double h)
            :base(r)
        {
            this.h = h;
        }

        public void Areaot()
        {
            double pi = Math.PI;
            double piRound = Math.Round(pi, 2);
            double area = piRound * r * r;
            area = Math.Round(area, 2);
            this.Sbase = area;
        }

        public override double Varea()
        {
             return this.Sbase * h / 3;   
           
        }
    }
}
