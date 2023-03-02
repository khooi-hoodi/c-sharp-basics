class Wizard
{
    public string? name;
    public string? favouriteSpell;
    public int spellSlots;
    public float experience;

    public Wizard(string _name, string _favouriteSpell)
    {
        name = _name;
        favouriteSpell = _favouriteSpell;
        spellSlots = 2;
        experience = 0f;
    }

    public void CastSpell()
    {
        if (spellSlots > 0)
        {
            Console.WriteLine(name + " casts " + favouriteSpell);
            spellSlots--;
            experience += 0.3f;
        }
        else
        {
            Console.WriteLine("No spell slots available.");
        }
    }

    public void Meditate()
    {
        Console.WriteLine("Spell slots have been regained.");
        spellSlots = 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Wizard wizard1 = new Wizard("Parry Hotter", "Unexpecto Patronum");

        Console.WriteLine("Spell slots: " + wizard1.spellSlots);

        wizard1.CastSpell();
        wizard1.CastSpell();
        wizard1.CastSpell();

        Console.WriteLine("Spell slots: " + wizard1.spellSlots);
        Console.WriteLine("Experience: " + wizard1.experience);

        wizard1.Meditate();

        Console.WriteLine("Spell slots: " + wizard1.spellSlots);
    }
}
