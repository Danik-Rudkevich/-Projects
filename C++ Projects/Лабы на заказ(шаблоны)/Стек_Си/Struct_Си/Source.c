#include <stdio.h>//Для ввода и вывода
#include <malloc.h>//Для динамического выделения памяти
#include <time.h>//Для генерации рандомных чисел

struct Stek//Создаем структуру с названием Stek в которой 2 поля , info отвечает за число , next - указатель на следующий элемент
{
	int info;
	struct Stek *next;
}*head; //Сразу создаем указатель head типа Stek в котором будет хранится адрес начала стека

void push(int in) //Добавляем элемент
{
	if (head == NULL)//Добавляем адрес первого элемента
	{
		head = (struct Stek*)malloc(sizeof(struct Stek));//Выделяем память элементу  
		head->info = in;//Заполняем поле info элемента
		head->next = NULL;//Первый элемент стека никуда не указывает
		return;
	}

	struct Stek *bufer = head;//Создаем переменную которая будет хранить адрес начала стека , чтобы передать его в поле next для нового элемента который займет его место

	head = (struct Stek*)malloc(sizeof(struct Stek));//Выделяем память для нового элемента и помещаем его в начало

	head->next = bufer;//Передаем адрес бывшего начала стека
	head->info = in;//Заполняем поле info в новом элементе

}
void View()//Просмотр стека
{
	if (head == NULL)//Если head ни на что не указывает , значит стек пуст
	{
		printf("Стек пуст\n");//Вывод 
		return;//Выходим из функции View()
	}

	struct Stek *t = head;//Создаем переменную для прохождения по элементам стека

	printf("%d ",t->info);//Вывод значения первого элемента стека

	while (t->next != NULL)//Пока стек указывает куда то , то идем по нему
	{
		t = t->next;//Переходим к следующему элементу
		printf("%d ", t->info);//Вывод значения элемента к которому перешли
	}
}
void del(int num) //Удаление элемента по его номеру
{
	if (num == 0)//Удаляем начало
	{
		struct Stek *bufer = head;//Создаем указатель на элемент который будем удалять 
		head = head->next;//Даем стеку новое начало
		free(bufer);//Удаляем выбранный элемент
	}
	else
	{
		struct Stek *previous = head;//Создаем указатель при помощи которого мы доберемся до элемента который надо удалить

		for (int i = 0; i < num - 1; i++)//Идем до нужного элемента
		{
			if (previous->next == NULL)//Если идти некуда , значит что то не то ввели
			{
				printf("Item with this number does not exist\n");//Выводим соответствующее сообщение
				return;//Выход из функции del()
			}
			previous = previous->next;//Переходим к новому элементу
		}

		struct Stek *ToDel = previous->next;//Создаем указатель на элемент который будем удалять 

		previous->next = ToDel->next;//Делаем так , чтобы элемент который указывает на элемент который мы хотим удалить , стал указывать на элемент , на который указывал элемент который мы удалим

		free(ToDel);//освобождаем память 

	}
}

void Ex();// прототип функции в котозадание

void main()//точка входа
{
	//Штуки для создание зерна на основе которого будут генерироваться рандомные числа 
	time_t t;
	srand((unsigned)time(&t));

	int inf;

	struct Stek stak;//Создаем наш стек

	//Так как он только создан , он никуда не указывает
	head = NULL;

	while (1)
	{
		//Создаем менюшку
		int r;
		printf("\n Enter 1 to add item");
		printf("\n Enter 2 to view Stack");
		printf("\n Enter 3 to delete item");
		printf("\n Enter 4 to do the exercise");
		printf("\n Enter 5 to exit\n");
		
		scanf_s("%d", &r);

		switch (r)
		{
		case 1:
		{
			printf("\nEnter the number of items: ");//Введите кол-во элементов которое надо создать 
			scanf_s("%d",&inf);//ввод
			for (int i=0;i<inf;i++)
			{
				push(rand() % 101 - 50);//Вставка рандомного числа от -50 до 50 
			}
			break;
		}
		case 2:
		{
			View();//Просмотр стека
			break;
		}
		case 3:
		{
			printf("\nEnter the item number: ");//Вводим номер элемента который хотим удалить 
			scanf_s("%d", &inf);
			del(inf);//Удаляем 
			break;
		}
		case 4:
		{
			Ex();//Выполняем задание 
			break;
		}
		case 5:
		{
			exit(0);//Выход
			break;
		}

		}
	}
}

void Ex()//задание
{
	//объявляем переменыне min и max и ложим в них значения первого элемента стека
	int min = head->info;
	int max = head->info;

	struct Stek *t = head;//Создаем указатель при помощи которого будем гулять по стеку

	if (t->next == NULL)//Если начало ни на что не указывает , то у нас только один элемент который и max и min 
	{
		printf("\nSteck has only one item");
		return;
	}

	while (t != NULL)//Идем по стеку
	{
		//находим max и min 
		if (t->info > max)
		{
			max = t->info;
		}
		if (t->info < min)
		{
			min = t->info;
		}
		t = t->next;
	}
	//Выводим
	printf("Max=%d", max);
	printf("\nMin=%d", min);
}