#include <iostream>

using namespace std;

int main()
{
    int a[100][100],n;
    cin>>n;
    for(int i=0;i<n;i++)
        for(int j=0;j<n;j++)
            if(i+j==n-1)
            a[i][j]=0;
            else
            a[i][j]=n-i;
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<n;j++)
            cout<<a[i][j]<<" ";
        cout<<endl;
    }
    return 0;
}
