 Console.Clear();

string[] array = AskArray();
string[] AskArray() 
{
    Console.WriteLine("Введите массив строк (например: sd, :), 12345):");
    return Console.ReadLine().Split(", ");
}
            var result = new string[array.Length];            
            var realSize = 0;          
            foreach (var i in array)
            {
                if (i.Length <= 3)
                {
                    result[realSize] = i;
                    realSize++;
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result.Where(x => x != null))}]");
