#include <iostream>
#include <cstring>

using namespace std;

int main()
{
    char s[101],aux[201];
    cin>>s;
    for(int i=1;i<=strlen(s);i++)
    {
        strcpy(aux,s);
        aux[i]='\0';
        strcat(aux,s+strlen(s)-i);
        cout<<aux<<" ";
    }
    return 0;
}
