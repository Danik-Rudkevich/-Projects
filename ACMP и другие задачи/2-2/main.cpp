#include <iostream>
using namespace  std;
int main(int argc, char** argv) {
	
	int N,kof=1,sum=0;
	
	cout<<"Enter N:";
	cin>>N;
	
	while(N!=1)
	{
		cout<<endl<<"OPERATION";
		if(N%2>0)
		{
			sum+=( (N+1)/2 ) * kof;
			kof*=2;
			N=N/2;
		}
		else
		{
			sum+=( N/2 ) * kof;
			kof*=2;
			N=N/2;
		}
	}
	
	sum+=kof;
	
	cout<<endl<<sum;
}
