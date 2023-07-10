namespace bookRecommendation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxBookList = new GroupBox();
            btnDeleteBook = new Button();
            dgwBooks = new DataGridView();
            gbxAddBook = new GroupBox();
            cbxAddAuthor = new ComboBox();
            lblBookAuthor = new Label();
            lblBookDescription = new Label();
            tbxBookAddDescription = new TextBox();
            lblBookName = new Label();
            tbxBookAddName = new TextBox();
            btnAddBook = new Button();
            gbxUpdateBook = new GroupBox();
            lblBooksUpdateId = new Label();
            tbxBooksUpdateId = new TextBox();
            cbxBooksUpdateAuthor = new ComboBox();
            lblBooksUpdateAuthor = new Label();
            lblBooksUpdateDescription = new Label();
            tbxBooksUpdateDescription = new TextBox();
            lblBooksUpdateName = new Label();
            tbxBooksUpdateName = new TextBox();
            btnUpdateBook = new Button();
            tabBooks = new TabControl();
            tabBookPage = new TabPage();
            tabAuthorPage = new TabPage();
            groupBox1 = new GroupBox();
            btnDeleteAuthor = new Button();
            dgwAuthors = new DataGridView();
            gbxUpdateAuthor = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            tbxUpdateAuthorId = new TextBox();
            tbxUpdateAuthorName = new TextBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            tbxAddAuthorName = new TextBox();
            button3 = new Button();
            tabPage1 = new TabPage();
            lblRecommendedBookName = new Label();
            label3 = new Label();
            label4 = new Label();
            gbxBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwBooks).BeginInit();
            gbxAddBook.SuspendLayout();
            gbxUpdateBook.SuspendLayout();
            tabBooks.SuspendLayout();
            tabBookPage.SuspendLayout();
            tabAuthorPage.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAuthors).BeginInit();
            gbxUpdateAuthor.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxBookList
            // 
            gbxBookList.Controls.Add(btnDeleteBook);
            gbxBookList.Controls.Add(dgwBooks);
            gbxBookList.Location = new Point(37, 36);
            gbxBookList.Name = "gbxBookList";
            gbxBookList.Size = new Size(715, 237);
            gbxBookList.TabIndex = 0;
            gbxBookList.TabStop = false;
            gbxBookList.Text = "Kitaplar";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(6, 15);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(81, 23);
            btnDeleteBook.TabIndex = 1;
            btnDeleteBook.Text = "Sil";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // dgwBooks
            // 
            dgwBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBooks.Location = new Point(6, 44);
            dgwBooks.Name = "dgwBooks";
            dgwBooks.RowTemplate.Height = 25;
            dgwBooks.Size = new Size(703, 187);
            dgwBooks.TabIndex = 0;
            dgwBooks.CellDoubleClick += dgwBooks_CellDoubleClick;
            // 
            // gbxAddBook
            // 
            gbxAddBook.Controls.Add(cbxAddAuthor);
            gbxAddBook.Controls.Add(lblBookAuthor);
            gbxAddBook.Controls.Add(lblBookDescription);
            gbxAddBook.Controls.Add(tbxBookAddDescription);
            gbxAddBook.Controls.Add(lblBookName);
            gbxAddBook.Controls.Add(tbxBookAddName);
            gbxAddBook.Controls.Add(btnAddBook);
            gbxAddBook.Location = new Point(37, 279);
            gbxAddBook.Name = "gbxAddBook";
            gbxAddBook.Size = new Size(359, 354);
            gbxAddBook.TabIndex = 1;
            gbxAddBook.TabStop = false;
            gbxAddBook.Text = "Kitap Ekle";
            gbxAddBook.Enter += gbxAddBook_Enter;
            // 
            // cbxAddAuthor
            // 
            cbxAddAuthor.FormattingEnabled = true;
            cbxAddAuthor.Location = new Point(32, 205);
            cbxAddAuthor.Name = "cbxAddAuthor";
            cbxAddAuthor.Size = new Size(306, 23);
            cbxAddAuthor.TabIndex = 7;
            // 
            // lblBookAuthor
            // 
            lblBookAuthor.AutoSize = true;
            lblBookAuthor.Location = new Point(32, 187);
            lblBookAuthor.Name = "lblBookAuthor";
            lblBookAuthor.Size = new Size(67, 15);
            lblBookAuthor.TabIndex = 6;
            lblBookAuthor.Text = "Kitap Yazarı";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Location = new Point(32, 132);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(94, 15);
            lblBookDescription.TabIndex = 4;
            lblBookDescription.Text = "Kitap Açıklaması";
            // 
            // tbxBookAddDescription
            // 
            tbxBookAddDescription.Location = new Point(32, 150);
            tbxBookAddDescription.Name = "tbxBookAddDescription";
            tbxBookAddDescription.Size = new Size(306, 23);
            tbxBookAddDescription.TabIndex = 3;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(32, 82);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(55, 15);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Kitap Adı";
            // 
            // tbxBookAddName
            // 
            tbxBookAddName.Location = new Point(32, 100);
            tbxBookAddName.Name = "tbxBookAddName";
            tbxBookAddName.Size = new Size(306, 23);
            tbxBookAddName.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBook.Location = new Point(32, 234);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(306, 47);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Ekle";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // gbxUpdateBook
            // 
            gbxUpdateBook.Controls.Add(lblBooksUpdateId);
            gbxUpdateBook.Controls.Add(tbxBooksUpdateId);
            gbxUpdateBook.Controls.Add(cbxBooksUpdateAuthor);
            gbxUpdateBook.Controls.Add(lblBooksUpdateAuthor);
            gbxUpdateBook.Controls.Add(lblBooksUpdateDescription);
            gbxUpdateBook.Controls.Add(tbxBooksUpdateDescription);
            gbxUpdateBook.Controls.Add(lblBooksUpdateName);
            gbxUpdateBook.Controls.Add(tbxBooksUpdateName);
            gbxUpdateBook.Controls.Add(btnUpdateBook);
            gbxUpdateBook.Location = new Point(402, 279);
            gbxUpdateBook.Name = "gbxUpdateBook";
            gbxUpdateBook.Size = new Size(350, 354);
            gbxUpdateBook.TabIndex = 2;
            gbxUpdateBook.TabStop = false;
            gbxUpdateBook.Text = "Kitap Güncelle";
            gbxUpdateBook.Visible = false;
            // 
            // lblBooksUpdateId
            // 
            lblBooksUpdateId.AutoSize = true;
            lblBooksUpdateId.Location = new Point(22, 38);
            lblBooksUpdateId.Name = "lblBooksUpdateId";
            lblBooksUpdateId.Size = new Size(53, 15);
            lblBooksUpdateId.TabIndex = 16;
            lblBooksUpdateId.Text = "Kitap No";
            // 
            // tbxBooksUpdateId
            // 
            tbxBooksUpdateId.Enabled = false;
            tbxBooksUpdateId.Location = new Point(22, 56);
            tbxBooksUpdateId.Name = "tbxBooksUpdateId";
            tbxBooksUpdateId.Size = new Size(306, 23);
            tbxBooksUpdateId.TabIndex = 15;
            // 
            // cbxBooksUpdateAuthor
            // 
            cbxBooksUpdateAuthor.FormattingEnabled = true;
            cbxBooksUpdateAuthor.Location = new Point(22, 205);
            cbxBooksUpdateAuthor.Name = "cbxBooksUpdateAuthor";
            cbxBooksUpdateAuthor.Size = new Size(306, 23);
            cbxBooksUpdateAuthor.TabIndex = 14;
            // 
            // lblBooksUpdateAuthor
            // 
            lblBooksUpdateAuthor.AutoSize = true;
            lblBooksUpdateAuthor.Location = new Point(22, 187);
            lblBooksUpdateAuthor.Name = "lblBooksUpdateAuthor";
            lblBooksUpdateAuthor.Size = new Size(67, 15);
            lblBooksUpdateAuthor.TabIndex = 13;
            lblBooksUpdateAuthor.Text = "Kitap Yazarı";
            // 
            // lblBooksUpdateDescription
            // 
            lblBooksUpdateDescription.AutoSize = true;
            lblBooksUpdateDescription.Location = new Point(22, 132);
            lblBooksUpdateDescription.Name = "lblBooksUpdateDescription";
            lblBooksUpdateDescription.Size = new Size(94, 15);
            lblBooksUpdateDescription.TabIndex = 12;
            lblBooksUpdateDescription.Text = "Kitap Açıklaması";
            // 
            // tbxBooksUpdateDescription
            // 
            tbxBooksUpdateDescription.Location = new Point(22, 150);
            tbxBooksUpdateDescription.Name = "tbxBooksUpdateDescription";
            tbxBooksUpdateDescription.Size = new Size(306, 23);
            tbxBooksUpdateDescription.TabIndex = 11;
            // 
            // lblBooksUpdateName
            // 
            lblBooksUpdateName.AutoSize = true;
            lblBooksUpdateName.Location = new Point(22, 82);
            lblBooksUpdateName.Name = "lblBooksUpdateName";
            lblBooksUpdateName.Size = new Size(55, 15);
            lblBooksUpdateName.TabIndex = 10;
            lblBooksUpdateName.Text = "Kitap Adı";
            // 
            // tbxBooksUpdateName
            // 
            tbxBooksUpdateName.Location = new Point(22, 100);
            tbxBooksUpdateName.Name = "tbxBooksUpdateName";
            tbxBooksUpdateName.Size = new Size(306, 23);
            tbxBooksUpdateName.TabIndex = 9;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateBook.Location = new Point(22, 234);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(306, 47);
            btnUpdateBook.TabIndex = 1;
            btnUpdateBook.Text = "Güncelle";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // tabBooks
            // 
            tabBooks.Controls.Add(tabBookPage);
            tabBooks.Controls.Add(tabAuthorPage);
            tabBooks.Controls.Add(tabPage1);
            tabBooks.Location = new Point(3, 2);
            tabBooks.Name = "tabBooks";
            tabBooks.SelectedIndex = 0;
            tabBooks.Size = new Size(830, 670);
            tabBooks.TabIndex = 2;
            // 
            // tabBookPage
            // 
            tabBookPage.Controls.Add(gbxBookList);
            tabBookPage.Controls.Add(gbxUpdateBook);
            tabBookPage.Controls.Add(gbxAddBook);
            tabBookPage.Location = new Point(4, 24);
            tabBookPage.Name = "tabBookPage";
            tabBookPage.Padding = new Padding(3);
            tabBookPage.Size = new Size(822, 642);
            tabBookPage.TabIndex = 0;
            tabBookPage.Text = "Kitaplar";
            tabBookPage.UseVisualStyleBackColor = true;
            // 
            // tabAuthorPage
            // 
            tabAuthorPage.Controls.Add(groupBox1);
            tabAuthorPage.Controls.Add(gbxUpdateAuthor);
            tabAuthorPage.Controls.Add(groupBox3);
            tabAuthorPage.Location = new Point(4, 24);
            tabAuthorPage.Name = "tabAuthorPage";
            tabAuthorPage.Padding = new Padding(3);
            tabAuthorPage.Size = new Size(822, 642);
            tabAuthorPage.TabIndex = 1;
            tabAuthorPage.Text = "Yazarlar";
            tabAuthorPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteAuthor);
            groupBox1.Controls.Add(dgwAuthors);
            groupBox1.Location = new Point(54, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 237);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitaplar";
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(6, 15);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(81, 23);
            btnDeleteAuthor.TabIndex = 1;
            btnDeleteAuthor.Text = "Sil";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // dgwAuthors
            // 
            dgwAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAuthors.Location = new Point(6, 44);
            dgwAuthors.Name = "dgwAuthors";
            dgwAuthors.RowTemplate.Height = 25;
            dgwAuthors.Size = new Size(703, 187);
            dgwAuthors.TabIndex = 0;
            dgwAuthors.CellDoubleClick += dgwAuthors_CellDoubleClick;
            // 
            // gbxUpdateAuthor
            // 
            gbxUpdateAuthor.Controls.Add(label2);
            gbxUpdateAuthor.Controls.Add(label1);
            gbxUpdateAuthor.Controls.Add(tbxUpdateAuthorId);
            gbxUpdateAuthor.Controls.Add(tbxUpdateAuthorName);
            gbxUpdateAuthor.Controls.Add(button2);
            gbxUpdateAuthor.Location = new Point(419, 266);
            gbxUpdateAuthor.Name = "gbxUpdateAuthor";
            gbxUpdateAuthor.Size = new Size(350, 211);
            gbxUpdateAuthor.TabIndex = 5;
            gbxUpdateAuthor.TabStop = false;
            gbxUpdateAuthor.Text = "Yazar Güncelle";
            gbxUpdateAuthor.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 28);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 16;
            label2.Text = "Yazar No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 82);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 16;
            label1.Text = "Yazar Adı";
            // 
            // tbxUpdateAuthorId
            // 
            tbxUpdateAuthorId.Enabled = false;
            tbxUpdateAuthorId.Location = new Point(22, 46);
            tbxUpdateAuthorId.Name = "tbxUpdateAuthorId";
            tbxUpdateAuthorId.Size = new Size(306, 23);
            tbxUpdateAuthorId.TabIndex = 15;
            // 
            // tbxUpdateAuthorName
            // 
            tbxUpdateAuthorName.Location = new Point(22, 100);
            tbxUpdateAuthorName.Name = "tbxUpdateAuthorName";
            tbxUpdateAuthorName.Size = new Size(306, 23);
            tbxUpdateAuthorName.TabIndex = 15;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(22, 132);
            button2.Name = "button2";
            button2.Size = new Size(306, 47);
            button2.TabIndex = 1;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tbxAddAuthorName);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(54, 266);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(359, 211);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yazar Ekle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 82);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 2;
            label7.Text = "Yazar Adı";
            // 
            // tbxAddAuthorName
            // 
            tbxAddAuthorName.Location = new Point(32, 100);
            tbxAddAuthorName.Name = "tbxAddAuthorName";
            tbxAddAuthorName.Size = new Size(306, 23);
            tbxAddAuthorName.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(32, 132);
            button3.Name = "button3";
            button3.Size = new Size(306, 47);
            button3.TabIndex = 0;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(lblRecommendedBookName);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(822, 642);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Günün Kitabı";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRecommendedBookName
            // 
            lblRecommendedBookName.AutoSize = true;
            lblRecommendedBookName.ForeColor = Color.Red;
            lblRecommendedBookName.Location = new Point(316, 68);
            lblRecommendedBookName.Name = "lblRecommendedBookName";
            lblRecommendedBookName.Size = new Size(49, 15);
            lblRecommendedBookName.TabIndex = 1;
            lblRecommendedBookName.Text = "              ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 20);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 0;
            label3.Text = "Her Gün Yeni bir kitap Önerisi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 68);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 2;
            label4.Text = "Günün Kitabı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 671);
            Controls.Add(tabBooks);
            Name = "Form1";
            Text = "Kitaplar & Yazarlar";
            Load += Form1_Load;
            gbxBookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwBooks).EndInit();
            gbxAddBook.ResumeLayout(false);
            gbxAddBook.PerformLayout();
            gbxUpdateBook.ResumeLayout(false);
            gbxUpdateBook.PerformLayout();
            tabBooks.ResumeLayout(false);
            tabBookPage.ResumeLayout(false);
            tabAuthorPage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwAuthors).EndInit();
            gbxUpdateAuthor.ResumeLayout(false);
            gbxUpdateAuthor.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxBookList;
        private GroupBox gbxAddBook;
        private GroupBox gbxUpdateBook;
        private Button btnDeleteBook;
        private DataGridView dgwBooks;
        private TabControl tabBooks;
        private TabPage tabBookPage;
        private TabPage tabAuthorPage;
        private Button btnAddBook;
        private Label lblBookAuthor;
        private Label lblBookDescription;
        private TextBox tbxBookAddDescription;
        private Label lblBookName;
        private TextBox tbxBookAddName;
        private Button btnUpdateBook;
        private ComboBox cbxAddAuthor;
        private Label lblBooksUpdateId;
        private TextBox tbxBooksUpdateId;
        private ComboBox cbxBooksUpdateAuthor;
        private Label lblBooksUpdateAuthor;
        private Label lblBooksUpdateDescription;
        private TextBox tbxBooksUpdateDescription;
        private Label lblBooksUpdateName;
        private TextBox tbxBooksUpdateName;
        private GroupBox groupBox1;
        private Button btnDeleteAuthor;
        private DataGridView dgwAuthors;
        private GroupBox gbxUpdateAuthor;
        private Label label1;
        private TextBox tbxUpdateAuthorName;
        private Button button2;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox tbxAddAuthorName;
        private Button button3;
        private Label label2;
        private TextBox tbxUpdateAuthorId;
        private TabPage tabPage1;
        private Label lblRecommendedBookName;
        private Label label3;
        private Label label4;
    }
}