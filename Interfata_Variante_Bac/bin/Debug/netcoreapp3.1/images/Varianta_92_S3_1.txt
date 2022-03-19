#include <iostream>
#include <string.h>

using namespace std;

int main()
{
    char x[101];
    int f1[101],f2[101],fmax;
    cin.getline(x,101);
    for(int i=0;i<strlen(x);i++)
    {

        if(x[i]>='a' && x[i]<='z')

            f1[x[i]]++;
            else
            f2[x[i]]++;

    }
    for(int i=0;i<30;i++)
    {

        if(f1[i]==fmax)
            cout<<(char)f1[i]<<" ";
        else
            if(f2[i]==fmax)
                cout<<(char)f2[i]<<" ";
    }
    cout<<fmax;
    return 0;
}
