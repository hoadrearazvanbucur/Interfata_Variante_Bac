#include <iostream>

using namespace std;

int numarare(int a,int b)
{
    int nr=0,prim;
    for(int i=a;i<=b;i++)
    {

        prim=1;
        if(i<=1)
            prim=0;
        for(int j=2;j*j<=i && prim;j++)
            if(i%j==0)
            prim=0;
        if(prim)
            nr++;
    }
    return nr;
}

int main()
{
    cout<<numarare(2,8);
    return 0;
}
