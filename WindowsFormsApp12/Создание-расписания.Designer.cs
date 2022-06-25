
namespace WindowsFormsApp12
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox6 = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.metroComboBox5 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Выбор группы"});
            this.metroComboBox1.Location = new System.Drawing.Point(256, 319);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Items.AddRange(new object[] {
            "День недели"});
            this.metroComboBox2.Location = new System.Drawing.Point(129, 283);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox2.TabIndex = 2;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 24;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Кабинет"});
            this.metroComboBox3.Location = new System.Drawing.Point(129, 319);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox3.TabIndex = 3;
            this.metroComboBox3.UseSelectable = true;
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 24;
            this.metroComboBox4.Items.AddRange(new object[] {
            "Время"});
            this.metroComboBox4.Location = new System.Drawing.Point(256, 283);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox4.TabIndex = 4;
            this.metroComboBox4.UseSelectable = true;
            // 
            // metroComboBox6
            // 
            this.metroComboBox6.FormattingEnabled = true;
            this.metroComboBox6.ItemHeight = 24;
            this.metroComboBox6.Items.AddRange(new object[] {
            "Предмет"});
            this.metroComboBox6.Location = new System.Drawing.Point(383, 283);
            this.metroComboBox6.Name = "metroComboBox6";
            this.metroComboBox6.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox6.TabIndex = 6;
            this.metroComboBox6.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Печать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Добавить строку";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(383, 317);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(121, 30);
            this.metroDateTime1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(129, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Редактировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // metroComboBox5
            // 
            this.metroComboBox5.FormattingEnabled = true;
            this.metroComboBox5.ItemHeight = 24;
            this.metroComboBox5.Items.AddRange(new object[] {
            "Учитель"});
            this.metroComboBox5.Location = new System.Drawing.Point(2, 283);
            this.metroComboBox5.Name = "metroComboBox5";
            this.metroComboBox5.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox5.TabIndex = 15;
            this.metroComboBox5.UseSelectable = true;
            this.metroComboBox5.SelectedIndexChanged += new System.EventHandler(this.metroComboBox5_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 392);
            this.Controls.Add(this.metroComboBox5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroComboBox6);
            this.Controls.Add(this.metroComboBox4);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private MetroFramework.Controls.MetroComboBox metroComboBox5;
    }
}