public class Armor: Item
{
    public Armor(string name, double weight, RarityLevel rarity) : base(name, weight, rarity){}

    public override void Use(Hero hero)
    {
        hero.Defense += 15;
    }
}