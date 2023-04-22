namespace laBAba11
{
    partial class Verif
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
            this.memorialsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.memorialsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memorialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.memorialsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memDataSet = new laBAba11.MemDataSet();
            this.memorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memorTableAdapter = new laBAba11.MemDataSetTableAdapters.MemorTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.открытиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоположениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memorialsBindingSource2
            // 
            this.memorialsBindingSource2.DataMember = "Memorials";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(352, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "Подтвердить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(496, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 50);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // memorialsBindingSource1
            // 
            this.memorialsBindingSource1.DataMember = "Memorials";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.открытиеDataGridViewTextBoxColumn,
            this.местоположениеDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.memorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 316);
            this.dataGridView1.TabIndex = 17;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Достопремечательность";
            this.dataGridViewTextBoxColumn2.HeaderText = "Достопремечательность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фото";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фото";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Verif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Name = "Verif";
            this.Text = "Verif";
            this.Load += new System.EventHandler(this.Verif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource memorialsDataSetBindingSource;

        private System.Windows.Forms.BindingSource memorialsBindingSource;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn достопремечательностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memorialsBindingSource1;

        private System.Windows.Forms.BindingSource memorialsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MemDataSet memDataSet;
        private System.Windows.Forms.BindingSource memorBindingSource;
        private MemDataSetTableAdapters.MemorTableAdapter memorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn открытиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоположениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}