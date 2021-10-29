#include <iostream>
#include <fstream>

using namespace std;
ifstream f("bac.txt");

int main()
{
    int n,ok=1,x;
    cin>>n;
    while(f>>x)
        if(x%n==0){
            cout<<x<<" ";
            ok=0;
    }
    if(ok==1)
        cout<<"NU EXISTA";
    return 0;
}
