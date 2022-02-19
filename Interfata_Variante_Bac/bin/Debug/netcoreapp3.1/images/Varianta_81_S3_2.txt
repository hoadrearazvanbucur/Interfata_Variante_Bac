#include <iostream>

using namespace std;

int numarare(int n,int m,int a[100],int b[100])
{
    int nr=0,i,bmin=b[0];
    for(int i=1;i<m;i++)
        if(b[i]<bmin)
            bmin=b[i];
    for(int i=0;i<n;i++)
        if(a[i]<bmin)
        nr++;
    return nr;
}

int main()
{
    int a[]={1,2,3};
    int b[]={1,2,4,2,3};
    cout<<numarare(1,4,a,b);
    return 0;
}
