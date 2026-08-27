class Pokemon
{
    private string name;
    private int level;
    private int health;
    private Attack attack;

    public Pokemon(string name, int level, int health, Attack attack)
    {
        this.name = name;
        this.level = level;
        this.health = health;
        this.attack = attack;
    }

    public Attack GetAttack()
    {
        return attack;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Level: {level}, Health: {health}");
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;

        if (health < 0)
        {
            health = 0;
        }
    }

    public virtual void Attack(Pokemon target)
    {
        Console.WriteLine($"{name} usa {attack.GetName()}.");
        target.TakeDamage(attack.GetDamage());
    }
}