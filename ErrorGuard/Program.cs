/*
 Istifadeciden array uzunlugunu iste ve 
hemin uzunluqda bir array yarat.Array-in uzunlugu sayda elave ededler iste 
ve hemin ededleri array-e doldur 
 */

Console.WriteLine("Enter a length number for the array:");

string arrayLength = Console.ReadLine();

int arrayCheck;
bool check = int.TryParse(arrayLength, out arrayCheck);

int[] arr = new int[arrayCheck];



if (check == false)
{
    Console.WriteLine("you didn't enter a number");
    return;
}



for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Enter each index of the array");
    string arrIndex = Console.ReadLine();

    int index;
    bool caseIndex = int.TryParse(arrIndex, out index);

    if (caseIndex == false)
    {
        Console.WriteLine("you didn't enter a number");
        return;
    }

    arr[i] = index;
}

Console.WriteLine("Here's your number:");

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}





































