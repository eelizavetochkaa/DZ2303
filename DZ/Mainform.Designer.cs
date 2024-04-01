namespace DZ
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            splitter1 = new Splitter();
            splitter2 = new Splitter();
            Reserved = new RadioButton();
            Free = new RadioButton();
            Busy = new RadioButton();
            CheckingOut = new RadioButton();
            status = new Label();
            guetslist = new Label();
            NumberOfRoom = new Label();
            time = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            FIO = new Label();
            status2 = new Label();
            dateofarrival = new Label();
            dateofarrival2 = new Label();
            dateofdeparture = new Label();
            dateofdeparture2 = new Label();
            photo = new PictureBox();
            number = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(552, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(248, 450);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Right;
            splitter2.Location = new Point(209, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(343, 450);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // Reserved
            // 
            Reserved.AutoSize = true;
            Reserved.Location = new Point(12, 109);
            Reserved.Name = "Reserved";
            Reserved.Size = new Size(156, 24);
            Reserved.TabIndex = 5;
            Reserved.TabStop = true;
            Reserved.Text = "Зарезервировано";
            Reserved.UseVisualStyleBackColor = true;
            Reserved.CheckedChanged += Reserved_CheckedChanged;
            // 
            // Free
            // 
            Free.AutoSize = true;
            Free.Location = new Point(12, 139);
            Free.Name = "Free";
            Free.Size = new Size(110, 24);
            Free.TabIndex = 6;
            Free.TabStop = true;
            Free.Text = "Свободные";
            Free.UseVisualStyleBackColor = true;
            Free.CheckedChanged += Free_CheckedChanged;
            // 
            // Busy
            // 
            Busy.AutoSize = true;
            Busy.Location = new Point(12, 169);
            Busy.Name = "Busy";
            Busy.Size = new Size(80, 24);
            Busy.TabIndex = 7;
            Busy.TabStop = true;
            Busy.Text = "Заняты";
            Busy.UseVisualStyleBackColor = true;
            Busy.CheckedChanged += Busy_CheckedChanged;
            // 
            // CheckingOut
            // 
            CheckingOut.AutoSize = true;
            CheckingOut.Location = new Point(12, 199);
            CheckingOut.Name = "CheckingOut";
            CheckingOut.Size = new Size(135, 24);
            CheckingOut.TabIndex = 8;
            CheckingOut.TabStop = true;
            CheckingOut.Text = "Выписываются";
            CheckingOut.UseVisualStyleBackColor = true;
            CheckingOut.CheckedChanged += CheckingOut_CheckedChanged;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Soledago", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            status.Location = new Point(42, 31);
            status.Name = "status";
            status.Size = new Size(95, 30);
            status.TabIndex = 9;
            status.Text = "Статус";
            // 
            // guetslist
            // 
            guetslist.AutoSize = true;
            guetslist.Font = new Font("Soledago", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guetslist.Location = new Point(283, 31);
            guetslist.Name = "guetslist";
            guetslist.Size = new Size(182, 30);
            guetslist.TabIndex = 10;
            guetslist.Text = "Список гостей";
            // 
            // NumberOfRoom
            // 
            NumberOfRoom.AutoSize = true;
            NumberOfRoom.Font = new Font("Soledago", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumberOfRoom.Location = new Point(634, 31);
            NumberOfRoom.Name = "NumberOfRoom";
            NumberOfRoom.Size = new Size(85, 30);
            NumberOfRoom.TabIndex = 11;
            NumberOfRoom.Text = "Номер";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Soledago", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            time.Location = new Point(26, 5);
            time.Name = "time";
            time.Size = new Size(80, 23);
            time.TabIndex = 12;
            time.Text = "00:00:00";
            time.Click += time_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(209, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(343, 363);
            dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(593, 409);
            button1.Name = "button1";
            button1.Size = new Size(195, 29);
            button1.TabIndex = 15;
            button1.Text = "Просмотр карточки";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FIO
            // 
            FIO.AutoEllipsis = true;
            FIO.AutoSize = true;
            FIO.BackColor = SystemColors.ButtonHighlight;
            FIO.Location = new Point(568, 199);
            FIO.Name = "FIO";
            FIO.Size = new Size(42, 20);
            FIO.TabIndex = 16;
            FIO.Text = "ФИО";
            // 
            // status2
            // 
            status2.AutoSize = true;
            status2.BackColor = SystemColors.ButtonHighlight;
            status2.Location = new Point(568, 152);
            status2.Name = "status2";
            status2.Size = new Size(52, 20);
            status2.TabIndex = 17;
            status2.Text = "Статус";
            // 
            // dateofarrival
            // 
            dateofarrival.AutoSize = true;
            dateofarrival.Location = new Point(568, 244);
            dateofarrival.Name = "dateofarrival";
            dateofarrival.Size = new Size(91, 20);
            dateofarrival.TabIndex = 18;
            dateofarrival.Text = "Дата заезда";
            // 
            // dateofarrival2
            // 
            dateofarrival2.AutoSize = true;
            dateofarrival2.BackColor = SystemColors.ButtonHighlight;
            dateofarrival2.Location = new Point(568, 275);
            dateofarrival2.Name = "dateofarrival2";
            dateofarrival2.Size = new Size(79, 20);
            dateofarrival2.TabIndex = 19;
            dateofarrival2.Text = "00.00.0000";
            // 
            // dateofdeparture
            // 
            dateofdeparture.AutoSize = true;
            dateofdeparture.Location = new Point(570, 312);
            dateofdeparture.Name = "dateofdeparture";
            dateofdeparture.Size = new Size(95, 20);
            dateofdeparture.TabIndex = 20;
            dateofdeparture.Text = "Дата выезда";
            // 
            // dateofdeparture2
            // 
            dateofdeparture2.AutoSize = true;
            dateofdeparture2.BackColor = SystemColors.ControlLightLight;
            dateofdeparture2.Location = new Point(568, 341);
            dateofdeparture2.Name = "dateofdeparture2";
            dateofdeparture2.Size = new Size(79, 20);
            dateofdeparture2.TabIndex = 21;
            dateofdeparture2.Text = "00.00.0000";
            // 
            // photo
            // 
            photo.BackColor = SystemColors.ButtonHighlight;
            photo.Location = new Point(612, 64);
            photo.Name = "photo";
            photo.Size = new Size(125, 78);
            photo.TabIndex = 22;
            photo.TabStop = false;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Font = new Font("Soledago", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            number.Location = new Point(725, 31);
            number.Name = "number";
            number.Size = new Size(0, 30);
            number.TabIndex = 23;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(number);
            Controls.Add(photo);
            Controls.Add(dateofdeparture2);
            Controls.Add(dateofdeparture);
            Controls.Add(dateofarrival2);
            Controls.Add(dateofarrival);
            Controls.Add(status2);
            Controls.Add(FIO);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(time);
            Controls.Add(NumberOfRoom);
            Controls.Add(guetslist);
            Controls.Add(status);
            Controls.Add(CheckingOut);
            Controls.Add(Busy);
            Controls.Add(Free);
            Controls.Add(Reserved);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Mainform";
            Text = "Mainform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Splitter splitter1;
        private Splitter splitter2;
        private RadioButton Reserved;
        private RadioButton Free;
        private RadioButton Busy;
        private RadioButton CheckingOut;
        private Label status;
        private Label guetslist;
        private Label NumberOfRoom;
        private Label time;
        private DataGridView dataGridView1;
        private Button button1;
        private Label FIO;
        private Label status2;
        private Label dateofarrival;
        private Label dateofarrival2;
        private Label dateofdeparture;
        private Label dateofdeparture2;
        private PictureBox photo;
        private Label number;
    }
}
