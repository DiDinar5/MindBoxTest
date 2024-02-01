namespace MindBoxTest.Figure.Interfaces
{
    public interface ITriangle: IShape
    {
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }
    }
}
