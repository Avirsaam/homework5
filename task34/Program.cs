/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/



const int minRandomNumber = 100;
const int maxRundomNumber = 999;
const int arraySize = 8;

int eventNumberCount = 0;
int []myArray = new int[arraySize];

FillArrayWithRandomNumbers(minRandomNumber, maxRundomNumber, myArray);


for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0) eventNumberCount++;
}
Console.WriteLine($"{ArrayToPrettyString(myArray)} -> {eventNumberCount}");


string ArrayToPrettyString(int[] arrayToPrint){
    string strResult = string.Empty;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        strResult += arrayToPrint[i] - 48;
        
        if (arrayToPrint.Length - i >1) strResult += ", ";
        else strResult += "]";
    }
    return strResult;
}


void FillArrayWithRandomNumbers(int randomMin, int randomMax, int[] arrayToFill){
       
    Random rnd = new Random();
   
    for (int i = 0; i < arrayToFill.Length; i++)
    {
        arrayToFill[i] = rnd.Next(randomMin, randomMax);
    }

}