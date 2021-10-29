#include <iostream>

using namespace std;

int main()
{
        int s=0,a[4]={10,2,3,11},n=4;
    for(int j=0;j<n/2;j++){
        if(a[j]>0)
            s+=a[j];
        if(a[n/2+j]>0)
            s+=a[n/2+j];
        s%=10;
    }
    cout<<s;
    return 0;
}
