#include "Student.h"
using namespace System;
using namespace System::Data;
using namespace System::Windows::Forms;

Student::Student(String ^ name, String ^ fac, int Cource, String ^ Marks)
{
	this->Name = name;
	this->fak = fac;
	this->Course = Cource;
	this->Marks = Marks;

	String ^bufer = "";
	int kol = 0;

	if (Marks[Marks->Length-1]!=32)
	{
		Marks += " ";
	}

	for (int i=0;i<Marks->Length;i++)
	{
		if (Marks[i]==32)
		{
			MidleMark += Convert::ToDouble(bufer);
			kol++;
			bufer = "";
		}
		else
		{
			bufer += Marks[i];
		}
	}

	MidleMark = MidleMark / kol;
}

void Student::Show(RichTextBox ^ rtb)
{
	rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:"+Marks + "\n\nСредняя оценка:"+MidleMark+"\n___________________________________________";
}

void Student::Scholarship(RichTextBox ^ rtb)
{
	if (MidleMark<4)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтипендия:0" + "\n___________________________________________";
	}
	else if (MidleMark<6)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтипендия:70" + "\n___________________________________________";
	}
	else if(MidleMark<8)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтипендия:90" + "\n___________________________________________";
	}
	else
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтипендия:110" + "\n___________________________________________";
	}
}

void Student::NextStep(RichTextBox ^ rtb)
{
	if (Course < 6 && MidleMark>=4)
	{
		if (Course == 5)
		{
			rtb->Text +="\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:Выпустился" + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Выпустился" + "\n___________________________________________";
			return;
		}
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + (Course+1).ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Переведён" + "\n___________________________________________";
		Course++;
		return;
	}
	if(Course < 6 && MidleMark < 4)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Не переведён" + "\n\nПричина:Низкий балл"+ "\n___________________________________________";
		return;
	}
	if(Course > 5 )
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:бюджетник\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Выпустился" + "\n___________________________________________";
	}
}
