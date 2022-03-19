#include <iostream>

using namespace std;

int main()
{
    int x,y,lg,lgmax,pc;
    cin>>x;
    lg=1;
    while(x)
    {
        pc=y;
        while(pc>9)
            pc=pc/10;
        if(pc==x%10)
            lg++;
        else{
            if(lg>lgmax)
                lgmax=lg;
            lg=1;
        }
        x=y;
        cin>>x;
    }
    cout<<lgmax;
    return 0;
}
