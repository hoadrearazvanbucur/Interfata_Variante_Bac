#include <iostream>

using namespace std;

int main()
{
    int n,p,x[100][100],k=0;
    cin>>n>>p;
    for(int i=0;i<n;i++)
        for(int j=0;j<p;j++){
            while((k*k)%2!=0)
                k++;
            x[i][j]=k*k;
        k++;
        }

    for(int i=0;i<n;i++){
        for(int j=0;j<p;j++)
            cout<<x[i][j]<<" ";
        cout<<endl;
    }
    return 0;
}
