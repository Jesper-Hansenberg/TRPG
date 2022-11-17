new TRPG();


public class TRPG
{
    Character Player;

    public TRPG()
    {
        Player = new Character();
        ReadStoryFile("Welcome");
    }

    public void ReadStoryFile(string story)
    {
        using (StreamReader sr = new StreamReader("src/Story/"+story+".txt"))
        {
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}