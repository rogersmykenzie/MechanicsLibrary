using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;
using MechanicsLibrary.Core.Battle;

Hero Benson = new Hero { Name = "Benson", Abilities = new List<Ability> { AbilityCollection.ATTACK, AbilityCollection.SMITE, AbilityCollection.DEFEND, AbilityCollection.CLEAVE }, Stats = new StatCollection { Health = 100, Armor = 25, Grit = 0, Strength = 15, Speed = 25 } };
Enemy Pig = new Enemy { Name = "Pig", Abilities = new List<Ability> { AbilityCollection.ATTACK }, Stats = new StatCollection { Health = 10, Armor = 10, Grit = 0, Strength = 10, Speed = 10 } };
Enemy Pig2 = new Enemy { Name = "Pig", Abilities = new List<Ability> { AbilityCollection.ATTACK }, Stats = new StatCollection { Health = 10, Armor = 10, Grit = 0, Strength = 10, Speed = 10 } };
Enemy Pig3 = new Enemy { Name = "Pig", Abilities = new List<Ability> { AbilityCollection.ATTACK }, Stats = new StatCollection { Health = 10, Armor = 10, Grit = 0, Strength = 10, Speed = 10 } };

Combat combat = new Combat(
    new KillableCharacter[,] { { Benson } },
    new KillableCharacter[,] { { Pig, Pig2, Pig3 } }
);

combat.TurnManager.Debug();
combat.TurnManager.NextTurn();
combat.TurnManager.Debug();

// Benson.Abilities[3].Execute(new AbilityContext { User = Benson, Targets = new List<KillableCharacter> { Pig, Pig2, Pig3 } });
// Pig.Debug();
// Pig2.Debug();
// Pig3.Debug();
// Pig.Abilities[0].Execute(new AbilityContext { User = Pig, Targets = new List<KillableCharacter> { Benson } });
// Pig2.Abilities[0].Execute(new AbilityContext { User = Pig2, Targets = new List<KillableCharacter> { Benson } });
// Pig3.Abilities[0].Execute(new AbilityContext { User = Pig3, Targets = new List<KillableCharacter> { Benson } });
// Benson.Abilities[0].Execute(new AbilityContext { User = Benson, Targets = new List<KillableCharacter> { Pig } });
// Pig.Debug();
// Pig2.Debug();
// Pig3.Debug();