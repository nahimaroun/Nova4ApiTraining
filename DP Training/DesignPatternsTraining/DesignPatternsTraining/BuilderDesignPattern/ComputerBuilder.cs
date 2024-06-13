namespace DesignPatternsTraining.BuilderDesignPattern
{
    public class ComputerBuilder
    {
        private Computer computer = new Computer();

        public ComputerBuilder AddName(string name)
        {
            computer.Name = name;
            return this;
        }
        public ComputerBuilder AddCPU(string cpu)
        {
            computer.CPU = cpu;
            return this;
        }
        public ComputerBuilder AddRAM(string ram)
        {
            computer.RAM = ram;
            return this;
        }
        public ComputerBuilder AddHardDisk(string hardDisk)
        {
            computer.HardDisk = hardDisk;
            return this;
        }
        public Computer Build()
        {
            return computer;
        }


    }
}
