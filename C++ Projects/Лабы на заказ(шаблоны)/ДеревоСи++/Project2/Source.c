#include <stdio.h>//��� ����� � ������
#include <malloc.h>//��� ������������� ��������� ������
#include <time.h>//��� ��������� ��������� �����

struct Tree//��������� ��������� ������
{
	int key, data;//��������� ���� 

	struct Tree *Right, *Left, *Last;//��������� ��������� 

}*root;//������� ���������� ������� ���� 

void CheckKey(int a, struct Tree *Node, int *Check)//������� ��� �������� ������������ �������� ���������������� ����� ��� ������������� ��� � ���� �����
{
	if (Node == NULL)//����� � �������
	{
		return;
	}
	if (Node->key == a)//����� ������ � ����� ������ , ������ �� ��� �� �������� 
	{
		*Check = 0;
		return;
	}
	/* ����� ������ ��������� */
	CheckKey(a, Node->Left, Check);
	/* ����� ������� ��������� */
	CheckKey(a, Node->Right, Check);
}

void ViewPrimo(struct Tree *Node)//������ �����
{
	if (Node == NULL)
	{
		return;
	}
	printf("%d\n", Node->data);
	/* ����� ������ ��������� */
	ViewPrimo(Node->Left);
	/* ����� ������� ��������� */
	ViewPrimo(Node->Right);
}

void ViewObratno(struct Tree *Node)//�������� �����
{
	/* ���� ������ �����, �� ��������� ������� �������� � ����� ������ �����������
	*/
	if (Node == NULL)
	{
		return;
	}
	/* ����� ������ ��������� */
	ViewObratno(Node->Left);
	printf("%d\n", Node->data);
	/* ����� ������� ��������� */
	ViewObratno(Node->Right);
}

void ViewByKey(struct Tree *Node,int key)//�������� ������ �� �����
{
	if (Node == NULL)
	{
		return;
	}
	if (Node->key==key)//����� ������ �������
	{
		printf("\nData=%d\n", Node->data);
	}
	/* ����� ������ ��������� */
	ViewByKey(Node->Left,key);
	/* ����� ������� ��������� */
	ViewByKey(Node->Right,key);
}

void Add(time_t t)//� �������� ��������� ���������� ����� ��� ��������� ���������� �����
{

	int check, key;//Check - ��� �������� ������������ ����� , key - ������ ����

	do
	{
		check = 1;//���������� ������� , ��� ���� ����� �������� , ���� �� �������� �� ������� , �� ������� CheckKey() ������� check �� 0 � ���� �������� ������ 
		key = rand() % 101 - 50;//���������� ���� � ��������� �� -50 �� 50
		CheckKey(key, root, &check);//��������� ����
		if (check == 0)
		{
			printf("%d Bad key \n", key);
		}


	} while (check < 1);

	printf("%d Good Key \n", key);

	if (root == NULL)//���� ������ ������ 
	{
		root = (struct Tree*)malloc(sizeof(struct Tree));//�������� ������
		root->data = rand() % 101 - 50;//���������� �������� 
		printf("Key = %d add data =%d\n", key, root->data);//������� ����������
		root->key = key;//�������������� ���� , ��� ��������� ������� ��� ��� ������ ������ ��� ������ � ������ �� ��������� 
		root->Last = NULL;
		root->Left = NULL;
		root->Right = NULL;
	}
	else
	{
		struct Tree *r = root;

		while (r != NULL)//���� ��� ������ ����������� �����
		{
			if (r->key > key)//���� ��� ���� ������ , �� ��� �� ����
			{
				if (r->Left != NULL)//���� ���� �� ������ , �� ������������ �� ���� , ���� ������ , �� ������� ������� 
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
				if (r->Right != NULL)//���� ����� �� ������ , �� ������������ �� ���� , ���� ������ , �� ������� ������� 
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

void DellBykey(int key)//��� ������� ��������� ���� , ��� ��������� ������� ������� ������ � ����������� ������� , ������� ����������
{
		struct  Tree *marker;//��������� �� ��������� �������

		if (root->key == key && root->Left!=NULL)//���� ������� ������ � ����� ��� �� ���� 
		{
			marker = root->Left;//���� �� ����
			while (marker->Right!=NULL)//������� ����� ������ �������
			{
				marker = marker->Right;
			}
			if (marker->Left != NULL)//���� ����� ��� �� ���� , �� ����������������� ��������� last 
			{
				marker->Left->Last = marker->Last;
			}
			marker->Last->Right = marker->Left;//������������ ����� ��������� ������������� �������� � ��� ��������� 
			//������ ������ �������� ������� ������ ������� , �� ������ ������������� 
			root->key = marker->key;
			root->data = marker->data;
			free(marker);
		}
		else if(root->Left == NULL)//���� ����� ������ ��� , �� ������ ������������� ����� ��������� ������� � ������� ��� 
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
				while (key != marker->key)//���� ��� ���� 
				{
					//������ ����� �� ��� � ��� ���������� �������� 
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

				if (marker->Left == NULL)//���� ����� ��� �� ���� 
				{
					//����������� ���������� � ����������� �� ����� 
					if (marker->Last->key < marker->key)//����  ���� �������� ������ ����� ������� , �� ����������� ������ ��������� ������� ������ �� �������� else ����� �� �������� 
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
				while (Mark2->Right != NULL)//���� � ������ ������� �������� 
				{
					Mark2 = Mark2->Right;
				}
				Mark2->Last->Left = Mark2->Left;//����������� ������������ ������� 
				if (Mark2->Left!=NULL)//����������� Last ��������� � �������� �������������� �������� 
				{
					Mark2->Left->Last = Mark2->Last;
				}
				//������ ������ 
				marker->key = Mark2->key;
				marker->data = Mark2->data;
				free(Mark2);
			}
			else if(key < marker->key)//�� �� ����� , ������ ��� ������ ���������
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
	/* ����� ������ ��������� */
	DellAll(Node->Left);
	/* ����� ������� ��������� */
	DellAll(Node->Right);

	free(Node);//������� ������� � �������� ������ 
}

void Ex()
{
	struct Tree *Max = root;
	struct Tree *Min = root;

	while (Min->Left!=NULL)//���� � ����� ����� ������� 
	{
		Min = Min->Left;
	}
	while (Max->Right != NULL)//���� � ����� ������ �������
	{
		Max = Max->Right;
	}
	//������ ���������� ��������� ������� 
	int buffer= Max->data;
	Max->data = Min->data;
	Min->data = buffer;
}

int main()
{
	root = NULL;

	//���������� ����� ��� rand 
	time_t t;
	srand((unsigned)time(&t));

	while (1)
	{
		//������� �������
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
			printf("\nEnter the number of items: ");//������� ���-�� ��������� ������� ���� ������� 
			scanf_s("%d", &inf);//����
			for (int i = 0; i < inf; i++)
			{
				Add(t);//����������
			}
			break;
		}
		case 2:
		{
			printf("\nView-1\n");
			ViewPrimo(root);//������ �����
			printf("\nView-2\n");
			ViewObratno(root);//�������� �����
			printf("\nEnter key:");
			scanf_s("%d", &inf);//����
			ViewByKey(root,inf);//�������� �� �����
			break;
		}
		case 3:
		{
			printf("\nEnter the item number: ");//������ ����� �������� ������� ����� ������� 
			scanf_s("%d", &inf);
			DellBykey(inf);//������� 
			break;
		}
		case 4:
		{
			Ex();//��������� �������, ��� �������� ����������� ���������� , ������ ����� ViewByKey() ���� ������������� � ������������ ����� , ������� �� data , ������� ����� 4 � ��� ��������� ��������� ��� ������ ViewByKey() �� ������� , ��� �� data ���������� ������� 
			break;
		}
		case 5:
		{
			DellAll(root);//������� ������ 
			exit(0);//�����
			break;
		}

		}
	}
	return 0;
}