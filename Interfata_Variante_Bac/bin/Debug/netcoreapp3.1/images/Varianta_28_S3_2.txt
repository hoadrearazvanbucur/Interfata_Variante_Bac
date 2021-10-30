#include <iostream>

using namespace std;

int divizori(int n,int a[])
{
    int d,i,x,y,r;
    d=a[1];
    for(int i=2;i<=n;i++)
    {
        x=d;
        y=a[i];
        while(y)
        {
            r=x%y;
            x=y;
            y=r;
        }
        d=x;
    }
    return d;
}

int main()
{
    int a[]={1,2,3};
    cout<<divizori(1,a);
    return 0;
}
