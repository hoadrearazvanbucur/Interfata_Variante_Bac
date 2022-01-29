#include <iostream>

using namespace std;

int main()
{
    int n,m,f1[100],f2[100];
    cin>>n>>m;
    for(int i=1;i<=n;i++)
    {
        int x;
        cin>>x;
        f1[x]++;
    }
    for(int i=1;i<=m;i++)
    {
        int x;
        cin>>x;
        f2[x]++;
    }
    int nrs=0;
    for(int i=0;i<=99;i++)
        if(f1[i])
        if(nrs || f1[i]/f2[i]<nrs)
            nrs=f1[i]/f2[i];
    cout<<nrs;
    return 0;
}
