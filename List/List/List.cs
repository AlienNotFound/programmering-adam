using System.Collections;

namespace TCCollections;
public class List : IEnumerable<object>
{
    object[] list = new object[10];
    int indx = 0;
    
    public void Add(object obj)
    {
        if (obj == null)
        {
            Console.WriteLine("Cannot be null");
            return;
        }
        
        if(indx >= 0)
        {
            list[indx] = obj;
            indx++;
        }
    }
    public void Remove(object obj)
    {
        if(list.Contains(obj))
        {
            list[indx] = null;
            indx = 0;
        }
    }
    public object? Get(int index) 
    {
        if(list[index] == null)
        {
            return null;
        }
        else
        {
            return list[index];
        }
    }

    public bool Contains(object obj)
    {
        if(Find(obj) == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int Find(object obj)
    {
        for(int i = 0; i < indx; i++)
        {
            if(list[i] == obj)
            {
                return i;
            }
        }
        return -1;
    }

    public IEnumerator<object> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int Count {get {return indx;}}

    static void Main(string[] args)
    {
        List array = new List();
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }

    }
}
