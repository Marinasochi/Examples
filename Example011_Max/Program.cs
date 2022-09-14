int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}
int a1=5; 
int b1=78;
int c1=63;
int a2=-6;
int b2=985;
int c2=999;
int a3=8;
int b3=0;
int c3=166;
int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);


