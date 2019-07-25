#pragma once

namespace kursach {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Collections::Generic;

	/// <summary>
	/// Summary for Block
	/// </summary>
	public ref class Block : public System::Windows::Forms::Form
	{
	public:
		Block(void)
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
		~Block()
		{
			if (components)
			{
				delete components;
			}
		}

	private: System::Windows::Forms::Timer^  tClose;
	private: System::ComponentModel::IContainer^  components;
	private: System::Windows::Forms::PictureBox^  pbDraw;

	private: System::Windows::Forms::Label^  lblTimer;

	protected:

	protected:
		bool Ok = false;
		Graphics ^g; //Объект Graphics для рисования
		List <Point> ^points; //точки; подлючен using namespace System::Collections::Generic;
		Pen ^ pen; //перо
		bool draw; //флажок перерисовки
	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Block::typeid));
			this->tClose = (gcnew System::Windows::Forms::Timer(this->components));
			this->pbDraw = (gcnew System::Windows::Forms::PictureBox());
			this->lblTimer = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbDraw))->BeginInit();
			this->SuspendLayout();
			// 
			// tClose
			// 
			this->tClose->Enabled = true;
			this->tClose->Interval = 1000;
			this->tClose->Tick += gcnew System::EventHandler(this, &Block::tClose_Tick);
			// 
			// pbDraw
			// 
			this->pbDraw->BackColor = System::Drawing::Color::Transparent;
			this->pbDraw->Dock = System::Windows::Forms::DockStyle::Fill;
			this->pbDraw->Location = System::Drawing::Point(0, 0);
			this->pbDraw->Name = L"pbDraw";
			this->pbDraw->Size = System::Drawing::Size(1421, 766);
			this->pbDraw->TabIndex = 0;
			this->pbDraw->TabStop = false;
			this->pbDraw->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &Block::pbDraw_Paint);
			this->pbDraw->DoubleClick += gcnew System::EventHandler(this, &Block::pbDraw_DoubleClick);
			this->pbDraw->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &Block::pbDraw_MouseDown);
			this->pbDraw->MouseMove += gcnew System::Windows::Forms::MouseEventHandler(this, &Block::pbDraw_MouseMove);
			this->pbDraw->MouseUp += gcnew System::Windows::Forms::MouseEventHandler(this, &Block::pbDraw_MouseUp);
			// 
			// lblTimer
			// 
			this->lblTimer->AutoSize = true;
			this->lblTimer->BackColor = System::Drawing::Color::Transparent;
			this->lblTimer->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 36, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblTimer->Location = System::Drawing::Point(1159, 557);
			this->lblTimer->Name = L"lblTimer";
			this->lblTimer->Size = System::Drawing::Size(78, 55);
			this->lblTimer->TabIndex = 1;
			this->lblTimer->Text = L"60";
			// 
			// Block
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackgroundImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"$this.BackgroundImage")));
			this->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Stretch;
			this->ClientSize = System::Drawing::Size(1421, 766);
			this->Controls->Add(this->lblTimer);
			this->Controls->Add(this->pbDraw);
			this->Cursor = System::Windows::Forms::Cursors::No;
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->KeyPreview = true;
			this->Name = L"Block";
			this->Text = L"Block";
			this->TopMost = true;
			this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
			this->FormClosing += gcnew System::Windows::Forms::FormClosingEventHandler(this, &Block::Block_FormClosing);
			this->Load += gcnew System::EventHandler(this, &Block::Block_Load);
			this->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &Block::Block_KeyPress);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbDraw))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void Block_FormClosing(System::Object^  sender, System::Windows::Forms::FormClosingEventArgs^  e) {
		if (!Ok)
		{
			e->Cancel = true;
			MessageBox::Show("Хахаха.Думали всё так просто?");
		}	
	}

	private: System::Void tClose_Tick(System::Object^  sender, System::EventArgs^  e) {
		lblTimer->Text = (Convert::ToInt32(lblTimer->Text) - 1).ToString();

		if (Convert::ToInt32(lblTimer->Text)==0)
		{
			Ok = true;
			this->Close();
		}
	}
	private: System::Void pbDraw_Paint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
		if (points->Count > 1)
		{
			g->DrawLines(pen, points->ToArray());//рисуем линию по точкам
		}
	}
	private: System::Void Block_Load(System::Object^  sender, System::EventArgs^  e) {
		Bitmap ^ Img = gcnew Bitmap(pbDraw->Width, pbDraw->Height);//Переменная в которой будет формироваться наше изображение
		g = Graphics::FromImage(Img);//Создаём новую графику из задоного изображения 
		pbDraw->Image = Img;//Ложим наше изображение в pbDraw
		pen = gcnew Pen(Color::Red);//Устанавливаем цвет пера
		points = gcnew List <Point>();//Создаем наш массив для хранения точек 
		draw = false;//Отключаем рисование
	}	
	private: System::Void pbDraw_MouseDown(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
		points->Clear();//Очищаем массив points благодоря чему мы можем добалять новые линии которые не будут связаны со старыми
		points->Add(e->Location);//Помещаем в массив координаты точки 
		draw = true;//Разрешаем рисование
		pbDraw->Invalidate();//Перерисовываем pbDraw
	}
	private: System::Void pbDraw_MouseUp(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
		draw = false;//Заканчиваем рисование
		pbDraw->Invalidate();//Перерисовываем pbDraw
	}
	private: System::Void pbDraw_MouseMove(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
		if (draw && points->Contains(Point(e->X, e->Y)) == false)
		{
			//если включён флажок и текущая точка не содержится в списке точек
			if (e->Button == System::Windows::Forms::MouseButtons::Left)
			{
				//если нажата левая кнопка
				points->Add(e->Location);//Помещаем в массив координаты точки 
				pbDraw->Invalidate();//Перерисовываем pbDraw
			}
		}
	}
	private: System::Void pbDraw_DoubleClick(System::Object^  sender, System::EventArgs^  e) {
		Bitmap ^ Img = gcnew Bitmap(pbDraw->Width, pbDraw->Height);//Переменная в которой будет формироваться наше изображение
		g = Graphics::FromImage(Img);//Создаём новую графику из задоного изображения 
		pbDraw->Image = Img;//Ложим наше изображение в pbDraw
	}
	private: System::Void Block_KeyPress(System::Object^  sender, System::Windows::Forms::KeyPressEventArgs^  e) {
		switch (e->KeyChar)
		{
		case '1':
		{
			pen = gcnew Pen(Color::Black);
			break;
		}
		case '2':
		{
			pen = gcnew Pen(Color::Blue);
			break;
		}
		case '3':
		{
			pen = gcnew Pen(Color::Green);
			break;
		}
		case '4':
		{
			pen = gcnew Pen(Color::Yellow);
			break;
		}
		case '5':
		{
			pen = gcnew Pen(Color::Brown);
			break;
		}
		default:
			pen = gcnew Pen(Color::Red);
			break;
		}
	}
};
}
