// See https://aka.ms/new-console-template for more information
namespace Classes;
public class Program
{
  static void Main(string[] args)
  {
    bool activeMenu = true;
    int counter = 0;
    double qualification = 0;
    while (activeMenu)
    {
      Console.WriteLine("Do you want me to calculate your score: ");
      var option = Console.ReadLine();
      if (option == "yes" || option == "y")
      {
        Console.WriteLine("input a qualification: ");
        double inputQualification = Convert.ToDouble(Console.ReadLine());
        qualification += inputQualification;
        counter += 1;
        activeMenu = true;
      }
      else if (option == "no" || option == "n")
      {
        var calcificationTotal = qualification / counter;
        Console.WriteLine("this is your final grade");
        Console.WriteLine(calcificationTotal);
        Console.WriteLine("see you soon");
        activeMenu = false;
      }
      else
      {
        Console.WriteLine("option not valid, bye");
        activeMenu = false;
      }
    }
  }
}
