#include <iostream>

using namespace std;

int main()
{
    int n,x[100],a,b;
    cin>>n;
    for(int i=0;i<n*3;i++)
        cin>>x[i];

    for(int i=0;i<n;i++)
    if(x[i]%2==0){
        a=i;
        break;
    }
    for(int i=n*3-1;i>=n*2+1;i--)
    if(x[i]%2==1){
        b=i;
        break;
    }
    swap(x[a],x[b]);

    for(int i=0;i<n*3;i++)
        cout<<x[i]<<" ";
    return 0;
}
