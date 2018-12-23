namespace Collector
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCreateCollection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.collectionPanel = new System.Windows.Forms.Panel();
            this.fieldSelectionBox = new System.Windows.Forms.ComboBox();
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.buttonEditCollection = new System.Windows.Forms.Button();
            this.buttonSearchCollection = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.collectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 386);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(13, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.buttonCreateCollection);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 62);
            this.panel3.TabIndex = 0;
            // 
            // buttonCreateCollection
            // 
            this.buttonCreateCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateCollection.BackColor = System.Drawing.Color.White;
            this.buttonCreateCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateCollection.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCreateCollection.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateCollection.Location = new System.Drawing.Point(131, 20);
            this.buttonCreateCollection.Name = "buttonCreateCollection";
            this.buttonCreateCollection.Size = new System.Drawing.Size(63, 24);
            this.buttonCreateCollection.TabIndex = 1;
            this.buttonCreateCollection.Text = "Create";
            this.buttonCreateCollection.UseVisualStyleBackColor = false;
            this.buttonCreateCollection.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Collections";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 450);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(687, 389);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.collectionPanel);
            this.panel4.Controls.Add(this.infoPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 61);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // collectionPanel
            // 
            this.collectionPanel.Controls.Add(this.fieldSelectionBox);
            this.collectionPanel.Controls.Add(this.buttonEditItem);
            this.collectionPanel.Controls.Add(this.buttonDelete);
            this.collectionPanel.Controls.Add(this.buttonAddItem);
            this.collectionPanel.Controls.Add(this.textboxSearch);
            this.collectionPanel.Controls.Add(this.buttonEditCollection);
            this.collectionPanel.Controls.Add(this.buttonSearchCollection);
            this.collectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionPanel.Location = new System.Drawing.Point(0, 0);
            this.collectionPanel.Name = "collectionPanel";
            this.collectionPanel.Size = new System.Drawing.Size(687, 61);
            this.collectionPanel.TabIndex = 7;
            // 
            // fieldSelectionBox
            // 
            this.fieldSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldSelectionBox.FormattingEnabled = true;
            this.fieldSelectionBox.Location = new System.Drawing.Point(431, 9);
            this.fieldSelectionBox.Name = "fieldSelectionBox";
            this.fieldSelectionBox.Size = new System.Drawing.Size(170, 21);
            this.fieldSelectionBox.TabIndex = 8;
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.buttonEditItem.FlatAppearance.BorderSize = 0;
            this.buttonEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEditItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditItem.Location = new System.Drawing.Point(179, 21);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(68, 24);
            this.buttonEditItem.TabIndex = 7;
            this.buttonEditItem.Text = "Edit Item";
            this.buttonEditItem.UseVisualStyleBackColor = false;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(253, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 24);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.buttonAddItem.FlatAppearance.BorderSize = 0;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddItem.Location = new System.Drawing.Point(105, 21);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(68, 24);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // textboxSearch
            // 
            this.textboxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxSearch.Location = new System.Drawing.Point(431, 36);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(170, 20);
            this.textboxSearch.TabIndex = 4;
            // 
            // buttonEditCollection
            // 
            this.buttonEditCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.buttonEditCollection.FlatAppearance.BorderSize = 0;
            this.buttonEditCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCollection.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEditCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditCollection.Location = new System.Drawing.Point(6, 21);
            this.buttonEditCollection.Name = "buttonEditCollection";
            this.buttonEditCollection.Size = new System.Drawing.Size(93, 24);
            this.buttonEditCollection.TabIndex = 3;
            this.buttonEditCollection.Text = "Edit Collection";
            this.buttonEditCollection.UseVisualStyleBackColor = false;
            this.buttonEditCollection.Click += new System.EventHandler(this.buttonEditCollection_Click);
            // 
            // buttonSearchCollection
            // 
            this.buttonSearchCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.buttonSearchCollection.FlatAppearance.BorderSize = 0;
            this.buttonSearchCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchCollection.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSearchCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearchCollection.Location = new System.Drawing.Point(607, 9);
            this.buttonSearchCollection.Name = "buttonSearchCollection";
            this.buttonSearchCollection.Size = new System.Drawing.Size(68, 47);
            this.buttonSearchCollection.TabIndex = 5;
            this.buttonSearchCollection.Text = "Search";
            this.buttonSearchCollection.UseVisualStyleBackColor = false;
            this.buttonSearchCollection.Click += new System.EventHandler(this.buttonSearchCollection_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(687, 61);
            this.infoPanel.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.collectionPanel.ResumeLayout(false);
            this.collectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateCollection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearchCollection;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Button buttonEditCollection;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel collectionPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox fieldSelectionBox;
        private System.Windows.Forms.Button buttonEditItem;
    }
}

