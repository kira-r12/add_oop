
public abstract class Item: IComparable<Item>
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
    public int CompareTo(Item compare)
    {
        if (compare == null) 
            return 1;
            
        return this.Rarity.CompareTo(compare.Rarity);
    }

}