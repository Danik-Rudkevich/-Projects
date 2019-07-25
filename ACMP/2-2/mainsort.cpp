
#include <iostream>
#include <cstdlib>
#include <ctime>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

void quickSort(int *mass, int left, int right)
{
  int pivot; 
  int l = left;
  int r = right;
  pivot = mass[left];
  while (left < right) 
  {
    while ((mass[right] >= pivot) && (left < right))
      right--; 
    if (left != right)
    {
      mass[left] = mass[right]; 
      left++;
    }
    while ((mass[left] <= pivot) && (left < right))
      left++; 
    if (left != right)
    {
      mass[right] = mass[left]; 
      right--;
    }
  }
  
  mass[left] = pivot;
  pivot = left;
  left = l;
  right = r;
  
  if (left < pivot) 
    quickSort(mass, left, pivot - 1);
  if (right > pivot)
    quickSort(mass, pivot + 1, right);
}

int main(int argc, char** argv) {
    int N;
    srand( time(0) );
    N = rand()%50+3;
    
    int *mass = new int[N];
    
    for(int i=0;i<N;i++)
    {
    	mass[i]= rand()%100;
	}
	
	for(int i=0;i<N;i++)
	{
		cout<<mass[i]<<" ";
	}
	
	cout<<endl<<endl;
	
	quickSort(mass,0,N-1);
	
	cout<<"New:";
	
	for(int i=0;i<N;i++)
	{
		cout<<mass[i]<<" ";
	}
	
}
