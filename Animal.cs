class Animal {
    public string AnimalName { get; set; }
}

class Species: Animal {
    public string SpeciesName { get; set; }   
}

class Elephant: Species {
    public string Noise { get; set; }     
    public int Legs { get; set; }
    public bool Aquatic { get; set; }
    public string FavoriteFood { get; set; }
}

class Dolphin: Species {
    public string Noise { get; set; }     
    public int Legs { get; set; }
    public bool Aquatic { get; set; }
    public string FavoriteFood { get; set; }
}

class Lion: Species {
    public string Noise { get; set; }     
    public int Legs { get; set; }
    public bool Aquatic { get; set; }
    public string FavoriteFood { get; set; }
}

class RedPanda: Species {
    public string Noise { get; set; }     
    public int Legs { get; set; }
    public bool Aquatic { get; set; }
    public string FavoriteFood { get; set; }
}

Elephant Luna = new Elephant();

Luna.SpeciesName = "Indian";
Luna.Noise = "baraag";
Luna.Legs = 4;
Luna.Aquatic = false;
Luna.FavoriteFood = "tree bark";

Console.Write("I have an Elephant named Luna who makes a noise that sounds like {0}. Her favorite food is {1}.", Luna.Noise, Luna.FavoriteFood);


Dolphin Pearl = new Dolphin();

Pearl.SpeciesName = "Bottlenose";
Pearl.Noise = "clickclickclick";
Pearl.Legs = 0;
Pearl.Aquatic = true;
Pearl.FavoriteFood = "fish";

Console.Write("I have an Dolphin named Pearl who makes a noise that sounds like {0}. Her favorite food is {1}.", Pearl.Noise, Pearl.FavoriteFood);


Lion George = new Lion();

George.SpeciesName = "African";
George.Noise = "rawr";
George.Legs = 4;
George.Aquatic = false;
George.FavoriteFood = "meat";

Console.Write("I have an Lion named George who makes a noise that sounds like {0}. His favorite food is {1}.", George.Noise, George.FavoriteFood);


RedPanda Ruby = new RedPanda();

Ruby.SpeciesName = "Red Panda";
Ruby.Noise = "squeak";
Ruby.Legs = 4;
Ruby.Aquatic = false;
Ruby.FavoriteFood = "bamboo";

Console.Write("I have an Red Panda named Ruby who makes a noise that sounds like {0}. Her favorite food is {1}.", Ruby.Noise, Ruby.FavoriteFood);

