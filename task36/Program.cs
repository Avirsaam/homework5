/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/



const int minRandomNumber = 1;
const int maxRundomNumber = 99;
const int arraySize = 4;

int sumOfOddIndexElements = 0;
int []myArray = new int[arraySize];


FillArrayWithRandomNumbers(minRandomNumber, maxRundomNumber, myArray);

for (int i = 0; i < myArray.Length; i++)
{
    if (i % 2 != 0) sumOfOddIndexElements+=myArray[i];
}

Console.WriteLine($"{ArrayToPrettyString(myArray)} -> {sumOfOddIndexElements}");




//возвращает строку, содержащую элементы массива в 
//удобночитаемом виде
string ArrayToPrettyString(int[] arrayToPrint){
    string strResult = string.Empty;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        strResult += arrayToPrint[i];
        
        if (arrayToPrint.Length - i >1) strResult += ", ";
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