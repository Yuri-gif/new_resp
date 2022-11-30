Console.WriteLine("Введите количество элементов в массиве.");
int col=Convert.ToInt32(Console.ReadLine());
int [] mas=new int [col];
int cout=0;
Colraze(mas,col,cout);

//Функция заполнения массива и вычисления разницы
void Colraze(int [] m, int c, int r)
{
    int max=0;
    int min=20;
    Random ran=new Random();
    for(int i=0;i<c;i++)
    {
        m[i]=ran.Next(20);
        Console.WriteLine(m[i]);
        if(max<m[i]) max=m[i];
        if(m[i]<min) min=m[i];
        
    }
    Console.WriteLine("max "+ max);
    Console.WriteLine("min "+ min);
    Console.WriteLine("Разница равна "+ (max-min));
}