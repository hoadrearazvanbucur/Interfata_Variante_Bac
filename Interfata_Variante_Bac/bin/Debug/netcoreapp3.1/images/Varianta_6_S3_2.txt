#include <iostream>

using namespace std;

int main()
{
    int n,x[100],s=0;
    cin>>n;
    for(int i=0;i<n;i++){
        cin>>x[i];
        s+=x[i];
    }
    cout<<s<<endl;
    for(int i=1;i<n-1;i++){
        s=0;
        for(int j=0;j<n-i;j++)
            s+=x[j];
        cout<<s<<endl;
    }
    cout<<x[0];

    return 0;
}
