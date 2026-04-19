public class Weapon: Item
{
    public Weapon(string name, double weight, RarityLevel rarity) : base(name, weight, rarity){}
    public override void Use(Hero hero) 
    {
        hero.Attack += 25;
    }
}