// Ataques
Attack flamethrower = new Attack("Lanzallamas", 40, "Fire");
Attack waterGun = new Attack("Pistola de Agua", 30, "Water");
Attack solarBeam = new Attack("Rayo Solar", 50, "Grass");


// Pokemon
Charizard charizard = new Charizard(
    "Charizard", 36, 150, 1000, true, flamethrower
);

Squirtle squirtle = new Squirtle(
    "Squirtle", 15, 90, 500, waterGun
);

Bulbasaur bulbasaur = new Bulbasaur(
    "Bulbasaur", 16, 95, 700, solarBeam
);


// Entrenadores
Trainer ash = new Trainer("Ash", charizard);
Trainer misty = new Trainer("Misty", squirtle);


// Polimorfismo
Pokemon pokemon1 = charizard;
Pokemon pokemon2 = squirtle;
Pokemon pokemon3 = bulbasaur;

Console.WriteLine("=== INFORMACIÓN DE LOS ENTRENADORES ===");
Console.WriteLine();

ash.DisplayInfo();
Console.WriteLine();
misty.DisplayInfo();

Console.WriteLine();
Console.WriteLine("=== BATALLA POKEMON ===");
Console.WriteLine();

// Ash ordena a Charizard atacar a Squirtle
ash.CommandAttack(squirtle);

Console.WriteLine();

squirtle.DisplayInfo();