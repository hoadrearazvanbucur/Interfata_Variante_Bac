#include <iostream>

using namespace std;

int main()
{
    int n,m,A[11][11];
    cin>>n>>m;
    for(int i=1;i<=n;i++)
        for(int j=1;j<=m;j++)
            if(i>j) A[i][j]=j;
                else A[i][j]=i;

    for(int i=1;i<=n;i++){
        for(int j=1;j<=m;j++)
             cout<<A[i][j]<<" ";
        cout<<endl;
    }
    return 0;
}
