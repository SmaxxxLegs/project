namespace Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Deserialize = new System.Windows.Forms.Button();
            this.Serialize = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Block = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_of_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Deserialize
            // 
            this.Deserialize.Location = new System.Drawing.Point(1000, 288);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(155, 23);
            this.Deserialize.TabIndex = 2;
            this.Deserialize.Text = "Десереалiзувати";
            this.Deserialize.UseVisualStyleBackColor = true;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(812, 288);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(155, 23);
            this.Serialize.TabIndex = 3;
            this.Serialize.Text = "Сереалiзувати";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(1000, 217);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(155, 23);
            this.Load.TabIndex = 4;
            this.Load.Text = "Вивантажити";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(812, 217);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(155, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Зберегти";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1000, 150);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 23);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Видалити аккаунт";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(1000, 517);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(155, 35);
            this.About.TabIndex = 7;
            this.About.Text = "Про програму";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(812, 88);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(155, 23);
            this.Search.TabIndex = 8;
            this.Search.Text = "Знайти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Активний (статус)",
            "Неактивний (статус)",
            "Найбiльший баланс",
            "Нульовий баланс"});
            this.comboBox1.Location = new System.Drawing.Point(812, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.City,
            this.statusDataGridViewTextBoxColumn,
            this.accnumDataGridViewTextBoxColumn,
            this.Amount_of_money});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 540);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(812, 150);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(155, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Вiдкрити аккаунт";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Block
            // 
            this.Block.Location = new System.Drawing.Point(1000, 88);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(155, 23);
            this.Block.TabIndex = 12;
            this.Block.Text = "Заблокувати";
            this.Block.UseVisualStyleBackColor = true;
            this.Block.Click += new System.EventHandler(this.Block_Click);
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Мiсто";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 75;
            // 
            // Amount_of_money
            // 
            this.Amount_of_money.DataPropertyName = "Amount_of_money";
            this.Amount_of_money.HeaderText = "Кoштiв на рахунку($)";
            this.Amount_of_money.MinimumWidth = 6;
            this.Amount_of_money.Name = "Amount_of_money";
            this.Amount_of_money.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ПIБ";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // accnumDataGridViewTextBoxColumn
            // 
            this.accnumDataGridViewTextBoxColumn.DataPropertyName = "Acc_num";
            this.accnumDataGridViewTextBoxColumn.HeaderText = "Номер рахунку";
            this.accnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accnumDataGridViewTextBoxColumn.Name = "accnumDataGridViewTextBoxColumn";
            this.accnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(Project.Clients);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 569);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.Deserialize);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Block;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_of_money;
    }
}

