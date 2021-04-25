namespace Pierre.Models
{
  public class Bread
  {
    public int LoavesInOrder { get; set; }
    public int CostPerLoaf = 5;
    
    public Bread(int loavesInOrder)
    {
      LoavesInOrder = loavesInOrder;
    }

    public static int PriceOfLoaves()
    {
      int SubTotal = 0;
      // GetAll instances of Bread

      // iterate through all Breads, add calculated price of breads to SubTotal each time through

      // return SubTotal after loop
      return SubTotal;
    }
  }
}