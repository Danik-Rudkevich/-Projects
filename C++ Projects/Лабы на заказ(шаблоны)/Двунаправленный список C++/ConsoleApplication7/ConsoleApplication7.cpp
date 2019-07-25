#include "pch.h" 
#include <iostream> 
using namespace std;

struct Spisok2 {
	int info;
	Spisok2 *next, *prev;
}*head,*endList;//Сразу объявляем 2 указателя типа Spisok 2 


void dob_nat(int in) //Добавляем вначале
{
	if (head==nullptr)//Создаем наш список если функция применяется впервые 
	{
		head = new Spisok2;
		head->info = in;
		head->prev = nullptr;
		head->next = nullptr;
		endList = head;
		return;
	}

	head->prev = new Spisok2;//Создаем новый элемент 
	head->prev->next = head;//Устанавливаем путь для нового head 
	head = head->prev;//Меняем head

	//Заполняем 
	head->info = in;
	head->prev = nullptr;


	/*while (head->next!=nullptr)//Можно использовать цикл чтоюы дойти до конца , но зачем ? У нас же есть переменная end которая хранит конец и head которая хранит начало
	{
		t = t->next;
	}*/

}
void dob_kon(int in) //Добавление в конец
{
	if (endList == nullptr)//Создаем наш список если функция применяется впервые 
	{
		head = new Spisok2;
		head->info = in;
		head->prev = nullptr;
		head->next = nullptr;
		endList = head;
		return;
	}

	endList->next = new Spisok2;//Создаем новый элемент 
	endList->next->prev = endList;//Устанавливаем путь для нового end
	endList = endList->next;//Меняем head

	//Заполняем 
	endList->info = in;
	endList->next = nullptr;


	/*while ()//Можно использовать цикл чтоюы дойти до конца , но зачем ? У нас же есть переменная end которая хранит конец и head которая хранит начало
	{
		t = t->next;
	}*/
}
void lis_nat()//Просмотр сначала
{
	if (endList==nullptr || head==nullptr)
	{
		cout << "Список ещё не создан";
		return;
	}

	Spisok2 *t = head;

	cout << t->info << " ";

	while (t->next!=nullptr)
	{
		t = t->next;
		cout << t->info << " ";
	}
}
void lis_kon() {
	if (endList == nullptr || head == nullptr)
	{
		cout << "Список ещё не создан";
		return;
	}

	Spisok2 *t = endList;

	cout << t->info << " ";

	while (t->prev != nullptr)
	{
		t = t->prev;
		cout << t->info << " ";
	}
}

void del() 
{

	if (endList == nullptr || head == nullptr)
	{
		cout << "Список ещё не создан";
		return;
	}

	Spisok2 *t = head;

	while (t!=nullptr)
	{
		if (t->info%10==5)
		{
			if (t==head)//Проверяем не голову ли мы хотим удалить
			{
				head = t->next;//Делаем следуещий элемент головой
				head->prev = nullptr;//Обрываем связь с прошлым элементом
				delete t;//Удаляем ненужный элемент
				t = head;//Даем t новое значение , чтобы цикл не остановился
			}

			else if (t == endList)//Проверяем не задницу ли мы хотим удалить
			{
				endList = t->prev;//Тут можно и оптимизировать , ведь мы впринципе уже в конце , можно просто удалить и забыть
				endList->next = nullptr;
				delete t;
				t = endList;
			}

			else
			{
				t->prev->next = t->next;//Обрываем связь с левым и связываем его с правым
				t->next->prev = t->prev;//Обрываем связь с правым и связываем его с левым
				Spisok2 *del = t;
				t = t->next;//Идём на следующий элемент чтобы не останавливать цикл
				delete del;
				
			}
		}
		else
		{
			t = t->next;
		}
	}

}

int main()
{
	setlocale(LC_ALL, "Rus");

	Spisok2 list;//Создаем наш список

	//Так как он только создан , он никуда не указывает
	head = nullptr;//Для указания пустоты указателя лучше использовать nullptr вместо Null , так как Null в Си = 0 и у него тип int , а это памяти занимает больше и с null иногда бывают проблемы которые потом трудно обнаружить
	endList = nullptr;

	while (true) {
		int r;
		cout << "1 Введите для cоздания списка" << endl;
		cout << "2 Введите для добавление элемента в Список" << endl;
		cout << "3 Введите для просмотра Списка" << endl;
		cout << "4 Для удаления элементов списка заканчивающихся на 5" << endl;
		cin >> r;
		switch (r)
		{
		case 1: {
			//Я вверху список создал при запуске программы 
			break; }
		case 2: {
			int f;
			cout << "1 В начало" << endl;
			cout << "2 В конец" << endl;
			cin >> f;
			if (f == 1) {
				int i;
				cout << "Введите значение элемента" << endl;
				cin >> i;
				dob_nat(i);
			}
			else if (f == 2) {
				int i;
				cout << "Введите значение элемента" << endl;
				cin >> i;
				dob_kon(i);
			}
			else cout << "Ошибка! Вводить можно только 1 или 2" << endl;

			break; }
		case 3: {
			int f;
			cout << "1 С начала" << endl;
			cout << "2 С конца" << endl;
			cin >> f;
			if (f == 1) {
				lis_nat();
				cout << endl;
			}
			else if (f == 2) {
				lis_kon();
				cout << endl;
			}
			else cout << "Ошибка! Вводить можно только 1 или 2\n";
			break;
		}
		case 4:
			del();
			break;

		}

	}
}