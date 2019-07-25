#include "StudentPlat.h"
using namespace System;
using namespace System::Data;
using namespace System::Windows::Forms;

StudentPlat::StudentPlat(String ^ name, String ^ fac, int Cource, String ^ Marks, bool Payment):Student(name,fac,Cource,Marks)
{
	Pay = Payment;
}

void StudentPlat::Show(RichTextBox ^ rtb)
{
	rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:платник"+"\n\nОплата обучения:"+Pay+"\n\nОценки:" + Marks+ "\n\nСредняя оценка:" + MidleMark + "\n___________________________________________";
}

void StudentPlat::Scholarship(RichTextBox ^ rtb)
{
	rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:платник" + "\n\nОплата обучения:" + Pay + "\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark +"\n\nСтипендия:Отсутствует" +"\n___________________________________________";
}

void StudentPlat::NextStep(RichTextBox ^ rtb)
{
	if (Course < 6 && MidleMark >= 4 && Pay)
	{
		if (Course == 5)
		{
			rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:Выпустился" + "\n\nФорма обучения:платник" + "\n\nОплата обучения:" + Pay + "\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Выпустился" + "\n___________________________________________";
			return;
		}
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + (Course+1).ToString() + "\n\nФорма обучения:платник" + "\n\nОплата обучения:" + Pay + "\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark +"\n\nСтатус:Переведён" + "\n___________________________________________";
		Course++;
		return;
	}
	else if (Course < 6 && MidleMark < 4 && Pay)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:платник" + "\n\nОплата обучения:" + Pay + "\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Не переведён"+"\n\nПричина:Низкий балл" + "\n___________________________________________";
		return;
	}
	else if (Course < 6 && MidleMark >4 && !Pay)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:платник" + "\n\nОплата обучения:" + Pay + "\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Не переведён" + "\n\nПричина:Обучение не оплачено" + "\n___________________________________________";
		return;
	}
	else if (Course < 6 && MidleMark < 4 && !Pay)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:платник" + "\n\nОплата обучения:" + Pay + "\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Не переведён" + "\n\nПричина:Обучение не оплачено,низкий балл" + "\n___________________________________________";
		return;
	}
	else if (Course > 5)
	{
		rtb->Text += "\n\nСтудент:" + Name + "\n\nФакультет:" + fak + "\n\nКурс:" + Course.ToString() + "\n\nФорма обучения:платник" + "\n\nОплата обучения:" + Pay + "\n\nОценки:" + Marks + "\n\nСредняя оценка:" + MidleMark + "\n\nСтатус:Выпустился" + "\n___________________________________________";
	}
}
