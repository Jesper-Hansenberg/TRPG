new TRPG();


public class TRPG
{
    public Character Player;
    public List<string> Chapters;

    public TRPG()
    {
        Chapters = new List<string>();
        Player = new Character();

        Chapters.Add("Welcome");
        Chapters.Add("Chapter_1");
        Chapters.Add("Tavern");
        Chapters.Add("Volcano");

        ReadStoryFile(Chapters[0], true);
        Console.WriteLine("Please enter your name");
        Player.Name = GetStringInput("No, I want your name");
        Console.WriteLine("Please enter level");
        Player.Level = GetIntInput("No, I want your level");
        Console.WriteLine("Please enter strength");
        Player.Strength = GetIntInput("No, I want your strength");
        Player.Health = 10 * Player.Strength;

        ReadStoryFile(Chapters[1], true);
        Console.ReadLine();
        Console.Clear();
        ReadStoryFile(Chapters[2], false);
        Console.ReadLine();
        Console.Clear();
        ReadStoryFile(Chapters[3], false);
        Console.ReadLine();
        Console.Clear();
    }

    public string TypeWriter(string input, int speed = 50)
    {
        if (input.Length > 0)
        {
            string firstCharacter = input.Substring(0, 1);
            string restOfInput = input.Remove(0, 1);
            Console.Write(firstCharacter);
            Thread.Sleep(speed);
            return TypeWriter(restOfInput, speed);
        }
        else
        {
            return "";
        }
    }

    public void ReadStoryFile(string story, bool typewriter)
    {
        using (StreamReader sr = new StreamReader("src/Story/" + story + ".txt"))
        {
            while (!sr.EndOfStream)
            {
                String s = sr.ReadLine();
                if (s != null)
                {
                    if (typewriter)
                    {
                        TypeWriter(s, 1);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }

    public int GetIntInput(string errorMessage)
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out var value))
            {
                return value;
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }

    public string GetStringInput(string errorMessage)
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input != null)
            {
                return input;
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
