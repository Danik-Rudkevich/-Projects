#include <fstream>
#include <iostream>
using namespace std;
int main()
{
ifstream fin("input.txt");
ofstream fout("output.txt");


short ch=0,nech=0; //������� ���-�� ������ � 

short N,buffer;

fin>>N;

for(short i=0;i<N;i++)
{
	fin>>buffer;
	if(buffer % 2 != 0)
	{
		nech++;
		fout<<buffer<<" ";
	}
}

fin.seekg(0, std::ios::beg);//������� ������� � ������ �����

fin>>N;

fout<<endl;

for(short i=0;i<N;i++)
{
	fin>>buffer;
	if(buffer % 2 == 0)
	{
		ch++;
		fout<<buffer<<" ";
	}
}

fout<<endl;

if(nech==ch)
{
	fout<<"YES";
}
else if(nech>ch)
{
	fout<<"NO";
}
else
{
	fout<<"YES";
}

fin.close();
fout.close();

}
