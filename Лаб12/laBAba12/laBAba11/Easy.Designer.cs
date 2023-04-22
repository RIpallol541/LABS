namespace laBAba11
{
    partial class Easy
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.memDataSet = new laBAba11.MemDataSet();
            this.memorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memorTableAdapter = new laBAba11.MemDataSetTableAdapters.MemorTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.достопремечательностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.открытиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоположениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.достопремечательностьDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn,
            this.открытиеDataGridViewTextBoxColumn,
            this.местоположениеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 288);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Location = new System.Drawing.Point(26, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 100);
            this.panel3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Запрос";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 66);
            this.button3.TabIndex = 6;
            this.button3.Text = "Выполнить запрос";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(79, 45);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(412, 20);
            this.textBox8.TabIndex = 5;
            // 
            // memDataSet
            // 
            this.memDataSet.DataSetName = "MemDataSet";
            this.memDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memorBindingSource
            // 
            this.memorBindingSource.DataMember = "Memor";
            this.memorBindingSource.DataSource = this.memDataSet;
            // 
            // memorTableAdapter
            // 
            this.memorTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // достопремечательностьDataGridViewTextBoxColumn
            // 
            this.достопремечательностьDataGridViewTextBoxColumn.DataPropertyName = "Достопремечательность";
            this.достопремечательностьDataGridViewTextBoxColumn.HeaderText = "Достопремечательность";
            this.достопремечательностьDataGridViewTextBoxColumn.Name = "достопремечательностьDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewTextBoxColumn
            // 
            this.фотоDataGridViewTextBoxColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
            // 
            // открытиеDataGridViewTextBoxColumn
            // 
            this.открытиеDataGridViewTextBoxColumn.DataPropertyName = "Открытие";
            this.открытиеDataGridViewTextBoxColumn.HeaderText = "Открытие";
            this.открытиеDataGridViewTextBoxColumn.Name = "открытиеDataGridViewTextBoxColumn";
            // 
            // местоположениеDataGridViewTextBoxColumn
            // 
            this.местоположениеDataGridViewTextBoxColumn.DataPropertyName = "Местоположение";
            this.местоположениеDataGridViewTextBoxColumn.HeaderText = "Местоположение";
            this.местоположениеDataGridViewTextBoxColumn.Name = "местоположениеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Easy";
            this.Text = "Easy";
            this.Load += new System.EventHandler(this.Easy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private MemDataSet memDataSet;
        private System.Windows.Forms.BindingSource memorBindingSource;
        private MemDataSetTableAdapters.MemorTableAdapter memorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn достопремечательностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn открытиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоположениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
    }
}