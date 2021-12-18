#include <iostream>

using namespace std;

int main()
{
    int a[52][51],n,i,j,k;
    cin>>n;
    for(int i=1;i<=n;i++)
    {
        for(int j=1;j<=n;j++)
            cin>>a[i][j];
    }
    k=n/2+1;
    for(int i=k;i<n;i++)
        for(int j=1;k<=n;j++)
        a[i][j]=a[i+1][j];
    for(int j=k;j<=n;j++)
        a[i][j]=a[i+1][j];
    cout<<a[1][1];
    return 0;
}
