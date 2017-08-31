using System;
struct Movie
{
  public string title;
  public string subtitle;
  public string director;
  public int year;
};

public class testStructure
{
  public static void Main(string[] args)
  {
    Movie LotR;
    Movie Trek;

    LotR.title = "Lord of the Rings";
    LotR.subtitle = "The Fellowship of the Ring";
    LotR.director = "Peter Jackson";
    LotR.year = 2000;

    Trek.title = "Star Trek";
    Trek.subtitle = "Into Darkness";
    Trek.director = "JJ Abrams";
    Trek.year = 2015;

    Console.WriteLine("Movie 1 title: {0}", LotR.title);
    Console.WriteLine("Movie 1 subtitle: {0}", LotR.subtitle);
    Console.WriteLine("Movie 1 director: {0}", LotR.director);
    Console.WriteLine("Movie 1 year: {0}", LotR.year);


  }
}
