namespace FactoryDesignPattern
{
    internal class LowEndPc : IComputer
    {
        private readonly string GpuSpecs;

        public LowEndPc()
        {
            this.GpuSpecs = "GTX 1080";
        }

        public string GPU()
        {
            return this.GpuSpecs;
        }

        public string PCType()
        {
            return "Low-End";
        }
    }
}
