using System.Collections;
public class Inventory<T>: IEnumerable<T> where T: Item
{
    private List<T> values = new();
    public double MaxWeight {get; private set;}
    public Inventory(double maxWeight)
    {
        MaxWeight = maxWeight;
    }

    public void Add(T item)
    {
        double CurrentWeight = 0;
        foreach (T value in values )
        {
            CurrentWeight += value.Weight;
        }
        if (CurrentWeight + item.Weight <= MaxWeight)
        {
            values.Add(item);
        }  
        else
        {
            Console.WriteLine("ERROR");
        }
    }
    public void Remove(T item)
    {
        values.Remove(item);
    }

    public T GetByName(string name)
    {
        foreach (T value in values)
        {
            if (value.Name == name)
            {
                return value;
            }
        }
        return null;
    }
    public IEnumerator<T> GetEnumerator()
    {
        return values.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void SortByRarity()
    {
        values.Sort();
    }
}