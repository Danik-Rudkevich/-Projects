#include <stdio.h>//Для ввода и вывода
#include <malloc.h>//Для динамического выделения памяти
#include <time.h>//Для генерации рандомных чисел

struct Tree//Описываем структуру дерева
{
	int key, data;//объявляем поля 

	struct Tree *Right, *Left, *Last;//Объявляем указатели 

}*root;//Создаем переменную данного типа 

void CheckKey(int a, struct Tree *Node, int *Check)//Функция для проверки уникальности случайно сгенерированного числа для использования его в роли ключа
{
	if (Node == NULL)//Вышли в пустоту
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

void ViewPrimo(struct Tree *Node)//прямой обход
{
	if (Node == NULL)
	{
		return;
	}
	printf("%d\n", Node->data);
	/* обход левого поддерева */
	ViewPrimo(Node->Left);
	/* обход правого поддерева */
	ViewPrimo(Node->Right);
}

void ViewObratno(struct Tree *Node)//Обратный обход
{
	/* если дерево пусто, не выполнять никаких действий – обход дерева завершается
	*/
	if (Node == NULL)
	{
		return;
	}
	/* обход левого поддерева */
	ViewObratno(Node->Left);
	printf("%d\n", Node->data);
	/* обход правого поддерева */
	ViewObratno(Node->Right);
}

void ViewByKey(struct Tree *Node,int key)//Просмотр данных по ключу
{
	if (Node == NULL)
	{
		return;
	}
	if (Node->key==key)//нашли нужный элемент
	{
		printf("\nData=%d\n", Node->data);
	}
	/* обход левого поддерева */
	ViewByKey(Node->Left,key);
	/* обход правого поддерева */
	ViewByKey(Node->Right,key);
}

void Add(time_t t)//В качестве аргумента передается зерно для генерации рандомного числа
{

	int check, key;//Check - для проверки уникальности ключа , key - хранит ключ

	do
	{
		check = 1;//Изначально считаем , что ключ будет уникален , если он окажется не таковым , то функция CheckKey() изменит check на 0 и цикл начнется заново 
		key = rand() % 101 - 50;//Генерируем ключ в диапозоне от -50 до 50
		CheckKey(key, root, &check);//Проверяем ключ
		if (check == 0)
		{
			printf("%d Bad key \n", key);
		}


	} while (check < 1);

	printf("%d Good Key \n", key);

	if (root == NULL)//если корень пустой 
	{
		root = (struct Tree*)malloc(sizeof(struct Tree));//Выделяем память
		root->data = rand() % 101 - 50;//генерируем значение 
		printf("Key = %d add data =%d\n", key, root->data);//Выводим информацию
		root->key = key;//Инициализируем поля , все указатели нулевые так как корень только что создан и никуда не указывает 
		root->Last = NULL;
		root->Left = NULL;
		root->Right = NULL;
	}
	else
	{
		struct Tree *r = root;

		while (r != NULL)//Цикл для поиска подходящего места
		{
			if (r->key > key)//Если наш ключ меньше , то идём на лево
			{
				if (r->Left != NULL)//Если лево не пустое , то перемещаемся на него , если пустое , то создаем элемент 
				{
					r = r->Left;
				}
				else
				{
					r->Left = (struct Tree*)malloc(sizeof(struct Tree));
					r->Left->key = key;
					r->Left->data = rand() % 101 - 50;
					printf("Key = %d add data =%d\n", key, r->Left->data);
					r->Left->Last = r;
					r->Left->Left = r->Left->Right = NULL;
					break;
				}
			}
			else
			{
				if (r->Right != NULL)//Если право не пустое , то перемещаемся на него , если пустое , то создаем элемент 
				{
					r = r->Right;
				}
				else
				{
					r->Right = (struct Tree*)malloc(sizeof(struct Tree));
					r->Right->key = key;
					r->Right->data = rand() % 101 - 50;
					printf("Key = %d add data =%d\n", key, r->Right->data);
					r->Right->Last = r;
					r->Right->Left = r->Right->Right = NULL;
					break;
				}
			}
		}
	}
}

void DellBykey(int key)//Для лучшего понимания того , как правильно удалять элемент дерево с сохранениям баланса , советую посмотреть
{
		struct  Tree *marker;//Указатель на удаляемый элемент

		if (root->key == key && root->Left!=NULL)//Если удаляем корень и слева что то есть 
		{
			marker = root->Left;//Идум на лево
			while (marker->Right!=NULL)//Находим самый правый элемент
			{
				marker = marker->Right;
			}
			if (marker->Left != NULL)//Если слева что то есть , то переустанавливаем указатель last 
			{
				marker->Left->Last = marker->Last;
			}
			marker->Last->Right = marker->Left;//Присоеденяем левое поддерево максимального элемента с его родителем 
			//Меняем данные элемента который хотели удалить , на данные максимального 
			root->key = marker->key;
			root->data = marker->data;
			free(marker);
		}
		else if(root->Left == NULL)//Если слева ничего нет , то просто перескакиваем через удаляемый элемент и удаляем его 
		{
			marker = root;
			root = root->Right;
			root->Last = NULL;
			free(marker);
		}
		else
		{
			marker = root;

			if (key>marker->key)
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
				struct  Tree *Mark2;

				if (marker->Left == NULL)//Если слева что то есть 
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
				while (Mark2->Right != NULL)//Идем к самому правому элементу 
				{
					Mark2 = Mark2->Right;
				}
				Mark2->Last->Left = Mark2->Left;//Отсоеденяем максимальный элемент 
				if (Mark2->Left!=NULL)//Привязываем Last поддерева к родителю отсоеденненого элемента 
				{
					Mark2->Left->Last = Mark2->Last;
				}
				//Меняем данные 
				marker->key = Mark2->key;
				marker->data = Mark2->data;
				free(Mark2);
			}
			else if(key < marker->key)//То же самое , только для левого поддерева
			{
				while (key != marker->key)
				{
					if (key>marker->key)
					{
						marker = marker->Right;
					}
					else
					{
						marker = marker->Left;
					}
				}
				struct  Tree *Mark2;

				if (marker->Left == NULL)
				{
					if (marker->Last->key<marker->key)
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
				while (Mark2->Right != NULL)
				{
					Mark2 = Mark2->Right;
				}
				Mark2->Last->Left = Mark2->Left;
				if (Mark2->Left != NULL)
				{
					Mark2->Left->Last = Mark2->Last;
				}
				marker->key = Mark2->key;
				marker->data = Mark2->data;
				free(Mark2);
			}
		}
	printf("\nElement delite");
}

void DellAll(struct Tree *Node)
{
	if (Node == NULL)
	{
		return;
	}
	/* обход левого поддерева */
	DellAll(Node->Left);
	/* обход правого поддерева */
	DellAll(Node->Right);

	free(Node);//Удаляем элемент к которому пришли 
}

void Ex()
{
	struct Tree *Max = root;
	struct Tree *Min = root;

	while (Min->Left!=NULL)//Идем в самый левый элемент 
	{
		Min = Min->Left;
	}
	while (Max->Right != NULL)//Идем в самый правый элемент
	{
		Max = Max->Right;
	}
	//Меняем содержимое элементов местами 
	int buffer= Max->data;
	Max->data = Min->data;
	Min->data = buffer;
}

int main()
{
	root = NULL;

	//Генерируем зерно для rand 
	time_t t;
	srand((unsigned)time(&t));

	while (1)
	{
		//Создаем менюшку
		int r,inf;
		printf("\n Enter 1 to add item");
		printf("\n Enter 2 to view");
		printf("\n Enter 3 to delete item");
		printf("\n Enter 4 to do the exercise");
		printf("\n Enter 5 to exit\n");

		scanf_s("%d", &r);

		switch (r)
		{
		case 1:
		{
			printf("\nEnter the number of items: ");//Введите кол-во элементов которое надо создать 
			scanf_s("%d", &inf);//ввод
			for (int i = 0; i < inf; i++)
			{
				Add(t);//Добавление
			}
			break;
		}
		case 2:
		{
			printf("\nView-1\n");
			ViewPrimo(root);//Прямой обход
			printf("\nView-2\n");
			ViewObratno(root);//Обратный обход
			printf("\nEnter key:");
			scanf_s("%d", &inf);//ввод
			ViewByKey(root,inf);//Просмотр по ключу
			break;
		}
		case 3:
		{
			printf("\nEnter the item number: ");//Вводим номер элемента который хотим удалить 
			scanf_s("%d", &inf);
			DellBykey(inf);//Удаляем 
			break;
		}
		case 4:
		{
			Ex();//Выполняем задание, для проверки правильного выполнения , просто введи ViewByKey() ключ максимального и минимального ключа , запомни их data , выыбери пункт 4 и при повторном просмотре при помощи ViewByKey() ты увидишь , что их data поменялись местами 
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