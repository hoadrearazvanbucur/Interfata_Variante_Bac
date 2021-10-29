#include <iostream>
#include <fstream>

using namespace std;
ifstream f("nr.txt");

int main()
{
    int x[101],n,k=0;
    while(f>>n)
        if(n>0)
            x[k++]=n;
    if(k==0)
        cout<<"NU EXISTA";
    else
        for(int i=0;i<k-1;i++)
            for(int j=i+1;j<k;j++)
                if(x[i]>x[j])
                    swap(x[i],x[j]);
    for(int i=0;i<k;i++)
        cout<<x[i]<<" ";
    return 0;
}
