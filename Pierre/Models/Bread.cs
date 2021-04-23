namespace Pierre
{
  public class Bread
  {
    public int LoavesInOrder { get; set; }

    public Bread(int loavesInOrder)
    {
      LoavesInOrder = loavesInOrder + 6;
    }
  }
}