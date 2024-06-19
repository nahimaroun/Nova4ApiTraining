namespace TemplateMethodDesignPattern
{
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods, wood and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Wood Pillars with wood coating");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wooden Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wooden Windows");
        }
    }
}
