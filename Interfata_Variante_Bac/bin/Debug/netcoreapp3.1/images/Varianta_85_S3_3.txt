#include <iostream>

using namespace std;

int f(int a)
{
    int k=1,s=0,e=0;
    while(a!=1){
        k++; e=0;
        while(a%k==0){
            e++;
            a/=k;
        }
        s+=e;
    }
    return s;
}

int main()
{
    int n;
    cin>>n;
    if(n/10==0 && f(n)==1)
        cout<<"DA";
    else
        if(n/100==0 && f(n)==1 && f(n%10*10+n/10)==1)
            cout<<"DA";
        else
            if(n/1000==0 && f(n)==1 && f(n%10*100+n/100*10+n/10%10)==1 && f(n/10%10*100+n%10*10+n/100)==1)
                cout<<"DA";
        else
            cout<<"NU";
    return 0;
}
