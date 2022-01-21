using System;
using System.Linq;

namespace TurboCollections{

public class TurboList<T>
{
    public int Count { get; private set; }
    private T[] items = Array.Empty<T>();
 

    public void Add(T item)
    {    
        EnsureSize(Count + 1);
        items[Count++] = item;
        
    }
    /// <summary>
    /// This method ensures that the array is at least 'size' big
    /// </summary>
    /// <param name="size">The size that your array should have</param>
    void EnsureSize(int size)
    {   
        // if the array is large enough, return
        if(items.Length >= size)
            return;
        
        //double the array size, or set it to given size if doubling is not enough
        int newSize = Math.Max(size, items.Length * 2);
        
        //create new array
        T[] newArray = new T[Count + 1];
        for (int i = 0; i < Count; i++)
        {   //copy old items
            newArray[i] = items[i];
        }
        // assign new array
        items = newArray;
    }
    public T Get(int index)
    {
        return items[index];
    }

    public void Set(int index, T item)
    {
        
        items[index] = item;
    }

    public void Clear()
    {
        for (int i = 0; i < Count; i++)
        {
            items[i] = default;
        }
        Count = 0;
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < Count -1; i++)
        {
            items[i] = items[i + 1];
        }
        Count--;
    }

    public bool Contains(T item)
    {
        
        for (int i = 0; i < Count; i++)
        {
            if (item.Equals(items[i]) )
            
                return true; 
        }

        return false;
    }
    
    public int IndexOf(T item)
    {
        
        for (int i = 0; i < Count; i++)
        {
            if (item.Equals(items[i]))

                return i;
        }

        return -1;
    }
        
  }
}
