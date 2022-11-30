Console.WriteLine("Введите количество элементов в массиве.");
int col=Convert.ToInt32(Console.ReadLine());
int [] mas=new int [col];
int cout=0;
Colraze(mas,col,cout);

//Функция заполнения массива и подсчёта чётных чисел
void Colraze(int []m, int c, int r)
{
    Random ran=new Random();
    for(int i=0;i<c;i++)
    {
        m[i]=ran.Next(100,999);
        Console.WriteLine(m[i]);
        if(m[i]%2==0)
        {
            r++;
        }
    }
    Console.WriteLine("Количество чётных чисел "+ r);
}