#pragma once
using namespace System;
using namespace System::Data;
using namespace System::Windows::Forms;

ref class Student
{
public:
	int Course;
	double MidleMark;
	String ^Name, ^fak, ^Marks;
	Student(String ^ name, String ^ fac, int Cource, String ^ Marks);
	virtual void Show(RichTextBox ^rtb);
	virtual void Scholarship(RichTextBox ^rtb);
	virtual void NextStep(RichTextBox ^rtb);
};

