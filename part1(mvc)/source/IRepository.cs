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
public class JSONRepository : IRepository
{
    public JSONRepository()
    {
    }
    public void SaveAll(string FileName, List<Circle> circles)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(circles, options);
        File.WriteAllText(FileName, json);
    }
    public List<Circle>? LoadAll(string FileName)
    {
        string json = File.ReadAllText(FileName);
        return (JsonSerializer.Deserialize(json, typeof(List<Circle>))) as List<Circle>;
    }
}
public class XMLRepository: IRepository
{
    public XMLRepository()
    {
    }
    public void SaveAll(string FileName, List<Circle> circles)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Circle>));
        StreamWriter streamWriter = new StreamWriter(FileName);
        xmlSerializer.Serialize(streamWriter, circles);
        streamWriter.Close();
    }
    public List<Circle>? LoadAll(string FileName)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Circle>));
        StreamReader streamReader = new StreamReader(FileName);
        return xmlSerializer.Deserialize(streamReader) as List<Circle>;
    }
}
public class CSVRepository : IRepository
{
    public CSVRepository()
    {
    }
    public void SaveAll(string FileName, List<Circle> circles)
    {
        List<string> lines = new List<string>();
        foreach (Circle circle in circles)
        {
            lines.Add(string.Format("{0};{1};{2};{3}", circle.Id, circle.R, circle.Perimeter, circle.Area));
        }
        File.WriteAllLines(FileName, lines);
    }
    public List<Circle>? LoadAll(string FileName)
    {
        string[] lines = File.ReadAllLines(FileName);
        List<Circle> circles = new List<Circle>();
        foreach (string line in lines)
        {
            string[] fields = line.Split(';');
            Circle circle = new Circle
            {
                Id = Convert.ToInt32(fields[0]),
                R = Convert.ToInt32(fields[1]),
                Perimeter = Convert.ToDouble(fields[2]),
                Area = Convert.ToDouble(fields[3]),
            };
            circles.Add(circle);
        }
        return circles;
    }
}
