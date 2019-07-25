#include <stdio.h>//Для ввода и вывода
#include <malloc.h>//Для динамического выделения памяти
#include <time.h>//Для генерации рандомных чисел

struct Spisok//Создаем структуру с названием Stek в которой 2 поля , info отвечает за число , next - указатель на следующий элемент
{
	int info;
	struct Spisok *next;
}*head; //Сразу создаем указатель типа Stek в котором будет хранится адрес начала стека

void push(int in) //Добавляем элемент
{
	if (head == NULL)//Добавляем адрес первого элемента
	{
		head = (struct Spisok*)malloc(sizeof(struct Spisok));//Выделяем память элементу  
		head->info = in;//Заполняем поле info элемента
		head->next = NULL;//Первый элемент стека никуда не указывает
		return;
	}

	struct Spisok *bufer = head;//Создаем переменную для прохождения по элементам строки

	while (bufer->next != NULL)//Пока список указывает куда то , то идем по нему
	{
		bufer = bufer->next;//Переходим к следующему элементу
	}

	bufer->next = (struct Spisok*)malloc(sizeof(struct Spisok));//Указателю последнего элемента списка даем адрес на новый элемнт

	bufer->next->next = NULL;//Новый элемент никуда не указывает
	bufer->next->info = in;//Даем значение новому элементу 

}
void View()//Просмотр списка
{
	if (head == NULL)//Если head ни на что не указывает , значит список пуст
	{
		printf("Список пуст\n");//Вывод 
		return;//Выходим из функции View()
	}

	struct Spisok *t = head;//Создаем переменную для прохождения по элементам списка

	printf("%d ",t->info);//Вывод значения первого элемента стспискаека

	while (t->next != NULL)//Пока список указывает куда то , то идем по нему
	{
		t = t->next;//Переходим к следующему элементу
		printf("%d ", t->info);//Вывод значения элемента к которому перешли
	}
}
void del(int num) //Удаление элемента по его номеру
{
	if (num == 0)//Удаляем начало
	{
		struct Spisok *bufer = head;//Создаем указатель на элемент который будем удалять 
		head = head->next;//Даем списку новое начало
		free(bufer);//Удаляем выбранный элемент
	}
	else
	{
		struct Spisok *previous = head;//Создаем указатель при помощи которого мы доберемся до элемента который надо удалить

		for (int i = 0; i < num - 1; i++)//Идем до нужного элемента
		{
			if (previous->next == NULL)//Если идти некуда , значит что то не то ввели
			{
				printf("Item with this number does not exist\n");//Выводим соответствующее сообщение
				return;//Выход из функции del()
			}
			previous = previous->next;//Переходим к новому элементу
		}

		struct Spisok *ToDel = previous->next;//Создаем указатель на элемент который будем удалять 

		previous->next = ToDel->next;//Делаем так , чтобы элемент который указывает на элемент который мы хотим удалить , стал указывать на элемент , на который указывал элемент который мы удалим

		free(ToDel);//освобождаем память 

	}
}

void Ex()//задание
{
	//объявляем переменыне min и max и ложим в них значения первого элемента списка
	int min = head->info;
	int max = head->info;

	struct Spisok *t = head;//Создаем указатель при помощи которого будем гулять по списку

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
	printf("Max=%d",max);
	printf("\nMin=%d",min);
}

void main()//точка входа
{
	//Штуки для создание зерна на основе которого будут генерироваться рандомные числа 
	time_t t;
	srand((unsigned)time(&t));

	int inf;

	struct Spisok stak;//Создаем наш список

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