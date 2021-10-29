#include <iostream>

using namespace std;

void sub(int n,int m,int a[5],int b[3])
{
    int i=0,j=0,c[8],k=0;
    while(i<n && j<m){
        if(a[i]<b[j])
            if(c[k-1]%2!=a[i]%2)
                c[k++]=a[i++];
            else
                i++;
        if(a[i]>b[j])
            if(c[k-1]%2!=b[j]%2)
                c[k++]=b[j++];
            else
                j++;
    }
    while(i<n)
        if(c[k-1]%2!=a[i]%2)
            c[k++]=a[i++];
            else
                i++;
    while(j<m)
        if(c[k-1]%2!=b[j]%2)
            c[k++]=b[j++];
            else
                j++;
    for(int i=0;i<k;i++)
        cout<<c[i]<<" ";
}

int main()
{
    int n=5,m=3,a[5]={2,4,8,10,14},b[3]={3,5,11};
    sub(n,m,a,b);
    return 0;
}
