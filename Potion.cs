public class Potion: Item
{
    public Potion(string name, double weight, RarityLevel rarity) : base(name, weight, rarity){}

    public override void Use(Hero hero)
    {
        hero.HP += 30;
    }
}