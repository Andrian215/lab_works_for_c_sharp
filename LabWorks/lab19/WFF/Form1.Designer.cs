
namespace WindowsFormsApp1
{
    partial class Файл
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.додатиЕлементиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добутокЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.згенеруватиМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.максимальнийЕлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мінімальникйЕлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьВідємнихЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьДодатніхЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кільнмстьПарниїЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьНепарнихЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнєАрифметичнеЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнєГеометричнеЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.ShowDropDownArrow = false;
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Файл";
            this.toolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.згенеруватиМасивToolStripMenuItem,
            this.додатиЕлементиToolStripMenuItem,
            this.добутокЕлементівToolStripMenuItem,
            this.максимальнийЕлементToolStripMenuItem,
            this.мінімальникйЕлементToolStripMenuItem,
            this.кількістьВідємнихЕлементівToolStripMenuItem,
            this.кількістьДодатніхЕлементівToolStripMenuItem,
            this.кільнмстьПарниїЕлементівToolStripMenuItem,
            this.кількістьНепарнихЕлементівToolStripMenuItem,
            this.середнєАрифметичнеЕлементівToolStripMenuItem,
            this.середнєГеометричнеЕлементівToolStripMenuItem,
            this.елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem});
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.ShowDropDownArrow = false;
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Операції";
            // 
            // додатиЕлементиToolStripMenuItem
            // 
            this.додатиЕлементиToolStripMenuItem.Name = "додатиЕлементиToolStripMenuItem";
            this.додатиЕлементиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.додатиЕлементиToolStripMenuItem.Text = "Сума елементів";
            this.додатиЕлементиToolStripMenuItem.Click += new System.EventHandler(this.додатиЕлементиToolStripMenuItem_Click);
            // 
            // добутокЕлементівToolStripMenuItem
            // 
            this.добутокЕлементівToolStripMenuItem.Name = "добутокЕлементівToolStripMenuItem";
            this.добутокЕлементівToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.добутокЕлементівToolStripMenuItem.Text = "Добуток елементів";
            this.добутокЕлементівToolStripMenuItem.Click += new System.EventHandler(this.добутокЕлементівToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість елементів";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 66);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(117, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(363, 61);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // згенеруватиМасивToolStripMenuItem
            // 
            this.згенеруватиМасивToolStripMenuItem.Name = "згенеруватиМасивToolStripMenuItem";
            this.згенеруватиМасивToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.згенеруватиМасивToolStripMenuItem.Text = "Згенерувати Масив";
            this.згенеруватиМасивToolStripMenuItem.Click += new System.EventHandler(this.згенеруватиМасивToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // максимальнийЕлементToolStripMenuItem
            // 
            this.максимальнийЕлементToolStripMenuItem.Name = "максимальнийЕлементToolStripMenuItem";
            this.максимальнийЕлементToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.максимальнийЕлементToolStripMenuItem.Text = "Максимальний елемент";
            this.максимальнийЕлементToolStripMenuItem.Click += new System.EventHandler(this.максимальнийЕлементToolStripMenuItem_Click);
            // 
            // мінімальникйЕлементToolStripMenuItem
            // 
            this.мінімальникйЕлементToolStripMenuItem.Name = "мінімальникйЕлементToolStripMenuItem";
            this.мінімальникйЕлементToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.мінімальникйЕлементToolStripMenuItem.Text = "Мінімальникй елемент";
            this.мінімальникйЕлементToolStripMenuItem.Click += new System.EventHandler(this.мінімальникйЕлементToolStripMenuItem_Click);
            // 
            // кількістьВідємнихЕлементівToolStripMenuItem
            // 
            this.кількістьВідємнихЕлементівToolStripMenuItem.Name = "кількістьВідємнихЕлементівToolStripMenuItem";
            this.кількістьВідємнихЕлементівToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.кількістьВідємнихЕлементівToolStripMenuItem.Text = "Кількість від\'ємних елементів";
            this.кількістьВідємнихЕлементівToolStripMenuItem.Click += new System.EventHandler(this.кількістьВідємнихЕлементівToolStripMenuItem_Click);
            // 
            // кількістьДодатніхЕлементівToolStripMenuItem
            // 
            this.кількістьДодатніхЕлементівToolStripMenuItem.Name = "кількістьДодатніхЕлементівToolStripMenuItem";
            this.кількістьДодатніхЕлементівToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.кількістьДодатніхЕлементівToolStripMenuItem.Text = "Кількість додатніх елементів";
            this.кількістьДодатніхЕлементівToolStripMenuItem.Click += new System.EventHandler(this.кількістьДодатніхЕлементівToolStripMenuItem_Click);
            // 
            // кільнмстьПарниїЕлементівToolStripMenuItem
            // 
            this.кільнмстьПарниїЕлементівToolStripMenuItem.Name = "кільнмстьПарниїЕлементівToolStripMenuItem";
            this.кільнмстьПарниїЕлементівToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.кільнмстьПарниїЕлементівToolStripMenuItem.Text = "Кільнмсть парних елементів";
            this.кільнмстьПарниїЕлементівToolStripMenuItem.Click += new System.EventHandler(this.кільнмстьПарниїЕлементівToolStripMenuItem_Click);
            // 
            // кількістьНепарнихЕлементівToolStripMenuItem
            // 
            this.кількістьНепарнихЕлементівToolStripMenuItem.Name = "кількістьНепарнихЕлементівToolStripMenuItem";
            this.кількістьНепарнихЕлементівToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.кількістьНепарнихЕлементівToolStripMenuItem.Text = "Кількість непарних елементів";
            this.кількістьНепарнихЕлементівToolStripMenuItem.Click += new System.EventHandler(this.кількістьНепарнихЕлементівToolStripMenuItem_Click);
            // 
            // середнєАрифметичнеЕлементівToolStripMenuItem
            // 
            this.середнєАрифметичнеЕлементівToolStripMenuItem.Name = "середнєАрифметичнеЕлементівToolStripMenuItem";
            this.середнєАрифметичнеЕлементівToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.середнєАрифметичнеЕлементівToolStripMenuItem.Text = "Середнє арифметичне елементів";
            this.середнєАрифметичнеЕлементівToolStripMenuItem.Click += new System.EventHandler(this.середнєАрифметичнеЕлементівToolStripMenuItem_Click);
            // 
            // середнєГеометричнеЕлементівToolStripMenuItem
            // 
            this.середнєГеометричнеЕлементівToolStripMenuItem.Name = "середнєГеометричнеЕлементівToolStripMenuItem";
            this.середнєГеометричнеЕлементівToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.середнєГеометричнеЕлементівToolStripMenuItem.Text = "Середнє геометричне елементів";
            this.середнєГеометричнеЕлементівToolStripMenuItem.Click += new System.EventHandler(this.середнєГеометричнеЕлементівToolStripMenuItem_Click);
            // 
            // елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem
            // 
            this.елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem.Name = "елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem";
            this.елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem.Text = "Елемент, який зустрічається найчастіше";
            this.елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem.Click += new System.EventHandler(this.елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem_Click);
            // 
            // Файл
            // 
            this.ClientSize = new System.Drawing.Size(791, 427);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Файл";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem додатиЕлементиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добутокЕлементівToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиМасивToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem максимальнийЕлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мінімальникйЕлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кількістьВідємнихЕлементівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кількістьДодатніхЕлементівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кільнмстьПарниїЕлементівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кількістьНепарнихЕлементівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнєАрифметичнеЕлементівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнєГеометричнеЕлементівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem;
    }
}

