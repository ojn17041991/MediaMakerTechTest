namespace MediaMakerTechTest.Models.Abstractions
{
    public abstract class BaseCalculation
    {
        public double Input1 { get; set; }

        public double Input2 { get; set; }

        public double Result { get { return GetResult(); } }

        protected abstract double GetResult();
    }
}
