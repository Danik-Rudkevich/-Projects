#pragma once
#include "Student.h"
using namespace System;
using namespace System::Data;
using namespace System::Windows::Forms;

ref class StudentPlat :public Student
{
public:
	bool Pay;
	StudentPlat(String ^ name, String ^ fac, int Cource, String ^ Marks, bool Payment);
	void Show(RichTextBox ^rtb) override;
	void Scholarship(RichTextBox ^rtb) override;
	void NextStep(RichTextBox ^rtb) override;
};

