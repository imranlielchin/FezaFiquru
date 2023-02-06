namespace FezaFiquruEvTapsrq
{
    public abstract class FezaFiquru
    {
        protected double r;
        
        public FezaFiquru(double r)
        {
            this.r = r;
        }

        
        public abstract double Varea();

        public override string ToString()
        {
            return $"{this.Varea()}";
        }
    }
}
