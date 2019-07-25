#include <iostream>
#include <fstream>

using namespace std;

int main() {
	
	ifstream fst;
	ofstream ofst;
	
	string text;

	fst.open("input.txt");
	
	ofst.open("output.txt");
	
	fst>>text;
	
	if(text.length() == 5) 
	{
		if(text[2] == '-' && text[0]>64 && text[0]<73 && text[1]>48 && text[1]<57 && text[3]>64 && text[3]<73 && text[4]>48 && text[4]<57)//A-H = 65-72; 1-8 49-56;
		{
			if  
				(
					( int(text[0])==(int(text[3])+1) || int(text[0])==(int(text[3])-1) ) && (int(text[1])==(int(text[4])+2) || int(text[1])==(int(text[4])-2) ) || //Проверка верх и низ
					( int(text[0])==(int(text[3])+2) || int(text[0])==(int(text[3])-2) ) && (int(text[1])==(int(text[4])+1) || int(text[1])==(int(text[4])-1) )//Проверка права и лева	   
				)
			{
				ofst<<"YES";		
			}
			else
			{
				ofst<<"NO";		
			}
		}
		else
		{
			ofst<<"ERROR";	
		}
	}
	else
	{
		ofst<<"ERROR";
	}
	
	fst.close();
	ofst.close();
	
}
