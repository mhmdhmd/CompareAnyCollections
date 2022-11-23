namespace CompareAnyCollections.Run.Model;

public class MoneyComparer : IComparer<Money>
{
    public int Compare(Money? x, Money? y)
    {
        if (x!.Amount == y!.Amount) return 0;
        if (x.Amount < y.Amount) return -1;
        return 1;
    }
}