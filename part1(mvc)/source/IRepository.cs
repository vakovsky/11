public interface IRepository
{
  public void SaveAll(string FileName, List<Circle> circles);
  public List<Circle> LoadAll(string FileName);
}
