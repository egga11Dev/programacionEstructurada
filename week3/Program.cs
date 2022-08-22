// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input tree numbers");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
var operation = a + b;
Console.WriteLine("*******************************");
Console.WriteLine("   select option 1, option 2  ");
Console.WriteLine("*******************************");

int selection = Convert.ToInt32(Console.ReadLine());

switch (selection)
{
  case (1):
    if (operation == c)
    {
      Console.WriteLine("They are equal");
    }
    else
    {
      Console.WriteLine("They are not equal");
    }
    break;
  case (2):
    Console.WriteLine("until next time goodbye");
    break;
  default:
    Console.WriteLine("Option not valid");
    break;
}
Console.ReadKey();
