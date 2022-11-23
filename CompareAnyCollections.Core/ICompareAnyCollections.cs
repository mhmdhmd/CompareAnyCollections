namespace CompareAnyCollections.Core;

public interface ICompareAnyCollections
{
    bool IsEqual<T>(ICollection<T> col1, ICollection<T> col2) where T : IEquatable<T>;
    bool IsEqual<T, TKey>(ICollection<T> col1, ICollection<KeyValuePair<TKey, T>> col2) where T : IEquatable<T>;

    bool IsEqual<T, TKey1, TKey2>(ICollection<KeyValuePair<TKey1, T>> col1, ICollection<KeyValuePair<TKey2, T>> col2)
        where T : IEquatable<T>;

    bool IsEqual<T, TKey>(ICollection<KeyValuePair<TKey, T>> col1, ICollection<T> col2) where T : IEquatable<T>;
    bool IsEqual<T>(ICollection<T> col1, ICollection<T> col2, IComparer<T> comparer);
    bool IsEqual<T, TKey>(ICollection<T> col1, ICollection<KeyValuePair<TKey, T>> col2, IComparer<T> comparer);

    bool IsEqual<T, TKey1, TKey2>(ICollection<KeyValuePair<TKey1, T>> col1, ICollection<KeyValuePair<TKey2, T>> col2,
        IComparer<T> comparer);

    bool IsEqual<T, TKey>(ICollection<KeyValuePair<TKey, T>> col1, ICollection<T> col2, IComparer<T> comparer);
}