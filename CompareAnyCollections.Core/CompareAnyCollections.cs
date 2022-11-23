namespace CompareAnyCollections.Core;

public class CompareAnyCollections : ICompareAnyCollections
{
    public bool IsEqual<T>(ICollection<T> col1, ICollection<T> col2) where T : IEquatable<T>
    {
        if (col1.Count != col2.Count) return false;
        
        return !col1.Where((t, i) => !t.Equals(col2.ElementAt(i))).Any();
    }
    
    public bool IsEqual<T, TKey>(ICollection<T> col1, ICollection<KeyValuePair<TKey, T>> col2) where T : IEquatable<T>
    {
        return IsEqual(col1, col2.Select(c => c.Value).ToArray());
    }

    public bool IsEqual<T, TKey1, TKey2>(ICollection<KeyValuePair<TKey1, T>> col1, ICollection<KeyValuePair<TKey2, T>> col2) where T : IEquatable<T>
    {
        return IsEqual(
            col1.Select(c => c.Value).ToArray(),
            col2.Select(c => c.Value).ToArray());
    }
    
    public bool IsEqual<T, TKey>(ICollection<KeyValuePair<TKey, T>> col1,ICollection<T> col2) where T : IEquatable<T>
    {
        return IsEqual(col1.Select(c => c.Value).ToArray(), col2);
    }
    
    public bool IsEqual<T>(ICollection<T> col1, ICollection<T> col2, IComparer<T> comparer)
    {
        if (col1.Count != col2.Count) return false;
        
        return !col1.Where((t, i) => comparer.Compare(t, col2.ElementAt(i)) != 0).Any();
    }
    
    public bool IsEqual<T, TKey>(ICollection<T> col1, ICollection<KeyValuePair<TKey, T>> col2, IComparer<T> comparer)
    {
        return IsEqual(col1, col2.Select(c => c.Value).ToArray(), comparer);
    }
    
    public bool IsEqual<T, TKey1, TKey2>(ICollection<KeyValuePair<TKey1, T>> col1, ICollection<KeyValuePair<TKey2, T>> col2, IComparer<T> comparer)
    {
        return IsEqual(
            col1.Select(c => c.Value).ToArray(),
            col2.Select(c => c.Value).ToArray(),
            comparer);
    }
    
    public bool IsEqual<T, TKey>(ICollection<KeyValuePair<TKey, T>> col1,ICollection<T> col2, IComparer<T> comparer)
    {
        return IsEqual(col1.Select(c => c.Value).ToArray(), col2, comparer);
    }
}