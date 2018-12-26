namespace Collector
{
    partial class AddCollection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textFieldName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateCollection = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCollectionName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonAddField);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textFieldName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCreateCollection);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textCollectionName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 336);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonRemove
            // 
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemove.Location = new System.Drawing.Point(147, 255);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(73, 23);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(72, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "field type:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "field name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddField
            // 
            this.buttonAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddField.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddField.Location = new System.Drawing.Point(323, 255);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(73, 23);
            this.buttonAddField.TabIndex = 9;
            this.buttonAddField.Text = "Add";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textFieldName
            // 
            this.textFieldName.Location = new System.Drawing.Point(147, 202);
            this.textFieldName.Name = "textFieldName";
            this.textFieldName.Size = new System.Drawing.Size(249, 20);
            this.textFieldName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Collection fields:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(147, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 121);
            this.listBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create Collection";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCreateCollection
            // 
            this.buttonCreateCollection.BackColor = System.Drawing.Color.White;
            this.buttonCreateCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateCollection.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateCollection.Location = new System.Drawing.Point(281, 301);
            this.buttonCreateCollection.Name = "buttonCreateCollection";
            this.buttonCreateCollection.Size = new System.Drawing.Size(115, 23);
            this.buttonCreateCollection.TabIndex = 3;
            this.buttonCreateCollection.Text = "Create";
            this.buttonCreateCollection.UseVisualStyleBackColor = false;
            this.buttonCreateCollection.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(12, 301);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Collection name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textCollectionName
            // 
            this.textCollectionName.Location = new System.Drawing.Point(147, 48);
            this.textCollectionName.Name = "textCollectionName";
            this.textCollectionName.Size = new System.Drawing.Size(249, 20);
            this.textCollectionName.TabIndex = 0;
            // 
            // AddCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 336);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(423, 375);
            this.MinimumSize = new System.Drawing.Size(423, 375);
            this.Name = "AddCollection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateCollection;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCollectionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddField;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textFieldName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemove;
    }
}