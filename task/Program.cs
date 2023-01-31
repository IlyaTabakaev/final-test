Console.WriteLine("input array size");
int size  = int.Parse(Console.ReadLine());

string[] arr1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("input array element: ");
    string result = Console.ReadLine();
	arr1[i] = result;  
}
Console.WriteLine();

Console.Write(string.Join(",", arr1));


int count = 0;
int maxSymbols = 3;

for (int i = 0; i < arr1.Length; i++){
	if(arr1[i].Length <= maxSymbols){
		count++;
	}   
}
Console.WriteLine();

string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= maxSymbols){
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + " ");
        j++;
    }
}
