#include <iostream>
#include <fstream>
using namespace std;
int main() {
	ifstream ifs;
	ofstream ofs;
	
	ifs.open("input.txt");
	ofs.open("output.txt");
	
	int a,b,c,d;
	
	ifs>>a;
	ifs>>b;
	ifs>>c;
	ifs>>d;
	
	for(short i=-100;i<101;i++)
	{
		if( (a*i*i*i + b*i*i + c*i + d) == 0)
		{
			ofs<<i<<" ";
		}	
	}
	
}
