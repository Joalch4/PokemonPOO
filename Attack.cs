class Attack
{
    private string name;
    private int damage;
    private string type;
    public Attack(string name, int damage, string type)
    {
        this.name = name;
        this.damage = damage;
        this.type = type;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Attack Name: {name}, Damage: {damage}, Type: {type}");
    }
    public string GetName()
    {
        return name;
    }
    public int GetDamage()
    {
        return damage;
    }
    public string GetAttackType()
    {
        return type;
    }
}