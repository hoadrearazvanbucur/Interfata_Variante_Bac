#include <iostream>
#include <string.h>
using namespace std;

int main()
{
    char x[255];
    cin.getline(x,255);
    x[0]-=32;
    for(int i=2;i<strlen(x);i++)
        if(x[i-1]==' ' && x[i]<='z' && x[i]>='a')
            x[i]-=32;
    cout<<x;
    return 0;
}
