# Combat

## Defense
Armor = % phys damage reduction
Type Resistance = % type damage reduction
Grit = Flat phys damage reduction
Type Shield = Flat type damage reduction

## Offense
1 point of strength = 1% increased physical damage.
1 point of 

## Gameplay
Gameplay consists of a fusion of tactics/turn based rpg combat
Manage formations of troops on battlefields
Zoomed out macro view of your pods of warriors
Can zoom in and micro manage individual conflicts in a large battle
Can tab between your pods quickly and easily
Have hero units that can take down grunt soliders quickly, cast battlefield-wide spells, or go toe to toe with elite enemy units
Can sacrifice turns in individual conflicts to move troops over to other pods
If you spend too much time focusing on one pod, indicators that your other pods are struggling will appear
Notifications of other units on the battlefield
Potentially program pods so they have instructions of what to do when you are not micro managing
Focus is more emphasized on turn based combat than strategically moving your troops.

# Building Teams
Idea would be that you get to build teams of units that you like.
There would be lots of missions with one team, but then also missions with maybe two or three teams that you have to manage.
Throughout the game you will be able to recruit or train new units - the units that you get and their starting stats/abilities will be dictated by things like your level, research tree, the kind of units you are missing, etc.
  For this we could have a builder class that exposes different methods to plug in this data and will produce you a unit.
    E.G. I instantiate the builder class, call withLevel, withResearch, withCurrentUnits, etc and then i can call buildUnit and it will weight everything properly to generate a new unit