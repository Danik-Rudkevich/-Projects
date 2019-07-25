#include "pch.h"
#include <iostream>
#include <string>
#include <time.h>//Для генерации рандомных чисел

using namespace std;

struct Tree//Описываем структуру дерева
{
	int key;
	string data;//объявляем поля 

	Tree *Right, *Left, *Last;//Объявляем указатели 

}*root;//Создаем переменную данного типа 

void CheckKey(int a, Tree *Node, int *Check)//Функция для проверки уникальности случайно сгенерированного числа для использования его в роли ключа
{
	if (Node == nullptr)//Вышли в пустоту
	{
		return;
	}
	if (Node->key == a)//Нашли объект с таким ключом , значит он нам не подходит 
	{
		*Check = 0;
		return;
	}
	/* обход левого поддерева */
	CheckKey(a, Node->Left, Check);
	/* обход правого поддерева */
	CheckKey(a, Node->Right, Check);
}

void ViewPrimo(Tree *Node)//прямой обход
{
	if (Node == nullptr)
	{
		return;
	}
	cout << "\nData=" << Node->data << "\n";
	/* обход левого поддерева */
	ViewPrimo(Node->Left);
	/* обход правого поддерева */
	ViewPrimo(Node->Right);
}

void ViewObratno(Tree *Node)//Обратный обход
{
	/* если дерево пусто, не выполнять никаких действий – обход дерева завершается
	*/
	if (Node == nullptr)
	{
		return;
	}
	/* обход левого поддерева */
	ViewObratno(Node->Left);
	cout << "\nData=" << Node->data << "\n";
	/* обход правого поддерева */
	ViewObratno(Node->Right);
}

void ViewByKey(Tree *Node, int key)//Просмотр данных по ключу
{
	if (Node == nullptr)
	{
		return;
	}
	if (Node->key == key)//нашли нужный элемент
	{
		cout << "\nData="<<Node->data<<"\n";
	}
	/* обход левого поддерева */
	ViewByKey(Node->Left, key);
	/* обход правого поддерева */
	ViewByKey(Node->Right, key);
}

void Add(time_t t)//В качестве аргумента передается зерно для генерации рандомного числа
{

	int check, key;//Check - для проверки уникальности ключа , key - хранит ключ
	string buffer;
	do
	{
		check = 1;//Изначально считаем , что ключ будет уникален , если он окажется не таковым , то функция CheckKey() изменит check на 0 и цикл начнется заново 
		key = rand() % 101 - 50;//Генерируем ключ в диапозоне от -50 до 50
		CheckKey(key, root, &check);//Проверяем ключ
		if (check == 0)
		{
			cout << "\nBad key "<<key<<"\n";
		}


	} while (check < 1);

	cout << "\nGood Key " << key << "\n";

	if (root == nullptr)//если корень пустой 
	{
		root = new Tree();//Выделяем память
		getchar();
		cout << "\nEnter Data = ";
		getline(cin,buffer);
		root->data = buffer;
		cout << "\nKey =" << key << " add data = " << buffer;//Выводим информацию
		root->key = key;//Инициализируем поля , все указатели нулевые так как корень только что создан и никуда не указывает 
		root->Last = nullptr;
		root->Left = nullptr;
		root->Right = nullptr;
	}
	else
	{
		Tree *r = root;

		while (r != nullptr)//Цикл для поиска подходящего места
		{
			if (r->key > key)//Если наш ключ меньше , то идём на лево
			{
				if (r->Left != nullptr)//Если лево не пустое , то перемещаемся на него , если пустое , то создаем элемент 
				{
					r = r->Left;
				}
				else
				{
					r->Left = new Tree();
					r->Left->key = key;
					cout << "\nEnter Data = ";
					getline(cin, buffer);
					r->Left->data = buffer;
					cout << "\nKey =" << key << " add data = " << buffer;//Выводим информацию
					r->Left->Last = r;
					r->Left->Left = r->Left->Right = nullptr;
					break;
				}
			}
			else
			{
				if (r->Right != nullptr)//Если право не пустое , то перемещаемся на него , если пустое , то создаем элемент 
				{
					r = r->Right;
				}
				else
				{
					r->Right = new Tree();
					r->Right->key = key;
					cout << "\nEnter Data = ";
					getline(cin, buffer);
					r->Right->data = buffer;
					cout << "\nKey =" << key << " add data = " << buffer;//Выводим информацию
					r->Right->Last = r;
					r->Right->Left = r->Right->Right = nullptr;
					break;
				}
			}
		}
	}
}

void DellBykey(int key)//Для лучшего понимания того , как правильно удалять элемент дерево с сохранениям баланса , советую посмотреть
{
	 Tree *marker;//Указатель на удаляемый элемент

	if (root->key == key && root->Left != nullptr)//Если удаляем корень и слева что то есть 
	{
		marker = root->Left;//Идум на лево
		while (marker->Right != nullptr)//Находим самый правый элемент
		{
			marker = marker->Right;
		}
		if (marker->Left != nullptr)//Если слева что то есть , то переустанавливаем указатель last 
		{
			marker->Left->Last = marker->Last;
		}
		marker->Last->Right = marker->Left;//Присоеденяем левое поддерево максимального элемента с его родителем 
		//Меняем данные элемента который хотели удалить , на данные максимального 
		root->key = marker->key;
		root->data = marker->data;
		free(marker);
	}
	else if (root->Left == nullptr)//Если слева ничего нет , то просто перескакиваем через удаляемый элемент и удаляем его 
	{
		marker = root;
		root = root->Right;
		root->Last = nullptr;
		free(marker);
	}
	else
	{
		marker = root;

		if (key > marker->key)
		{
			while (key != marker->key)//Ищем наш ключ 
			{
				//Логика такая же как и при добавлении элемента 
				if (key > marker->key)
				{
					marker = marker->Right;
				}
				else
				{
					marker = marker->Left;
				}
			}
			 Tree *Mark2;

			if (marker->Left == nullptr)//Если слева что то есть 
			{
				//привязываем поддеревья в зависимости от ключа 
				if (marker->Last->key < marker->key)//Если  ключ родителя меньше ключа маркера , то привязываем правое поддерево маркера справа от родителя else слева от родителя 
				{
					marker->Last->Right = marker->Right;
				}
				else
				{
					marker->Last->Left = marker->Right;
				}
				free(marker);
				return;
			}

			Mark2 = marker->Left;
			while (Mark2->Right != nullptr)//Идем к самому правому элементу 
			{
				Mark2 = Mark2->Right;
			}
			Mark2->Last->Left = Mark2->Left;//Отсоеденяем максимальный элемент 
			if (Mark2->Left != nullptr)//Привязываем Last поддерева к родителю отсоеденненого элемента 
			{
				Mark2->Left->Last = Mark2->Last;
			}
			//Меняем данные 
			marker->key = Mark2->key;
			marker->data = Mark2->data;
			free(Mark2);
		}
		else if (key < marker->key)//То же самое , только для левого поддерева
		{
			while (key != marker->key)
			{
				if (key > marker->key)
				{
					marker = marker->Right;
				}
				else
				{
					marker = marker->Left;
				}
			}
			 Tree *Mark2;

			if (marker->Left == nullptr)
			{
				if (marker->Last->key < marker->key)
				{
					marker->Last->Right = marker->Right;
				}
				else
				{
					marker->Last->Left = marker->Right;
				}

				free(marker);
				return;
			}

			Mark2 = marker->Left;
			while (Mark2->Right != nullptr)
			{
				Mark2 = Mark2->Right;
			}
			Mark2->Last->Left = Mark2->Left;
			if (Mark2->Left != nullptr)
			{
				Mark2->Left->Last = Mark2->Last;
			}
			marker->key = Mark2->key;
			marker->data = Mark2->data;
			free(Mark2);
		}
	}
	cout<<"\nElement delite";
}

void DellAll(Tree *Node)
{
	if (Node == nullptr)
	{
		return;
	}
	/* обход левого поддерева */
	DellAll(Node->Left);
	/* обход правого поддерева */
	DellAll(Node->Right);

	free(Node);//Удаляем элемент к которому пришли 
}

void Ex(Tree *Node,char a,int &kol)//Передаем адрес узла , символ с которым будем сравнивать и адрес на счетчик кол-ва записей удовлетворяющих условию
{
	if (Node == nullptr)//Если узел пустой , то выходим
	{
		return;
	}
	if (Node->data[0]==a)//если содержимое узла удовлетворяет условию задачи , то увеличиваем счетчик
	{
		kol++;
	}
	/* обход левого поддерева */
	Ex(Node->Left,a,kol);
	/* обход правого поддерева */
	Ex(Node->Right,a, kol);
}

int main()
{
	root = nullptr;

	//Генерируем зерно для rand 
	time_t t;
	srand((unsigned)time(&t));

	while (1)
	{
		//Создаем менюшку
		int r, inf;
		cout<<"\n Enter 1 to add item";
		cout << "\n Enter 2 to view";
		cout << "\n Enter 3 to delete item";
		cout << "\n Enter 4 to do the exercise";
		cout << "\n Enter 5 to exit\n";

		cin>>r;

		switch (r)
		{
		case 1:
		{
			cout << "\nEnter the number of items: ";//Введите кол-во элементов которое надо создать 
			cin >> inf;//ввод
			for (int i = 0; i < inf; i++)
			{
				Add(t);//Добавление
			}
			break;
		}
		case 2:
		{
			cout << "\nView-1\n";
			ViewPrimo(root);//Прямой обход
			cout << "\nView-2\n";
			ViewObratno(root);//Обратный обход
			cout << "\nEnter key:";
			cin>>inf;//ввод
			ViewByKey(root, inf);//Просмотр по ключу
			break;
		}
		case 3:
		{
			cout << "\nEnter the item number: ";//Вводим номер элемента который хотим удалить 
			cin>>inf;
			DellBykey(inf);//Удаляем 
			break;
		}
		case 4:
		{
			int kol=0;
			char a;
			cout << "\nEnter letter :"; cin >> a;
			Ex(root,a,kol);//Выполняем задание
			cout << "\nKol=" << kol<<endl;
			break;
		}
		case 5:
		{
			DellAll(root);//Удаляем дерево 
			exit(0);//Выход
			break;
		}

		}
	}
	return 0;
}