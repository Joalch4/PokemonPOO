// Clase que representa un ataque de un Pokemon
class Attack
{
    // Atributos del ataque
    private string name;
    private int damage;
    private string type;

    // Constructor para crear un ataque con su nombre, daño y tipo
    public Attack(string name, int damage, string type)
    {
        this.name = name;
        this.damage = damage;
        this.type = type;
    }

    // Muestra la información del ataque en consola
    public void DisplayInfo()
    {
        Console.WriteLine($"Attack Name: {name}, Damage: {damage}, Type: {type}");
    }

    // Devuelve el nombre del ataque
    public string GetName()
    {
        return name;
    }

    // Devuelve el daño que realiza el ataque
    public int GetDamage()
    {
        return damage;
    }

    // Devuelve el tipo del ataque
    public string GetAttackType()
    {
        return type;
    }
}
