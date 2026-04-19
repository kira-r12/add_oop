class ConsoleManager
{
    static void Main()
    {
        Hero hero = new Hero("Kira", maxHp: 100, attack: 25, defense: 60);
  
            
        Item weapon = new Weapon("LalalaWeapon", 5.0, RarityLevel.Legendary);
        Item potion = new Potion("bebebePotion", 0.5, RarityLevel.Common);
        Item armor = new Armor("kikikiArmor", 3.5, RarityLevel.Rare);
        while (true)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("1.  Показати інвентар героя");
            Console.WriteLine("2.  Додати предмет до інвентаря");
            Console.WriteLine("3.  Використати предмет за назвою.");
            Console.WriteLine("4.  Відсортувати інвентар за рідкістю.");
            Console.WriteLine("5.  Показати характеристики героя.");
            Console.WriteLine("6.  Вихід.");
            Console.WriteLine("Ваш вибір:");

            string? userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case "1":
                    double currentWeight = hero.Backpack.Sum(i => i.Weight);
                    Console.WriteLine($"Інвентар ({currentWeight} /{hero.Backpack.MaxWeight} кг):");
                    
                    foreach (Item item in hero.Backpack) 
                    {
                        Console.WriteLine($"[{item.Rarity}] {item.Name} ({item.Weight})");
                    }
                    break;

                case "2":
                    hero.Backpack.Add(weapon);
                    hero.Backpack.Add(potion);
                    hero.Backpack.Add(armor);
                    Console.WriteLine("Предмети додано");
                    break;

                case "3":
                    Console.Write("Введіть назву предмета: ");
                    string itemName = Console.ReadLine();
                    Item foundItem = hero.Backpack.GetByName(itemName);
                    
                    if (foundItem != null)
                    {
                        foundItem.Use(hero);
                        hero.Backpack.Remove(foundItem);
                        Console.WriteLine($"Ви успішно використали [{foundItem.Name}]");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Предмет не знайдено в інвентарі.");
                    }
                    break;

                case "4":
                    hero.Backpack.SortByRarity(); 
                    Console.WriteLine("Інвентар відсортовано за рідкістю");
                    break;

                case "5":
                    Console.WriteLine($"--- Статус: {hero.Name} ---");
                    Console.WriteLine($"HP: {hero.HP} / {hero.MaxHP}");
                    Console.WriteLine($"Атака: {hero.Attack}");
                    Console.WriteLine($"Захист: {hero.Defense}");
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Невідома команда. Спробуйте ще раз.");
                    break;
            }
        }
    }
}
