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
	rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:" + Course.ToString() + "\n\n����� ��������:�������"+"\n\n������ ��������:"+Pay+"\n\n������:" + Marks+ "\n\n������� ������:" + MidleMark + "\n___________________________________________";
}

void StudentPlat::Scholarship(RichTextBox ^ rtb)
{
	rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:" + Course.ToString() + "\n\n����� ��������:�������" + "\n\n������ ��������:" + Pay + "\n\n������:" + Marks + "\n\n������� ������:" + MidleMark +"\n\n���������:�����������" +"\n___________________________________________";
}

void StudentPlat::NextStep(RichTextBox ^ rtb)
{
	if (Course < 6 && MidleMark >= 4 && Pay)
	{
		if (Course == 5)
		{
			rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:����������" + "\n\n����� ��������:�������" + "\n\n������ ��������:" + Pay + "\n\n������:" + Marks + "\n\n������� ������:" + MidleMark + "\n\n������:����������" + "\n___________________________________________";
			return;
		}
		rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:" + (Course+1).ToString() + "\n\n����� ��������:�������" + "\n\n������ ��������:" + Pay + "\n\n������:" + Marks + "\n\n������� ������:" + MidleMark +"\n\n������:��������" + "\n___________________________________________";
		Course++;
		return;
	}
	else if (Course < 6 && MidleMark < 4 && Pay)
	{
		rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:" + Course.ToString() + "\n\n����� ��������:�������" + "\n\n������ ��������:" + Pay + "\n\n������:" + Marks + "\n\n������� ������:" + MidleMark + "\n\n������:�� ��������"+"\n\n�������:������ ����" + "\n___________________________________________";
		return;
	}
	else if (Course < 6 && MidleMark >4 && !Pay)
	{
		rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:" + Course.ToString() + "\n\n����� ��������:�������" + "\n\n������ ��������:" + Pay + "\n\n������:" + Marks + "\n\n������� ������:" + MidleMark + "\n\n������:�� ��������" + "\n\n�������:�������� �� ��������" + "\n___________________________________________";
		return;
	}
	else if (Course < 6 && MidleMark < 4 && !Pay)
	{
		rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:" + Course.ToString() + "\n\n����� ��������:�������" + "\n\n������ ��������:" + Pay + "\n\n������:" + Marks + "\n\n������� ������:" + MidleMark + "\n\n������:�� ��������" + "\n\n�������:�������� �� ��������,������ ����" + "\n___________________________________________";
		return;
	}
	else if (Course > 5)
	{
		rtb->Text += "\n\n�������:" + Name + "\n\n���������:" + fak + "\n\n����:" + Course.ToString() + "\n\n����� ��������:�������" + "\n\n������ ��������:" + Pay + "\n\n������:" + Marks + "\n\n������� ������:" + MidleMark + "\n\n������:����������" + "\n___________________________________________";
	}
}
