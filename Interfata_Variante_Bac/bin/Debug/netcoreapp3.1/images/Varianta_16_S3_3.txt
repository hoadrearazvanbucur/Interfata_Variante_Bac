#include <iostream>

using namespace std;

int main()
{
    int x,p,a;
    cin>>p>>x;
    while(x)
    {
        if((x-p*(p+1)))
        {
            a=(x-p*(p+1)/2)/p;
            cout<<a+1<<" ";
        }
        else
            cout<<"Nu"<<" ";
    }
    return 0;
}
