List<int> result = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



result.RemoveAll(i => i % 2 == 0);
for (int i = 0; i < result.Count; i++) {
    Console.WriteLine(result[i]);
}