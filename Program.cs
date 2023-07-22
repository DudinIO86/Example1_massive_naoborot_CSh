//блок исходных данных
int []arrow={2,1,2,3,4,5};
int size=arrow.Length;
int index=0;
int t1=arrow[0];

//блок операций
while(index<size)
{
    arrow[index]=arrow[size-index-1];
    arrow[size-1]=t1;
    index++;
}

//вывод на печать
var str=string.Join(" ",arrow);

Console.WriteLine(str);
