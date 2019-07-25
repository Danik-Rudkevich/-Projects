#include <stdio.h>//��� ����� � ������
#include <malloc.h>//��� ������������� ��������� ������
#include <time.h>//��� ��������� ��������� �����

struct Spisok//������� ��������� � ��������� Stek � ������� 2 ���� , info �������� �� ����� , next - ��������� �� ��������� �������
{
	int info;
	struct Spisok *next;
}*head; //����� ������� ��������� ���� Stek � ������� ����� �������� ����� ������ �����

void push(int in) //��������� �������
{
	if (head == NULL)//��������� ����� ������� ��������
	{
		head = (struct Spisok*)malloc(sizeof(struct Spisok));//�������� ������ ��������  
		head->info = in;//��������� ���� info ��������
		head->next = NULL;//������ ������� ����� ������ �� ���������
		return;
	}

	struct Spisok *bufer = head;//������� ���������� ��� ����������� �� ��������� ������

	while (bufer->next != NULL)//���� ������ ��������� ���� �� , �� ���� �� ����
	{
		bufer = bufer->next;//��������� � ���������� ��������
	}

	bufer->next = (struct Spisok*)malloc(sizeof(struct Spisok));//��������� ���������� �������� ������ ���� ����� �� ����� ������

	bufer->next->next = NULL;//����� ������� ������ �� ���������
	bufer->next->info = in;//���� �������� ������ �������� 

}
void View()//�������� ������
{
	if (head == NULL)//���� head �� �� ��� �� ��������� , ������ ������ ����
	{
		printf("������ ����\n");//����� 
		return;//������� �� ������� View()
	}

	struct Spisok *t = head;//������� ���������� ��� ����������� �� ��������� ������

	printf("%d ",t->info);//����� �������� ������� �������� �����������

	while (t->next != NULL)//���� ������ ��������� ���� �� , �� ���� �� ����
	{
		t = t->next;//��������� � ���������� ��������
		printf("%d ", t->info);//����� �������� �������� � �������� �������
	}
}
void del(int num) //�������� �������� �� ��� ������
{
	if (num == 0)//������� ������
	{
		struct Spisok *bufer = head;//������� ��������� �� ������� ������� ����� ������� 
		head = head->next;//���� ������ ����� ������
		free(bufer);//������� ��������� �������
	}
	else
	{
		struct Spisok *previous = head;//������� ��������� ��� ������ �������� �� ��������� �� �������� ������� ���� �������

		for (int i = 0; i < num - 1; i++)//���� �� ������� ��������
		{
			if (previous->next == NULL)//���� ���� ������ , ������ ��� �� �� �� �����
			{
				printf("Item with this number does not exist\n");//������� ��������������� ���������
				return;//����� �� ������� del()
			}
			previous = previous->next;//��������� � ������ ��������
		}

		struct Spisok *ToDel = previous->next;//������� ��������� �� ������� ������� ����� ������� 

		previous->next = ToDel->next;//������ ��� , ����� ������� ������� ��������� �� ������� ������� �� ����� ������� , ���� ��������� �� ������� , �� ������� �������� ������� ������� �� ������

		free(ToDel);//����������� ������ 

	}
}

void Ex()//�������
{
	//��������� ���������� min � max � ����� � ��� �������� ������� �������� ������
	int min = head->info;
	int max = head->info;

	struct Spisok *t = head;//������� ��������� ��� ������ �������� ����� ������ �� ������

	if (t->next == NULL)//���� ������ �� �� ��� �� ��������� , �� � ��� ������ ���� ������� ������� � max � min 
	{
		printf("\nSteck has only one item");
		return;
	}

	while (t != NULL)//���� �� �����
	{
		//������� max � min 
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
	//�������
	printf("Max=%d",max);
	printf("\nMin=%d",min);
}

void main()//����� �����
{
	//����� ��� �������� ����� �� ������ �������� ����� �������������� ��������� ����� 
	time_t t;
	srand((unsigned)time(&t));

	int inf;

	struct Spisok stak;//������� ��� ������

	//��� ��� �� ������ ������ , �� ������ �� ���������
	head = NULL;

	while (1)
	{
		//������� �������
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
			printf("\nEnter the number of items: ");//������� ���-�� ��������� ������� ���� ������� 
			scanf_s("%d",&inf);//����
			for (int i=0;i<inf;i++)
			{
				push(rand() % 101 - 50);//������� ���������� ����� �� -50 �� 50 
			}
			break;
		}
		case 2:
		{
			View();//�������� �����
			break;
		}
		case 3:
		{
			printf("\nEnter the item number: ");//������ ����� �������� ������� ����� ������� 
			scanf_s("%d", &inf);
			del(inf);//������� 
			break;
		}
		case 4:
		{
			Ex();//��������� ������� 
			break;
		}
		case 5:
		{
			exit(0);//�����
			break;
		}

		}
	}
}