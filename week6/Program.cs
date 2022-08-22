// See https://aka.ms/new-console-template for more information

namespace Matrix
{
  class Matrix
  {
    private int[,] mat;

    public void Input(int number)
    {
      mat = new int[number, number];
      Console.Write("Input number: ");
      string online;
      online = Console.ReadLine();
      for (int f = 0; f < number; f++)
      {
        for (int c = 0; c < number; c++)
        {
          mat[f, c] = int.Parse(online);
        }
      }
    }

    public void Print(int length)
    {
      for (int f = 0; f < length; f++)
      {
        for (int c = 0; c < length; c++)
        {
          Console.Write(mat[f, c] + " ");
        }
        Console.WriteLine();
      }
      Console.ReadKey();
    }

    static void Main(string[] args)
    {
      Matrix ma = new Matrix();
      Console.WriteLine("input length of matrix: ");
      int input = int.Parse(Console.ReadLine());
      ma.Input(input);
      ma.Print(input);
    }
  }
}