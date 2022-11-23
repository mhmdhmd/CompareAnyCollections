using CompareAnyCollections.Run.Model;

CompareAnyCollections.Core.CompareAnyCollections collectionComparer = new();

//*** 1
//create two different collections of person and compare theirs elements (Person implements IEquatable<T>)
Person[] personArray =
{
    new Person("jack", 23),
    new Person("martin", 20)
};

Dictionary<int, Person> personDict = new();
personDict[0] = new Person("jack", 23);
personDict[1] = new Person("martin", 20);

var result = collectionComparer.IsEqual(personArray, personDict);

Console.WriteLine($"Do array of person and dictionary of person have same elements? {result}");

//*** 2
//create two different collections of Money and compare theirs elements (instead of implementing IEquatable<T> in Money class,
//there is another class called MoneyComparer which implements IComparer<T> interface
List<Money> moneyList = new();
moneyList.Add(new Money(200));
moneyList.Add(new Money(340));
moneyList.Add(new Money(120));

SortedList<int, Money> moneySorted = new();
moneySorted[0] = new Money(200);
moneySorted[1] = new Money(340);
moneySorted[2] = new Money(120);

var result2 = collectionComparer.IsEqual(moneyList, moneySorted, new MoneyComparer());

Console.WriteLine($"Do list of Money and sortedList of Money have same elements? {result2}");