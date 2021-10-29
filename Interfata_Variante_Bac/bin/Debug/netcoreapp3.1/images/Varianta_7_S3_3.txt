#include <iostream>

using namespace std;

int f(int n)
{
    if(n<=5)
        return n;
    else
        return 2*(n-1);
}
int sum(int n)
{
    int c=0;
    while(f(c)<=n)
        c++;
    return f(c-1);
}
int main()
{
    int s;
    cin>>s;
    while(s){
        cout<<sum(s)<<" ";
        s-=sum(s);
    }
    return 0;
}
