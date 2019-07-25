#pragma once
#include "Student.h"

using namespace System;
using namespace System::Data;

ref class RudikStack
{
public:
	RudikStack ^next;
	Student ^info;
	RudikStack^ Push(RudikStack ^head,String ^name,String ^fac,int Cource ,String ^Marks);
	RudikStack^ Push(RudikStack ^head, String ^name, String ^fac, int Cource, String ^Marks,bool Payment);
	RudikStack^ Del(RudikStack ^head, String ^name);
	void ShowInfo(RudikStack ^head,RichTextBox ^rtb);
	void ShowScholarship(RudikStack ^head,RichTextBox ^rtb);
	void NextStep(RudikStack ^head,RichTextBox ^rtb);
	RudikStack(String ^name, String ^fac, int Cource, String ^Marks, bool Payment);
	RudikStack(String ^name, String ^fac, int Cource, String ^Marks);
};

