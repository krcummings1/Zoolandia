class Animal 
{
  public string AnimalName { get; set; }
  public string Habitat { get; set; }
  public string FavoriteFood { get; set; }
  public bool Aquatic { get; set; }
  public int Legs { get; set; }
}

// GENUS SHOULD NOT HAVE CONSTRUCTOR

// PANTHERA GENUS
class Panthera: Animal 
{
  public string SpeciesName { get; set; }
  public string Noise { get; set; }
  public int Teeth { get; set; } 
  public virtual string SpecialFeature(){
    return "not special";
  }
}

class Lion: Panthera 
{
  public string ColorOfMane { get; set; }  
}

class Tiger: Panthera 
{
  public int NumberOfStripes { get; set; }
  public override string SpecialFeature() {
    return "stripes";
  }  
}

class Jaguar: Panthera 
{
  public int NumberOfSpots { get; set; } 
}

class Leopard: Panthera 
{
  public int NumberOfSpots { get; set; } 
  public override string SpecialFeature() {
    return "spots";
  }  
}

Lion george = new Lion();

george.SpeciesName = "Panthera";
george.Noise = "rawr";
george.ColorOfMane = "golden";
george.Aquatic = false;
george.Habitat = "safari";
george.Legs = 4;

Console.Write("I have a Lion named George who makes a noise that sounds like {0}. He lives in a {1}.", george.Noise, george.Habitat);

Tiger tigger = new Tiger();
Leopard lionel = new Leopard();

Console.WriteLine(tigger.SpecialFeature());
Console.WriteLine(lionel.SpecialFeature());

// CHEETAH GENUS
class Acinonyx: Animal 
{
  public string SpeciesName { get; set; }
  public string Noise {get; set;}
}

class Cheetah: Acinonyx 
{
  public int NumberOfSpots { get; set; } 
}

// ELEPHAS GENUS
class Elephas: Animal 
{
  public string SpeciesName { get; set; }
  public string Noise {get; set;}
}

class AsianElephant: Elephas
{
  public string HomeContinent { get; set; } 
}

class AfricanElephant: Elephas
{
  public string HomeContinent { get; set; } 
}

AsianElephant luna = new AsianElephant();

luna.SpeciesName = "Elephas";
luna.Noise = "baraag";
luna.Legs = 4;
luna.Aquatic = false;
luna.FavoriteFood = "tree bark";
luna.HomeContinent = "Asia";

Console.Write("I have an Asian Elephant named Luna who makes a noise that sounds like {0}. Her favorite food is {1}. She lives in {2}.", luna.Noise, luna.FavoriteFood, luna.HomeContinent);


// RED PANDA GENUS
class Ailurus: Animal 
{
  public string SpeciesName { get; set; }
  public string Noise {get; set;}
}

class RedPanda: Ailurus 
{
  public int CutenessRating { get; set; }
}


// PANDA GENUS
class Ailuropoda: Animal
{
  public string SpeciesName { get; set; }
  public string Noise {get; set;}
}

class GiantPanda: Ailuropoda
{
  public string SpecialSkill { get; set; } 
}


// COMMON BEAR GENUS
class Ursus: Animal 
{
  public string Noise { get; set; }     
  public string SpeciesName { get; set; }
  public bool FriendOfBaxter { get; set; } 
}

class PolarBear: Ursus 
{
 public bool DrinksCocaCola { get; set; } 
}

class KodiakBear: Ursus 
{
  public string FavoritePastime { get; set;}
}

class GrizzlyBear: Ursus 
{
  public string FavoriteTeam { get; set;}
}


// GIRAFFE GENUS
class Giraffa: Animal 
{
  public string SpeciesName { get; set; }
  public string Noise {get; set;}
}

class Giraffe: Giraffa 
{
  public int HeightRating { get; set; } 
}


// DOLPHIN GENUS
class Cephalorhynchus: Animal 
{
  public string SpeciesName { get; set; }
  public string Noise {get; set;}
  public int Fins { get; set; }
}

class BlackDolphin: Cephalorhynchus
{
  public bool Chic { get; set; }
}

class CommersonsDolphin: Cephalorhynchus
{
  public bool Famous { get; set; }
}






// Dolphin Pearl = new Dolphin();

// Pearl.SpeciesName = "Bottlenose";
// Pearl.Noise = "clickclickclick";
// Pearl.Legs = 0;
// Pearl.Aquatic = true;
// Pearl.FavoriteFood = "fish";

// Console.Write("I have an Dolphin named Pearl who makes a noise that sounds like {0}. Her favorite food is {1}.", Pearl.Noise, Pearl.FavoriteFood);










