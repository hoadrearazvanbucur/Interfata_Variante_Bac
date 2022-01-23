#include <iostream>

using namespace std;

void f(int n,int &a,int &b)
{
    a=0;
    b=0;
    for(int i=n-1;i>=1;i--){
        int ok=0;
        for(int j=2;j<=i/2;j++)
            if(i%j==0)
                ok=1;
            if(!a && ok==0)
                a=i;
            else
                if(!b && ok==0)
                    b=i;
    }
}

int main()
{
    int a,b;
    f(28,a,b);
    cout<<a<<" "<<b;
    return 0;
}
