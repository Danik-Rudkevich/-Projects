// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{

	int bottleKol, mouses=0,badBottle,foundBadBottle=0,i;

	cout << "Enter number of bottles ";
	cin >> bottleKol;

	for (i=0;i<32;i++)
	{
		if (bottleKol >> i)
			mouses++;
	}

	cout << endl << "You need to take " << mouses <<" mouses"<<endl;	

	while (true)
	{
		cout << endl << "Enter number of badBottle ";
		cin >> badBottle;
		cout << endl;

		if (badBottle> bottleKol)
		{
			cout << endl <<endl << "You went beyond the number of bottles"<<endl;
			continue;
		}

		break;
	}

	i = 0;

	while (badBottle >> i)
	{
		if (badBottle>>i &1)
		{
			cout << endl << "Mouse number " << i << " died!"<<endl;
			foundBadBottle |= (1 << i);
		}
		else
		{
			foundBadBottle |= (0 << i);
		}
		i++;
	}

	cout << endl << "Bad bottle has number " << foundBadBottle;
}
