#include "pch.h" //Основные библиотеки
#include <iostream> //cin cout
#include <string>
using namespace std;//Пространство имен

class Stack
{
public:

	Stack()
	{
		Head = nullptr;
	}

	void Add(int info)
	{
		Head = new Node(info,Head);
	}

	void ViewAll()
	{
		Node *t = Head;

		while (t!=nullptr)
		{
			cout << t->data << " ";
			t = t->pNext;
		}
	}

	void Unloading()
	{
		Node *ToDel;

		while (Head!=nullptr)
		{
			ToDel = Head;
			Head = Head->pNext;
			cout << ToDel->data;
			delete ToDel;
		}
	}

	void UnloadingBracket()
	{
		Node *ToDel;

		while (Head->data != '(')
		{
			ToDel = Head;
			Head = Head->pNext;
			cout << ToDel->data;
			delete ToDel;
		}

		ToDel = Head;
		Head = Head->pNext;
		delete ToDel;
	}

	class Node
	{
	public:
		Node *pNext;
		char data;

		Node(char data , Node *pNext)
		{
			this->data = data;
			this->pNext = pNext;
		}
	};
	Node *Head;//Указатель на вершину
};

int Prior(char Symbol)
{
		switch (Symbol)
		{
	case '+':
	{
		return 2;
	}
	case '-':
	{
		return 2;
	}
	case '/':
	{
		return 3;
	}
	case '*':
	{
		return 3;
	}
	case '(':
	{
		return 1;
	}
	case ')':
	{
		return 4;
	}
	default:
	{
		return 0;
	}
		}
}

int main()
{

	Stack obj;

	string Text;

	getline(cin,Text);

	for (int i=0;i<Text.length();i++)
	{
		if (Prior(Text[i]) == 0)
		{
			cout << Text[i];
			continue;
		}

		if (obj.Head == nullptr)
		{
			obj.Add(Text[i]);
			continue;
		}

		if (Text[i] == '(')
		{
			obj.Add(Text[i]);
			continue;
		}

		if (Text[i] == ')')
		{
			obj.UnloadingBracket();
			continue;
		}

		if (Prior(obj.Head->data)<Prior(Text[i]))
		{
			obj.Add(Text[i]);
			continue;
		}
		else
		{
			obj.Unloading();
			continue;
		}
	}

	if (obj.Head!=nullptr)
	{
		obj.Unloading();
	}

	return 0;
}