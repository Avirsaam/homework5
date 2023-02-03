/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/


const int minRandomNumber = 1;
const int maxRundomNumber = 99;
const int arraySize = 10;


int []myArray = new int[arraySize];
FillArrayWithRandomNumbers(minRandomNumber, maxRundomNumber, myArray);


int diffMaxMin = myArray[FindIndexOfMaxElement(myArray)] - myArray[FindIndexOfMinElement(myArray)];
Console.WriteLine($"{ArrayToPrettyString(myArray)} -> {diffMaxMin}");



//возвращает индекс максимального элемента массива
int FindIndexOfMaxElement(int[] arr)
{
    int indexOfMax = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[indexOfMax]) indexOfMax = i;
    }
    
    //Console.WriteLine($"Index of max is: {indexOfMax}");
    return indexOfMax;
}

//возвращает индекс минимального элемента массива
int FindIndexOfMinElement(int[] arr)
{
    int indexOfMin = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[indexOfMin]) indexOfMin = i;
    }
    
    //Console.WriteLine($"Index of min is: {indexOfMin}");
    return indexOfMin;
}

//возвращает строку, содержащую элементы массива в 
//удобночитаемом виде
string ArrayToPrettyString(int[] arrayToPrint){
    
    string strResult = string.Empty;
    
    Console.Write("[");
    
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        strResult += arrayToPrint[i];
        
        if (arrayToPrint.Length - i > 1) strResult += ", ";
        else strResult += "]";
    }
    
    return strResult;
}

//создает массив указанного размера
//заполненный числами из указанного 
//диапазона
void FillArrayWithRandomNumbers(int randomMin, int randomMax, int[] arrayToFill){
       
    Random rnd = new Random();
   
    for (int i = 0; i < arrayToFill.Length; i++)
    {
        arrayToFill[i] = rnd.Next(randomMin, randomMax);
    }
}