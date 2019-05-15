
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private OxyPlot.WindowsForms.PlotView plotView1;

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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.button1 = new System.Windows.Forms.Button();
            this.RInput = new System.Windows.Forms.TextBox();
            this.CInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ROut = new System.Windows.Forms.Label();
            this.plabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COut = new System.Windows.Forms.Label();
            this.w0Out = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plotView1.Location = new System.Drawing.Point(12, 25);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(575, 382);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1101, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RInput
            // 
            this.RInput.Location = new System.Drawing.Point(1146, 55);
            this.RInput.Name = "RInput";
            this.RInput.Size = new System.Drawing.Size(119, 22);
            this.RInput.TabIndex = 2;
            // 
            // CInput
            // 
            this.CInput.Location = new System.Drawing.Point(1146, 98);
            this.CInput.Name = "CInput";
            this.CInput.Size = new System.Drawing.Size(119, 22);
            this.CInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1101, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "R = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1101, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "C = ";
            // 
            // ROut
            // 
            this.ROut.AutoSize = true;
            this.ROut.Location = new System.Drawing.Point(1102, 157);
            this.ROut.Name = "ROut";
            this.ROut.Size = new System.Drawing.Size(42, 17);
            this.ROut.TabIndex = 3;
            this.ROut.Text = "R =   ";
            this.ROut.UseMnemonic = false;
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.Location = new System.Drawing.Point(1143, 157);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(0, 17);
            this.plabel.TabIndex = 3;
            this.plabel.UseMnemonic = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(610, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 382);
            this.dataGridView1.TabIndex = 4;
            // 
            // COut
            // 
            this.COut.AutoSize = true;
            this.COut.Location = new System.Drawing.Point(1102, 194);
            this.COut.Name = "COut";
            this.COut.Size = new System.Drawing.Size(41, 17);
            this.COut.TabIndex = 3;
            this.COut.Text = "C =   ";
            this.COut.UseMnemonic = false;
            // 
            // w0Out
            // 
            this.w0Out.AutoSize = true;
            this.w0Out.Location = new System.Drawing.Point(1101, 232);
            this.w0Out.Name = "w0Out";
            this.w0Out.Size = new System.Drawing.Size(49, 17);
            this.w0Out.TabIndex = 3;
            this.w0Out.Text = "w0 =   ";
            this.w0Out.UseMnemonic = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1105, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Данные с файла";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1101, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Вывод в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1311, 443);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.w0Out);
            this.Controls.Add(this.COut);
            this.Controls.Add(this.ROut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CInput);
            this.Controls.Add(this.RInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plotView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RInput;
        private System.Windows.Forms.TextBox CInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ROut;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label COut;
        private System.Windows.Forms.Label w0Out;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

