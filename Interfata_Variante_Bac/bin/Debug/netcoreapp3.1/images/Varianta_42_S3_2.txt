#include <iostream>
#include <fstream>

using namespace std;
ifstream f("BAC.TXT");

int main()
{
    int n,k=1,n1;
    f>>n1;
    while(f>>n){
        if(n1!=n){
            cout<<n1<<" "<<k<<" ";
            k=1;
        }
        else
            k++;
        n1=n;
    }
    cout<<n1<<" "<<k;
    return 0;
}
