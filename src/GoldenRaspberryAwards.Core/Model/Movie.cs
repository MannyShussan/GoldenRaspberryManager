namespace GoldenRaspberryAwards.Core.Model;

public class Movie
{
  public int Year { get; set; }
  public string Title { get; set; }
  public string Studios { get; set; }
  public string Producers { get; set; }
  public bool IsWinner { get; set; }
}
