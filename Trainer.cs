class Trainer
{
    private string trainerName;
    private Pokemon pokemon;
    public Trainer(string trainerName, Pokemon pokemon)
    {
        this.trainerName = trainerName;
        this.pokemon = pokemon;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Trainer Name: {trainerName}");
        pokemon.DisplayInfo();
    }
    public void CommandAttack(Pokemon target)
    {
        pokemon.Attack(target);
    }
}