#include <iostream>
#include <fstream>

using namespace std;
ifstream f("BAC.TXT");

int main()
{
    int n,n1=998,n2=999;
    while(f>>n)
        if(n==n2){
            n1--;
            n2--;
        }
        else
            if(n==n1)
                n1--;
    cout<<n2<<" "<<n1;
    return 0;
}
