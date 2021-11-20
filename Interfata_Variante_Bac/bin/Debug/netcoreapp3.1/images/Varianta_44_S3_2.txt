#include <iostream>

using namespace std;

int sub(int v[101],int n,int a)
{
    int k=0;
    for(int i=0;i<n;i++)
        if(v[i]<a)
            k++;
    return k;
}

int main()
{
    int v[]={47,183,69,8,134,-56},n=6,a=20;
    for(int i=0;i<n-1;i++)
        if(sub(v,i+2,v[i+1])==sub(v,i+2,v[i]))
           a=0;
    if(a!=0)
        cout<<"DA";
    else
        cout<<"NU";

    return 0;
}
