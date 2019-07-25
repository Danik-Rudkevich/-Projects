#include <iostream>
#include <fstream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	int N;
	
	std::ofstream fout; 
	fout.open("output.txt"); 
	std::ifstream fin; 
	fin.open("input.txt"); 

    fin >> N;
    fin.close();
    
    fout<<N<<9<<9-N;
    fout.close();
}
