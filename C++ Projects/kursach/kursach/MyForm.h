#pragma once
#include "frmLicenseAgreement.h"
#include "Block.h"
#include "RudikStack.h"
#include "Student.h"
#include "StudentPlat.h"
namespace kursach {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  label1;
	protected:
		bool Cheked;
		RudikStack ^Head = nullptr;
		int Kol = 0;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::TextBox^  tbName;
	private: System::Windows::Forms::TextBox^  tbFaculty;
	private: System::Windows::Forms::TextBox^  tbCourse;
	private: System::Windows::Forms::TextBox^  tbMarks;
	private: System::Windows::Forms::RadioButton^  rbBudget;
	private: System::Windows::Forms::RadioButton^  rbPlatka;
	private: System::Windows::Forms::CheckBox^  cbPayment;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::RichTextBox^  rtbOutput;

	private: System::Windows::Forms::Button^  btnInfo;

	private: System::Windows::Forms::Button^  btnNextStep;
	private: System::Windows::Forms::Button^  btnScholarship;
	private: System::Windows::Forms::Label^  label6;




	protected:


	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm::typeid));
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->tbName = (gcnew System::Windows::Forms::TextBox());
			this->tbFaculty = (gcnew System::Windows::Forms::TextBox());
			this->tbCourse = (gcnew System::Windows::Forms::TextBox());
			this->tbMarks = (gcnew System::Windows::Forms::TextBox());
			this->rbBudget = (gcnew System::Windows::Forms::RadioButton());
			this->rbPlatka = (gcnew System::Windows::Forms::RadioButton());
			this->cbPayment = (gcnew System::Windows::Forms::CheckBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->rtbOutput = (gcnew System::Windows::Forms::RichTextBox());
			this->btnInfo = (gcnew System::Windows::Forms::Button());
			this->btnNextStep = (gcnew System::Windows::Forms::Button());
			this->btnScholarship = (gcnew System::Windows::Forms::Button());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 16);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(37, 13);
			this->label1->TabIndex = 0;
			this->label1->Text = L"ФИО:";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(12, 50);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(66, 13);
			this->label2->TabIndex = 1;
			this->label2->Text = L"Факультет:";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(15, 91);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(34, 13);
			this->label3->TabIndex = 2;
			this->label3->Text = L"Курс:";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(15, 124);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(118, 13);
			this->label4->TabIndex = 3;
			this->label4->Text = L"Оценки за экзамены:";
			// 
			// tbName
			// 
			this->tbName->Location = System::Drawing::Point(57, 13);
			this->tbName->Name = L"tbName";
			this->tbName->Size = System::Drawing::Size(291, 20);
			this->tbName->TabIndex = 4;
			// 
			// tbFaculty
			// 
			this->tbFaculty->Location = System::Drawing::Point(84, 50);
			this->tbFaculty->Name = L"tbFaculty";
			this->tbFaculty->Size = System::Drawing::Size(264, 20);
			this->tbFaculty->TabIndex = 5;
			// 
			// tbCourse
			// 
			this->tbCourse->Location = System::Drawing::Point(57, 88);
			this->tbCourse->Name = L"tbCourse";
			this->tbCourse->Size = System::Drawing::Size(291, 20);
			this->tbCourse->TabIndex = 6;
			this->tbCourse->TextChanged += gcnew System::EventHandler(this, &MyForm::tbCourse_TextChanged);
			this->tbCourse->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbCourse_KeyPress);
			// 
			// tbMarks
			// 
			this->tbMarks->Location = System::Drawing::Point(139, 124);
			this->tbMarks->Name = L"tbMarks";
			this->tbMarks->Size = System::Drawing::Size(209, 20);
			this->tbMarks->TabIndex = 7;
			this->tbMarks->TextChanged += gcnew System::EventHandler(this, &MyForm::tbMarks_TextChanged);
			this->tbMarks->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMarks_KeyPress);
			// 
			// rbBudget
			// 
			this->rbBudget->AutoSize = true;
			this->rbBudget->Checked = true;
			this->rbBudget->Location = System::Drawing::Point(15, 153);
			this->rbBudget->Name = L"rbBudget";
			this->rbBudget->Size = System::Drawing::Size(65, 17);
			this->rbBudget->TabIndex = 8;
			this->rbBudget->TabStop = true;
			this->rbBudget->Text = L"Бюджет";
			this->rbBudget->UseVisualStyleBackColor = true;
			// 
			// rbPlatka
			// 
			this->rbPlatka->AutoSize = true;
			this->rbPlatka->Location = System::Drawing::Point(15, 176);
			this->rbPlatka->Name = L"rbPlatka";
			this->rbPlatka->Size = System::Drawing::Size(62, 17);
			this->rbPlatka->TabIndex = 9;
			this->rbPlatka->Text = L"Платка";
			this->rbPlatka->UseVisualStyleBackColor = true;
			this->rbPlatka->CheckedChanged += gcnew System::EventHandler(this, &MyForm::rbPlatka_CheckedChanged);
			// 
			// cbPayment
			// 
			this->cbPayment->AutoSize = true;
			this->cbPayment->Location = System::Drawing::Point(15, 199);
			this->cbPayment->Name = L"cbPayment";
			this->cbPayment->Size = System::Drawing::Size(69, 17);
			this->cbPayment->TabIndex = 10;
			this->cbPayment->Text = L"Оплатил";
			this->cbPayment->UseVisualStyleBackColor = true;
			this->cbPayment->Visible = false;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(15, 223);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(43, 13);
			this->label5->TabIndex = 11;
			this->label5->Text = L"Вывод:";
			// 
			// rtbOutput
			// 
			this->rtbOutput->Location = System::Drawing::Point(15, 240);
			this->rtbOutput->Name = L"rtbOutput";
			this->rtbOutput->Size = System::Drawing::Size(475, 378);
			this->rtbOutput->TabIndex = 12;
			this->rtbOutput->Text = L"";
			// 
			// btnInfo
			// 
			this->btnInfo->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->btnInfo->Location = System::Drawing::Point(139, 153);
			this->btnInfo->Name = L"btnInfo";
			this->btnInfo->Size = System::Drawing::Size(351, 63);
			this->btnInfo->TabIndex = 13;
			this->btnInfo->Text = L"Вывести информацию о всех студентах";
			this->btnInfo->UseVisualStyleBackColor = true;
			this->btnInfo->Click += gcnew System::EventHandler(this, &MyForm::btnInfo_Click);
			// 
			// btnNextStep
			// 
			this->btnNextStep->Location = System::Drawing::Point(355, 13);
			this->btnNextStep->Name = L"btnNextStep";
			this->btnNextStep->Size = System::Drawing::Size(135, 57);
			this->btnNextStep->TabIndex = 14;
			this->btnNextStep->Text = L"Перевести на след. курс";
			this->btnNextStep->UseVisualStyleBackColor = true;
			this->btnNextStep->Click += gcnew System::EventHandler(this, &MyForm::btnNextStep_Click);
			// 
			// btnScholarship
			// 
			this->btnScholarship->Location = System::Drawing::Point(354, 87);
			this->btnScholarship->Name = L"btnScholarship";
			this->btnScholarship->Size = System::Drawing::Size(135, 57);
			this->btnScholarship->TabIndex = 15;
			this->btnScholarship->Text = L"Стипендия";
			this->btnScholarship->UseVisualStyleBackColor = true;
			this->btnScholarship->Click += gcnew System::EventHandler(this, &MyForm::btnScholarship_Click);
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(169, 219);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(295, 13);
			this->label6->TabIndex = 16;
			this->label6->Text = L"Добавить студента: Ctrl+a           Удалить студента: Ctrl+d";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(502, 630);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->btnScholarship);
			this->Controls->Add(this->btnNextStep);
			this->Controls->Add(this->btnInfo);
			this->Controls->Add(this->rtbOutput);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->cbPayment);
			this->Controls->Add(this->rbPlatka);
			this->Controls->Add(this->rbBudget);
			this->Controls->Add(this->tbMarks);
			this->Controls->Add(this->tbCourse);
			this->Controls->Add(this->tbFaculty);
			this->Controls->Add(this->tbName);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->KeyPreview = true;
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"MyForm";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"Главная";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::MyForm_KeyPress);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {
		System::Windows::Forms::DialogResult mb = MessageBox::Show("А вы точно хотите работать в этой программе?", "Подумайте", MessageBoxButtons::YesNo, MessageBoxIcon::Question);

		if (mb == System::Windows::Forms::DialogResult::Yes)
		{
			mb = MessageBox::Show("Вы уверены?", "Подумайте", MessageBoxButtons::YesNo, MessageBoxIcon::Question);
			if (mb == System::Windows::Forms::DialogResult::Yes)
			{
				mb = MessageBox::Show("Вот точно-точно уверены?", "Подумайте", MessageBoxButtons::YesNo, MessageBoxIcon::Question);
				if (mb == System::Windows::Forms::DialogResult::Yes)
				{
					mb = MessageBox::Show("Вот вообще ни капли сомнений?", "Подумайте", MessageBoxButtons::YesNo, MessageBoxIcon::Question);
					if (mb == System::Windows::Forms::DialogResult::Yes)
					{
						mb = MessageBox::Show("Вот прям вообще?", "Подумайте", MessageBoxButtons::YesNo, MessageBoxIcon::Question);
						if (mb == System::Windows::Forms::DialogResult::Yes)
						{
							MessageBox::Show("Ну ладно , поверю вам :)");
							mb = MessageBox::Show("А Может всё таки передумаете?", "Подумайте", MessageBoxButtons::YesNo, MessageBoxIcon::Question);
							if (mb == System::Windows::Forms::DialogResult::Yes)
							{
								MessageBox::Show("Хорошо что вы передумали,закрываюсь!");
								this->Close();
							}
							else
							{
								MessageBox::Show("Ладно,работайте.Но перед этим вам нужно согласиться с лицензионным соглашением!");
								this->Hide();
								frmLicenseAgreement ^frm = gcnew frmLicenseAgreement();
								frm->ShowDialog();
								this->Show();
							}
						}
					}
					else
					{
						MessageBox::Show("Я так и знал!");
						this->Close();
					}
				}
				else
				{
					MessageBox::Show("Ну значит выключаюсь!");
					this->Close();
				}
			}
			else
			{
				MessageBox::Show("Ну и не надо!");
				this->Close();
			}
		}
		else
		{
			MessageBox::Show("Ну и не надо!");
			this->Close();
		}
	}

	
	private: System::Void rbPlatka_CheckedChanged(System::Object^  sender, System::EventArgs^  e) {
		if (rbPlatka->Checked)
		{
			cbPayment->Visible = true;
		}
		else
		{
			cbPayment->Checked = false;
			cbPayment->Visible = false;
		}
	}

	private: System::Void tbCourse_TextChanged(System::Object^  sender, System::EventArgs^  e) {

		if (Cheked)
		{
			if (tbCourse->TextLength > 0)
			{
				tbCourse->Text = tbCourse->Text[0].ToString();
			}
			Cheked = false;
		}
		else
		{
			if (tbCourse->TextLength > 1)
			{
				tbCourse->Text="1";
				switch (Kol)
				{
				case 0:
				{
					MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nБудьте внимательней!");
					Kol++;
					break;
				}
				case 1:
				{
					MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nБудьте внимательней!");
					Kol++;
					break;
				}
				case 2:
				{
					MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nЭто ваше 3 предупреждение,аккуратней!");
					Kol++;
					break;
				}
				case 3:
				{
					MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
					Kol++;
					break;
				}
				case 4:
				{
					MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
					this->Hide();
					Block ^bl = gcnew Block();
					bl->ShowDialog();
					this->Show();
					Kol = 0;
					break;
				}
				}
			}
			else
			{
				if (tbCourse->Text[0] <= 48 || tbCourse->Text[0] >= 54)
				{
					tbCourse->Text = "1";
					switch (Kol)
					{
					case 0:
					{
						MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nБудьте внимательней!");
						Kol++;
						break;
					}
					case 1:
					{
						MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nБудьте внимательней!");
						Kol++;
						break;
					}
					case 2:
					{
						MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nЭто ваше 3 предупреждение,аккуратней!");
						Kol++;
						break;
					}
					case 3:
					{
						MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
						Kol++;
						break;
					}
					case 4:
					{
						MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
						this->Hide();
						Block ^bl = gcnew Block();
						bl->ShowDialog();
						this->Show();
						Kol = 0;
						break;
					}
					}
				}
			}
		}
		
	}
	private: System::Void tbCourse_KeyPress(System::Object^  sender, System::Windows::Forms::KeyPressEventArgs^  e) {
		if ((e->KeyChar <= 48 || e->KeyChar >= 54) && e->KeyChar != 8)
		{
			e->Handled = true;
			switch (Kol)
				{
			case 0:
			{
				MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nБудьте внимательней!");
				Kol++;
				break;
			}
			case 1:
			{
				MessageBox::Show("В данное поле можно вводить только1 цифру [1,5]\n\nБудьте внимательней!");
				Kol++;
				break;
			}
			case 2:
			{
				MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nЭто ваше 3 предупреждение,аккуратней!");
				Kol++;
				break;
			}
			case 3:
			{
				MessageBox::Show("В данное поле можно вводить только 1 цифру [1,5]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
				Kol++;
				break;
			}
			case 4:
			{
				MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
				this->Hide();
				Block ^bl = gcnew Block();
				bl->ShowDialog();
				this->Show();
				Kol=0;
				break;
			}
				}
			
			return;
		}
		Cheked = true;
	}
	private: System::Void MyForm_KeyPress(System::Object^  sender, System::Windows::Forms::KeyPressEventArgs^  e) {
		//MessageBox::Show(Convert::ToInt32(e->KeyChar).ToString());
		if (e->KeyChar == 1)
		{
			if (tbCourse->Text!="" && tbFaculty->Text!="" && tbMarks->Text != "" && tbName->Text != "" && rbBudget->Checked)
			{
				MessageBox::Show("Бюджетник добавлен");
				Head = Head->Push(Head, tbName->Text, tbFaculty->Text, Convert::ToInt32(tbCourse->Text), tbMarks->Text);
			}
			else if(rbPlatka->Checked)
			{
				MessageBox::Show("Платник добавлен");
				Head = Head->Push(Head, tbName->Text, tbFaculty->Text, Convert::ToInt32(tbCourse->Text), tbMarks->Text,cbPayment->Checked);
			}
			else
			{
				MessageBox::Show("Нехватка данных!");
			}
		}
		else if (e->KeyChar == 4)
		{
			Head = Head->Del(Head,tbName->Text);
		}
	}

	private: System::Void tbMarks_KeyPress(System::Object^  sender, System::Windows::Forms::KeyPressEventArgs^  e) {
		if ((e->KeyChar <= 47 || e->KeyChar >= 58) && e->KeyChar != 8 && e->KeyChar != 32)
		{
			e->Handled = true;
			switch (Kol)
			{
			case 0:
			{
				MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
				Kol++;
				break;
			}
			case 1:
			{
				MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
				Kol++;
				break;
			}
			case 2:
			{
				MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 3 предупреждение,аккуратней!");
				Kol++;
				break;
			}
			case 3:
			{
				MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
				Kol++;
				break;
			}
			case 4:
			{
				MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
				this->Hide();
				Block ^bl = gcnew Block();
				bl->ShowDialog();
				this->Show();
				Kol = 0;
				break;
			}
			}
			return;
		}
		else
		{
			if (e->KeyChar == 8)
			{
				return;
			}
			if (tbMarks->TextLength > 0)
			{
				if (e->KeyChar == 48)
				{
					if (tbMarks->Text[tbMarks->TextLength - 1] != 49)
					{
						e->Handled = true;
						return;
					}
				}
				else if (e->KeyChar == 32)
				{
					if (tbMarks->Text[tbMarks->TextLength - 1] == 32)
					{
						e->Handled = true;
						return;
					}
				}
				else
				{
					if (tbMarks->Text[tbMarks->TextLength - 1] != 32)
					{
						e->Handled = true;
						return;
					}
				}
			}
			else
			{
				if (e->KeyChar == 48)
				{
					e->Handled = true;
					return;
				}
				if (e->KeyChar == 32)
				{
					e->Handled = true;
					return;
				}
			}
		}
	}

	private: System::Void tbMarks_TextChanged(System::Object^  sender, System::EventArgs^  e) {

			if (tbMarks->TextLength > 0)
			{
				if (tbMarks->Text[0] <= 48 || tbMarks->Text[0] >= 58)
				{
					tbMarks->Clear();
					MessageBox::Show("Вставляемая строка имеет не правильный формат!");//Проверить
					switch (Kol)
					{
					case 0:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
						Kol++;
						break;
					}
					case 1:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
						Kol++;
						break;
					}
					case 2:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 3 предупреждение,аккуратней!");
						Kol++;
						break;
					}
					case 3:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
						Kol++;
						break;
					}
					case 4:
					{
						MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
						this->Hide();
						Block ^bl = gcnew Block();
						bl->ShowDialog();
						this->Show();
						Kol = 0;
						break;
					}
					}
					return;
				}
			}
			else
			{
				return;
			}

			for (int i=1;i<tbMarks->TextLength;i++)
			{
				if ( tbMarks->Text[i] > 47 || tbMarks->Text[i] < 58 || tbMarks->Text[i] == 32)
				{
					if (tbMarks->Text[i] == 48 && tbMarks->Text[i-1] != 49)
					{
						tbMarks->Clear();
						MessageBox::Show("Вставляемая строка имеет не правильный формат!");//Проверить
						switch (Kol)
						{
						case 0:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
							Kol++;
							break;
						}
						case 1:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
							Kol++;
							break;
						}
						case 2:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 3 предупреждение,аккуратней!");
							Kol++;
							break;
						}
						case 3:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
							Kol++;
							break;
						}
						case 4:
						{
							MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
							this->Hide();
							Block ^bl = gcnew Block();
							bl->ShowDialog();
							this->Show();
							Kol = 0;
							break;
						}
						}
						return;
					}
					
					if (tbMarks->Text[i] == 32 && tbMarks->Text[i - 1] == 32)
					{
						tbMarks->Clear();
						MessageBox::Show("Вставляемая строка имеет не правильный формат!");//Проверить
						switch (Kol)
						{
						case 0:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
							Kol++;
							break;
						}
						case 1:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
							Kol++;
							break;
						}
						case 2:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 3 предупреждение,аккуратней!");
							Kol++;
							break;
						}
						case 3:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
							Kol++;
							break;
						}
						case 4:
						{
							MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
							this->Hide();
							Block ^bl = gcnew Block();
							bl->ShowDialog();
							this->Show();
							Kol = 0;
							break;
						}
						}
						return;
					}

					if (tbMarks->Text[i]!=32 && tbMarks->Text[i] != 48 && tbMarks->Text[i-1] != 32)
					{
						tbMarks->Clear();
						MessageBox::Show("Вставляемая строка имеет не правильный формат!");//Проверить
						switch (Kol)
						{
						case 0:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
							Kol++;
							break;
						}
						case 1:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
							Kol++;
							break;
						}
						case 2:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 3 предупреждение,аккуратней!");
							Kol++;
							break;
						}
						case 3:
						{
							MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
							Kol++;
							break;
						}
						case 4:
						{
							MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
							this->Hide();
							Block ^bl = gcnew Block();
							bl->ShowDialog();
							this->Show();
							Kol = 0;
							break;
						}
						}
						return;
					}
				}
				else
				{
					tbMarks->Clear();
					MessageBox::Show("Вставляемая строка имеет не правильный формат!");//Проверить
					switch (Kol)
					{
					case 0:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
						Kol++;
						break;
					}
					case 1:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nБудьте внимательней!");
						Kol++;
						break;
					}
					case 2:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 3 предупреждение,аккуратней!");
						Kol++;
						break;
					}
					case 3:
					{
						MessageBox::Show("В данное поле можно вводить только числа [1,10]\n\nЭто ваше 4 предупреждение.Появляется ощущение что вы хотите сломать данную программу");
						Kol++;
						break;
					}
					case 4:
					{
						MessageBox::Show("5 предупреждение.\nВы либо слишком невнимательны,либо пытаетесь сломать данную программу.\nВ любом случае ваш компьютер блокируется на 1 минуту для профилактики!");
						this->Hide();
						Block ^bl = gcnew Block();
						bl->ShowDialog();
						this->Show();
						Kol = 0;
						break;
					}
					}
					return;
				}
			}
	}

	private: System::Void btnInfo_Click(System::Object^  sender, System::EventArgs^  e) {
		rtbOutput->Text = "                                               Информация\n\n";
		Head->ShowInfo(Head,rtbOutput);
	}

	private: System::Void btnNextStep_Click(System::Object^  sender, System::EventArgs^  e) {
		rtbOutput->Text = "                                               Информация о переводе на следующий курс\n\n";
		Head->NextStep(Head, rtbOutput);
	}
	private: System::Void btnScholarship_Click(System::Object^  sender, System::EventArgs^  e) {
		rtbOutput->Text = "                                               Стипендия\n\n";
		Head->ShowScholarship(Head, rtbOutput);
	}

};
}
