public class Hero
{
    public string Name { get; private set; }
    public int MaxHP { get; private set; }
    public int HP { get; set; } 
    public int Attack { get; set; }
    public int Defense { get; set; }
    public Inventory<Item> Backpack { get; private set; }
    public Hero(string name, int maxHp, int attack, int defense)
    {
        Name = name;
        MaxHP = maxHp;
        HP = maxHp; 
        Attack = attack;
        Defense = defense;
        Backpack = new Inventory<Item>(30.0); 
    }
}
