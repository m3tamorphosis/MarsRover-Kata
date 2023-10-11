using kataMarsRover;

internal class Program
{

    public static void Main(string[] args)
    {
        string[,] map = {  { "■", "■", "■", "■", "■", "■"},
                            { "■", "■", "■", "■", "■", "■"},
                            { "■", "■", "■", "■", "■", "■"},
                            { "■", "■", "■", "■", "■", "■"},
                            { "■", "■", "■", "■", "■", "■"},
                            { "■", "■", "■", "■", "■", "■"}};

        var rand = new Random();
        int obstacles = rand.Next(0, 10);
        for (int i = 0; i < obstacles; i++)
        {
            int x = rand.Next(0, 5);
            int y = rand.Next(0, 5);
            map[x, y] = "X";
        }
        string[,] temp = new string[map.GetLength(0),map.GetLength(1)];
        Array.Copy(map, temp, map.Length);
        bool cont = true;
        temp[5, 0] = "^";
        int col = 0;
        int row = 5;
        var left = new RoverLeft();
        var right = new RoverRight();
        while (cont)
        {
            Console.Clear();
            Console.WriteLine("Y");
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    Console.Write(temp[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("|_____________X");
            ConsoleKeyInfo input = Console.ReadKey(true);


            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (temp[row, col] == "^" && row > 0 && temp[row-1,col] != "X")
                    {
                        Array.Copy(map, temp, map.Length);
                        row--;
                        temp[row, col] = "^";
                    }
                    else if(temp[row, col] == ">" && col < map.GetLength(1)-1 && temp[row, col+1] != "X")
                    {
                        Array.Copy(map, temp, map.Length);
                        col++;
                        temp[row, col] = ">";
                    }
                    else if (temp[row, col] == "<" && col > 0 && temp[row, col - 1] != "X")
                    {
                        Array.Copy(map, temp, map.Length);
                        col--;
                        temp[row, col] = "<";
                    }
                    else if (temp[row, col] == "v" && row < map.GetLength(1) - 1 && temp[row + 1, col] != "X")
                    {
                        Array.Copy(map, temp, map.Length);
                        row++;
                        temp[row, col] = "v";

                    }

                    break;
                case ConsoleKey.LeftArrow:
                    temp[row, col] = left.Direction(temp[row, col]);
                    break;
                case ConsoleKey.RightArrow:
                    temp[row, col] = right.Direction(temp[row, col]);

                    break;
                case ConsoleKey.Escape:
                    cont = false;
                    break;
                default:
                    Console.WriteLine("Please press Arrow Keys");
                    break;
            }

        }






    }
}