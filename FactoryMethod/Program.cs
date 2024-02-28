

using FactoryMethod.Heroes;

var warrior = new WarriorHero("Воин", 80, 6, 3, 2);
var skill = warrior.CreateSkill("Размашистый удар", 8.5, 30);
skill.ApplySkill();

var mage = new MageHero("Маг", 40, 8, 1, 1);
var mageSkill = mage.CreateSkill("Барьер Арканы", 20, 60);
mageSkill.ApplySkill();

var thief = new ThiefHero("Вор", 50, 5, 1, 4);
var thiefSkill = thief.CreateSkill("thiefSkill", 25, 45);
thiefSkill.ApplySkill();
