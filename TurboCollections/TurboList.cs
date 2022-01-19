using System;

namespace TurboCollections{

public class TurboList<T>
{
    public int Count { get; private set; }
    private T[] items = Array.Empty<T>();
    public TurboList()
    {
        
        Console.WriteLine("Hello, Turbo!");
    }

    public void Add(T item)
    {    // Resize the array
        T[] newArray = new T[Count + 1];
        for (int i = 0; i < Count; i++)
        {
            newArray[i] = items[i];
        }
        items = newArray;
        //Assign the new element
        newArray[Count] = item;
        
        Count++;

    }

    void EnsureSize(int size)
    {   
        if(items.Length >= size)
            return;
        int newSize = Math.Max(size, items.Length * 2);

        T[] newArray = new T[Count + 1];
        for (int i = 0; i < Count; i++)
        {
            newArray[i] = items[i];
        }
        items = newArray;
    }
    public T Get(int index)
    {
        return items[index];
    }
} 


}
