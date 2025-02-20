

Console.WriteLine("Array  e Listas ");

#region  ARRAY
var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var numersCopy = new int [10];


for (var i = 0; i < numbers.Length; i++)
{
    numersCopy[i] = numbers[i];
}
var numbersString ="0 1 2 3 4 5 6 7 8 9";
var numbersArray = numbersString.Split(" ");
var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);

#endregion

#region Listas 
var list = new List<int> {0, 1, 2, 3, 4,};
var listFromArray = new List<int> { 0, 1, 2, 3, 4 };

list.Add(5);
list.AddRange(new List<int> {6, 7});
list.AddRange(new List<int> {8, 9});

var count = list.Count;
var contains14 = list.Contains(14); 
var contains2 = list.Contains(2);


Console.WriteLine("Lista Reversa");
list.Reverse();
list.ForEach(i =>Console.WriteLine(i));

Console.WriteLine("Lista ordenanda");
list.Sort();
list.ForEach(i =>Console.WriteLine(i));

list.Remove(4);
list.RemoveAll(i => 1 > 5);

list.Clear();

#endregion