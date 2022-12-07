public class Character
{
    public string Name;
    public int Health;
    public Weapon HeldWeapon;
    public int Level;
    public int Strength;
    public int Saturation;

    public Character()
    {
    }

    public Character(string name, int level, int strength)
    {
        Name = name;
        Level = level;
        Strength = strength;
        Health = 10 * Strength;
        HeldWeapon = new Weapon();
    }
}