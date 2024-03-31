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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitter1.SplitterMoved += splitter1_SplitterMoved;
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Right;
            splitter2.Location = new Point(209, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(343, 450);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            splitter2.SplitterMoved += splitter2_SplitterMoved;
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(209, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(343, 363);
            dataGridView1.TabIndex = 14;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Mainform";
            Text = "Mainform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
