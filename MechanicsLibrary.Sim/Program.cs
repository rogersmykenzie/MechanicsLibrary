using MechanicsLibrary.Core.Character;
using MechanicsLibrary.Core.Abilities;
using MechanicsLibrary.Core.Stats;

Hero Benson = new Hero { Abilities = new List<Ability> { AbilityCollection.ATTACK, AbilityCollection.SMITE, AbilityCollection.DEFEND }, Stats = new StatCollection { Health = 100, Armor = 25, Grit = 0, Strength = 15 } };
Enemy Pig = new Enemy { Abilities = new List<Ability> { AbilityCollection.ATTACK }, Stats = new StatCollection { Health = 10, Armor = 10, Grit = 0, Strength = 10 } };

Pig.Abilities[0].Execute(new AbilityContext { User = Pig, Targets = new List<KillableCharacter> { Benson } });
Benson.Abilities[2].Execute(new AbilityContext { User = Benson, Targets = new List<KillableCharacter> { Benson } });
Pig.Abilities[0].Execute(new AbilityContext { User = Pig, Targets = new List<KillableCharacter> { Benson } });