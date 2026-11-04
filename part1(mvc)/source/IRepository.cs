public interface IRepository
{
    public void SaveAll(string FileName, List<Circle> circles);
    public List<Circle>? LoadAll(string FileName);
}

public class FakeRepository : IRepository
{
    List<Circle> circles { get; set; }
    public FakeRepository()
    {
        circles = new List<Circle>();
        Circle circle = new Circle { R = 15 };
        List<Circle> circlesList = new List<Circle>
        {
            new Circle
            {
                R = 10,
            },
            new Circle
            {
                R = 23,
            },
            circle
        };
        Circle[] circlesArray = new[]
        {
            new Circle
            {
                  R = 50,
            },
            new Circle
            {
                R = 83,
            },
        };
        circles.AddRange(circlesList.ToArray());
        circles.AddRange(circlesArray);
        circles.Add(new Circle { R = 34 });
    }
    public void SaveAll(string FileName, List<Circle> circles)
    {
        
    }
    public List<Circle> LoadAll(string FileName)
    {
        return circles;
    }
}
