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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verif));
            this.memorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memDataSet = new laBAba11.MemDataSet();
            this.memorTableAdapter = new laBAba11.MemDataSetTableAdapters.MemorTableAdapter();
            this.memorialsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.memorialsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memorialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memorialsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // memorBindingSource
            // 
            this.memorBindingSource.DataMember = "Memor";
            this.memorBindingSource.DataSource = this.memDataSet;
            // 
            // memDataSet
            // 
            this.memDataSet.DataSetName = "MemDataSet";
            this.memDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memorTableAdapter
            // 
            this.memorTableAdapter.ClearBeforeFill = true;
            // 
            // memorialsBindingSource2
            // 
            this.memorialsBindingSource2.DataMember = "Memorials";
            // 
            // memorialsBindingSource1
            // 
            this.memorialsBindingSource1.DataMember = "Memorials";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Обычный пользователь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Verif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Verif";
            this.Text = "Verif";
            ((System.ComponentModel.ISupportInitialize)(this.memorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorialsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource memorialsDataSetBindingSource;

        private System.Windows.Forms.BindingSource memorialsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn достопремечательностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memorialsBindingSource1;

        private System.Windows.Forms.BindingSource memorialsBindingSource2;
        private MemDataSet memDataSet;
        private System.Windows.Forms.BindingSource memorBindingSource;
        private MemDataSetTableAdapters.MemorTableAdapter memorTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}