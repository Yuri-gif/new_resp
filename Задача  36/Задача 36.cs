Console.WriteLine("Введите количество элементов в массиве.");
int col=Convert.ToInt32(Console.ReadLine());
int [] mas=new int [col];
int cout=0;
Colraze(mas,col,cout);

//Функция заполнения массива и подсчёта чётных чисел
void Colraze(int [] m, int c, int r)
{
    Random ran=new Random();
    for(int i=0;i<c;i++)
    {
        m[i]=ran.Next(10,100);
        Console.WriteLine(m[i]);
        if(i%2!=0)
        {
            r+=m[i];
        }
        
    }
    Console.WriteLine("Сумма "+ r);
}