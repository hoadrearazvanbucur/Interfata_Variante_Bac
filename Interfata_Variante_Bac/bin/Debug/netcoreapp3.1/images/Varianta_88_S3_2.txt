#include <iostream>

using namespace std;

void numar(int n,int &m)
{
    int v[11]={0},k,i,j;
    k=0;
    while(n)
    {
        if(n%2==1)
        {
            k++;
            v[k]=n%10;
        }
        n=n/10;
    }
    for(int i=1;i<k;i++)
        for(int j=i+1;j<=k;j++)
        if(v[i]<v[j])
        swap(v[i],v[j]);
    m=m*v[1]*v[0]+1;
}

int main()
{
    int m;
    numar(123,m);
    cout<<m;
    return 0;
}
