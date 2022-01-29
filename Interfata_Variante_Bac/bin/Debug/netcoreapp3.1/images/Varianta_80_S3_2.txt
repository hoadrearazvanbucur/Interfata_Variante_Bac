#include <iostream>

using namespace std;

int divizori(int n)
{
    int s=0,d=2;
    while(n)
    {
        if(n%d==0)
        {
            while(n%d==0)
                n=n/d;
            s=s+d;
        }
        d++;
    }
}

int main()
{
    cout<<divizori(5);
    return 0;
}
