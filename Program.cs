#include <iostream>

using namespace std;
void showchoice(char in);
int add (int a,int b);
int subtract (int a,int b);
int multiply(int a,int b);
float division (float c,float d);
int main()
{
    int a,b;float c,d;
    int z;
    char in;
    showchoice(in);
    switch (in)
    {
    case  '+':
        cout<<"The result = "<<add(a,b)<<endl;
        break;
    case  '-':
        cout<<"The result = "<<subtract (a,b)<<endl;
        break;
    case '*':
        cout<<"The result = "<<multiply (a,b)<<endl;
        break;
    case '%':
        cout<<"The result = "<<division (c,d)<<endl;
        break;

    }

    return 0;
}
void showchoice(char in)
{
    cout<<"Please Enter + for sum , - for subtraction , % for division , * for multiplication \n";
    cin>>in;
}
int add (int a,int b)
{
    cout<<"Please Enter 2 numbers to sum \n";
    cin>>a>>b;
    return a+b;
}
int subtract (int a,int b)
{
    cout<<"Please Enter 2 numbers to subtract \n";
    cin>>a>>b;
    return a-b;
}
int multiply(int a,int b)
{
    cout<<"Please Enter 2 numbers to multiply \n";
    cin>>a>>b;
    return a*b;
}
float division (float c,float d)
{
    cout<<"Please Enter 2 numbers to divide \n";
    cin>>c>>d;
    return c/d;
}