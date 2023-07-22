//блок исходных данных
int []arrow={5,1,2,3,4,7,55,4};

int size=arrow.Length;
int []arrow2=new int[size];
int index=0;

//блок операций
while(index<size)
{
   arrow2[index]=arrow[size-index-1];
   index++;
}

//вывод на печать
var str=string.Join(" ",arrow);
var str2=string.Join(" ",arrow2);

Console.WriteLine(str);
Console.WriteLine(str2);