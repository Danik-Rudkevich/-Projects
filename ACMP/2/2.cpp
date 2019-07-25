#include <iostream>
#include <fstream>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	
	int N;
	
	std::ofstream fout; 
	fout.open("output.txt"); 
	std::ifstream fin; 
	fin.open("input.txt"); 
	
	fin>>N;
	fin.close();
	
	if(N>0)
	{
		fout<<N*(N+1)/2;
	}
	else if(N<0)
	{
		fout<<( (N*(N-1)/2) )*-1 +1 ;
	}
	else
	{
		fout<<1;
	}
	
}
