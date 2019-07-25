#include "RudikStack.h"
#include "Student.h"
#include "StudentPlat.h"

using namespace System;
using namespace System::Data;
using namespace System::Windows::Forms;


RudikStack ^ RudikStack::Push(RudikStack ^ head, String ^ name, String ^ fac, int Cource, String ^ Marks)
{
	if (head == nullptr)
	{
		head = gcnew RudikStack(name,fac,Cource,Marks);
		head->next = nullptr;
		return head;
	}
	
	RudikStack ^Buffer = gcnew RudikStack(name, fac, Cource, Marks);
	Buffer->next = head;
	return Buffer;
}

RudikStack ^ RudikStack::Push(RudikStack ^ head, String ^ name, String ^ fac, int Cource, String ^ Marks, bool Payment)
{
	if (head == nullptr)
	{
		head = gcnew RudikStack(name, fac, Cource, Marks,Payment);
		head->next = nullptr;
		return head;

	}

	RudikStack ^Buffer = gcnew RudikStack(name, fac, Cource, Marks,Payment);
	Buffer->next = head;
	return Buffer;
}

RudikStack ^ RudikStack::Del(RudikStack ^ head, String ^ name)
{
	if (head == nullptr)
	{
		MessageBox::Show("В базе нет студентов!");
		return head;
	}

	RudikStack ^prev=head;

	if (head->info->Name == name)
	{
		head = head->next;
		MessageBox::Show("Студент "+name+" удалён!");
		delete prev;
		return head;
	}

	RudikStack ^move = head->next;

	while (move!=nullptr)
	{
		if (move->info->Name == name)
		{
			prev->next = move->next;
			MessageBox::Show("Студент " + name + " удалён!");
			delete move;
			return head;
		}
		prev = move;
		move = move->next;
	}

	MessageBox::Show("Студент с таким именем не найден!");
	return head;
}

void RudikStack::ShowInfo(RudikStack ^ head, RichTextBox ^ rtb)
{
	if (head == nullptr)
	{
		MessageBox::Show("В базе нет студентов");
		return;
	}

	while (head!=nullptr)
	{
		head->info->Show(rtb);
		head = head->next;
	}
}

void RudikStack::ShowScholarship(RudikStack ^ head, RichTextBox ^ rtb)
{
	if (head == nullptr)
	{
		MessageBox::Show("В базе нет студентов");
		return;
	}

	while (head != nullptr)
	{
		head->info->Scholarship(rtb);
		head = head->next;
	}
}

void RudikStack::NextStep(RudikStack ^ head, RichTextBox ^ rtb)
{
	if (head == nullptr)
	{
		MessageBox::Show("В базе нет студентов");
		return;
	}

	while (head != nullptr)
	{
		head->info->NextStep(rtb);
		head = head->next;
	}
}

RudikStack::RudikStack(String ^ name, String ^ fac, int Cource, String ^ Marks, bool Payment)
{
	this->info = gcnew StudentPlat(name,fac,Cource,Marks,Payment);
}

RudikStack::RudikStack(String ^ name, String ^ fac, int Cource, String ^ Marks)
{
	this->info = gcnew Student(name, fac, Cource, Marks);
}

