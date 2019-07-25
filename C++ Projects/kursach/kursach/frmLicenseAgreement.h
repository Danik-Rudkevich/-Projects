#pragma once

namespace kursach {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for frmLicenseAgreement
	/// </summary>
	public ref class frmLicenseAgreement : public System::Windows::Forms::Form
	{
	public:
		frmLicenseAgreement(void)
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
		~frmLicenseAgreement()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::RichTextBox^  rtb;
	protected:
	private: System::Windows::Forms::CheckBox^  cbAgree;
	private: System::Windows::Forms::Button^  btn;

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
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(frmLicenseAgreement::typeid));
			this->rtb = (gcnew System::Windows::Forms::RichTextBox());
			this->cbAgree = (gcnew System::Windows::Forms::CheckBox());
			this->btn = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// rtb
			// 
			this->rtb->Dock = System::Windows::Forms::DockStyle::Top;
			this->rtb->Location = System::Drawing::Point(0, 0);
			this->rtb->Name = L"rtb";
			this->rtb->ReadOnly = true;
			this->rtb->Size = System::Drawing::Size(700, 399);
			this->rtb->TabIndex = 0;
			this->rtb->Text = resources->GetString(L"rtb.Text");
			// 
			// cbAgree
			// 
			this->cbAgree->AutoSize = true;
			this->cbAgree->Location = System::Drawing::Point(13, 406);
			this->cbAgree->Name = L"cbAgree";
			this->cbAgree->Size = System::Drawing::Size(378, 17);
			this->cbAgree->TabIndex = 1;
			this->cbAgree->Text = L"Я согласен(а) с условиями и хочу приступить к работе с программой";
			this->cbAgree->UseVisualStyleBackColor = true;
			this->cbAgree->CheckedChanged += gcnew System::EventHandler(this, &frmLicenseAgreement::cbAgree_CheckedChanged);
			// 
			// btn
			// 
			this->btn->Location = System::Drawing::Point(398, 406);
			this->btn->Name = L"btn";
			this->btn->Size = System::Drawing::Size(290, 23);
			this->btn->TabIndex = 2;
			this->btn->Text = L"Просто кнопка";
			this->btn->UseVisualStyleBackColor = true;
			this->btn->Click += gcnew System::EventHandler(this, &frmLicenseAgreement::btn_Click);
			// 
			// frmLicenseAgreement
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(700, 441);
			this->Controls->Add(this->btn);
			this->Controls->Add(this->cbAgree);
			this->Controls->Add(this->rtb);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"frmLicenseAgreement";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"Соглашение";
			this->FormClosing += gcnew System::Windows::Forms::FormClosingEventHandler(this, &frmLicenseAgreement::frmLicenseAgreement_FormClosing);
			this->Load += gcnew System::EventHandler(this, &frmLicenseAgreement::frmLicenseAgreement_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btn_Click(System::Object^  sender, System::EventArgs^  e) {
		MessageBox::Show("Это совершенно обычная кнопка!\nА вы ожидали чего-то другого ?");
	}

	private: System::Void frmLicenseAgreement_FormClosing(System::Object^  sender, System::Windows::Forms::FormClosingEventArgs^  e) {
		if (!cbAgree->Checked)
		{
			Application::Exit();
			MessageBox::Show("Ну раз не хотите , то и не надо!");

		}
		
	}
private: System::Void cbAgree_CheckedChanged(System::Object^  sender, System::EventArgs^  e) {
	this->Close();
}

private: System::Void frmLicenseAgreement_Load(System::Object^  sender, System::EventArgs^  e) {
}
};
}
