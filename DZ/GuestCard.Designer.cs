namespace DZ
{
    partial class GuestCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardofguest = new Label();
            FIO2 = new Label();
            Birth = new Label();
            summ = new Label();
            animals = new CheckBox();
            quantity = new NumericUpDown();
            label1 = new Label();
            write = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            SuspendLayout();
            // 
            // cardofguest
            // 
            cardofguest.AutoSize = true;
            cardofguest.BackColor = SystemColors.ButtonHighlight;
            cardofguest.Font = new Font("Soledago", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cardofguest.Location = new Point(81, 21);
            cardofguest.Name = "cardofguest";
            cardofguest.Size = new Size(232, 36);
            cardofguest.TabIndex = 0;
            cardofguest.Text = "Карточка гостя";
            // 
            // FIO2
            // 
            FIO2.AutoSize = true;
            FIO2.BackColor = SystemColors.ControlLightLight;
            FIO2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FIO2.Location = new Point(12, 92);
            FIO2.Name = "FIO2";
            FIO2.Size = new Size(57, 28);
            FIO2.TabIndex = 1;
            FIO2.Text = "ФИО";
            // 
            // Birth
            // 
            Birth.AutoSize = true;
            Birth.BackColor = SystemColors.ButtonHighlight;
            Birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Birth.Location = new Point(12, 161);
            Birth.Name = "Birth";
            Birth.Size = new Size(153, 28);
            Birth.TabIndex = 2;
            Birth.Text = "Дата рождения";
            // 
            // summ
            // 
            summ.AutoSize = true;
            summ.BackColor = SystemColors.ButtonHighlight;
            summ.Location = new Point(127, 285);
            summ.Name = "summ";
            summ.Size = new Size(118, 20);
            summ.TabIndex = 3;
            summ.Text = "Сумма к оплате";
            // 
            // animals
            // 
            animals.AutoSize = true;
            animals.Location = new Point(81, 356);
            animals.Name = "animals";
            animals.Size = new Size(221, 24);
            animals.TabIndex = 4;
            animals.Text = "Путешествую с животными";
            animals.UseVisualStyleBackColor = true;
            // 
            // quantity
            // 
            quantity.Location = new Point(239, 318);
            quantity.Name = "quantity";
            quantity.Size = new Size(63, 27);
            quantity.TabIndex = 5;
            quantity.ValueChanged += quantity_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 241);
            label1.Name = "label1";
            label1.Size = new Size(370, 20);
            label1.TabIndex = 6;
            label1.Text = "Внимание!!! Стоимость номера за сутки = 7490 руб.";
            // 
            // write
            // 
            write.Location = new Point(86, 398);
            write.Name = "write";
            write.Size = new Size(190, 29);
            write.TabIndex = 7;
            write.Text = "Записать данные в файл";
            write.UseVisualStyleBackColor = true;
            write.Click += write_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 320);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 8;
            label2.Text = "Выберите количество ночей";
            // 
            // GuestCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(label2);
            Controls.Add(write);
            Controls.Add(label1);
            Controls.Add(quantity);
            Controls.Add(animals);
            Controls.Add(summ);
            Controls.Add(Birth);
            Controls.Add(FIO2);
            Controls.Add(cardofguest);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GuestCard";
            Text = "GuestCard";
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cardofguest;
        private Label FIO2;
        private Label Birth;
        private Label summ;
        private CheckBox animals;
        private NumericUpDown quantity;
        private Label label1;
        private Button write;
        private Label label2;
    }
}