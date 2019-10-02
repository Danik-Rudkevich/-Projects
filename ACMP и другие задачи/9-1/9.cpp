#include <iostream>
#include <fstream>
using namespace std;
int main()
{
ifstream fin;
  ofstream fout;
fin.open("input.txt");
  fout.open("output.txt");
  short x,sum,min=9999,maxb,minb;
  
  int max=-9999;
  
 fin>>x;
 short m[x];
for(short i=0;i<x;i++)
{
	fin>>m[i];
if(m[i]>max)
{
max=m[i];
maxb=i;
}

if(m[i]<min)
{
min=m[i];
minb=i;
}
if (m[i]>0)
sum+=m[i];	
}

max=1;
fout<<sum<<" ";
if((minb==maxb) or(minb-1==maxb) or (maxb-1==minb))
{
max=0;	
}
else
{
if(minb<maxb)
{

for(short i=minb+1;i<maxb;i++)	
{

max*=m[i];
}
}
else
{
	if (maxb<minb)
{
for(short i=maxb+1;i<minb;i++)	
{
	max*=m[i];
}	
}	
}	
}
fout<<max;
  fin.close();
  fout.close();


}
