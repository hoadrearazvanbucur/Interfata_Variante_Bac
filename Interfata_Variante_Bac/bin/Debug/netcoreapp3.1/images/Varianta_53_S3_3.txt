#include <iostream>

using namespace std;

int main()
{
    int n,x[100][100];
    cin>>n;
    for(int i=0;i<n;i++)
        for(int j=0;j<n;j++)
            cin>>x[i][j];

    for(int i=0;i<n;i++){
        for(int j=0;j<n;j++)
            cout<<x[i][j]<<" ";
        cout<<endl;
    }

    for(int i=0;i<n;i++)
        cout<<x[0][i]<<" ";
    for(int i=1;i<n;i++)
        cout<<x[i][n-1]<<" ";
    for(int i=n-2;i>=0;i--)
        cout<<x[n-1][i]<<" ";
    for(int i=n-2;i>=1;i--)
        cout<<x[i][0]<<" ";

    return 0;
}
