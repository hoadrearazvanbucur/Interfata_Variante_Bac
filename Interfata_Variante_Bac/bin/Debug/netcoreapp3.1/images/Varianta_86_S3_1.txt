#include <iostream>
#include <string.h>
using namespace std;

int main()
{
    char x[100],xs[100];
    int maxim=0,k=0;
    cin.getline(x,100);
    for(int i=0;i<strlen(x);i++)
    {
        k=0;
        if(x[i]=='#')
            strcpy(xs," ");
        else
            if(x[i]!='#')
        {

            xs[k++]=x[i];
            if(maxim<k)
                maxim=k;
        }
    }
    cout<<maxim;
    return 0;
}
