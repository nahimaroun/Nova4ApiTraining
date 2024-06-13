namespace FactoryDesignPattern
{
    class HighEndPc : IComputer
    {
        private readonly string GpuSpecs;

        public HighEndPc()
        {
            this.GpuSpecs = "4090 ti";
        }

        public string GPU()
        {

            return this.GpuSpecs;
        }

        public string PCType()
        {
            return "High-End";
        }
    }

}
