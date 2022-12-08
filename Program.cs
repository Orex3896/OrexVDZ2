/*int DifOst(int num)
{
    int delEndNum = num/10;
    int delFirstNum = delEndNum%10;
    int result= delFirstNum;
    return(result);
} 
Console.WriteLine("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine() );
//int a = new Random().Next(100,999) ;
int res = DifOst(a);
Console.WriteLine(a);
Console.WriteLine(res);
*/

/*
int Dif(int num)
{
    while(num>100)
    {
        num = num/10;
        int res=num%100;
        return(res);
    }
    
 //   int A = num%1000;
   // return A;
}
Console.WriteLine("Введите трехзначное число ");
int b = Convert.ToInt32(Console.ReadLine() );
int res = Dif(b);
Console.WriteLine(res);

*/

int Diff(int num)//Не смог понять как вывести третью цифру если число <100
{
    /*if(num>0.001)
    {
        num=num/10;
        
        Console.WriteLine(num);
    }
    double ostmin=num%10;
    return (ostmin);*/
    
    /*if(num<100)
    {   
        while(num<100){
                      Console.WriteLine("третьей цифры нет");
                      break;}
    }*/
    while(num>1000)
    {
        num=num/10;
        
        Console.WriteLine(num);
    }
    int ost= num%10; 
    return(ost);
    
    
}
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<100)
{
    Console.WriteLine("число меньше 100");
}
else {int result= Diff(n);
Console.WriteLine($"из числа {n} третье число будет {result}");}