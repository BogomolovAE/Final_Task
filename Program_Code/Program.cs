/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символов.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения агоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами */

Console.WriteLine ("Insert array of string, for ending enter: ~exit ");
string [] firstArray=new string [0];
string [] secondArray=new string [0];
string inputString="";
while (true)
{
    inputString=Console.ReadLine();
    if (inputString=="~exit") break;
    firstArray=AddElement(firstArray,inputString);
}
for (int i=0;i<firstArray.Length;i++)
{
    if (firstArray[i].Length<=3) secondArray=AddElement(secondArray,firstArray[i]);
}
Console.WriteLine ("Array with elements length less than 3 or equal to 3:");
for (int i=0;i<secondArray.Length;i++) Console.WriteLine(secondArray[i]);
string [] AddElement (string [] oldArray, string newElement)    //функция добавления нового элемента в массив
{
    string [] newArray=new string [oldArray.Length+1];
    for (int i=0;i<oldArray.Length;i++) newArray[i]=oldArray[i];
    newArray[oldArray.Length]=newElement;
    return newArray;
}