#include <iostream>
#include <string.h>

using namespace std;

int main()
{
    char x[21],v[6]={'a','e','i','o','u'};
    cin.get(x,21);
    int ok=0,l=strlen(x);
    for(int i=0;i<l;i++)
    {
        ok=0;
        for(int j=0;j<strlen(v);j++)
            if(x[i]==v[j])
                ok=1;
        if(ok==1)
        {
            l++;
            for(int j=l;j>=i+1;j--)
                x[j]=x[j-1];
            x[i+1]=x[i]-32;
        }
    }
    for(int i=0;i<l;i++)
        cout<<x[i];
    return 0;
}
