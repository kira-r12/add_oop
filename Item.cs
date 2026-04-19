
public abstract class Item
{
    public string Name {get; private set;} 
    public double Weight {get; private set;}
     public RarityLevel Rarity { get; private set; }

    public Item (string name, double weight, RarityLevel rarity)
    {
        Name = name;
        Weight = weight;
        Rarity = rarity;
    }
    public abstract void Use(Hero hero);

}