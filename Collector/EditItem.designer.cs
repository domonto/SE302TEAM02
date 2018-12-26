namespace Collector
{
    partial class EditItem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.labelEditItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 275);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(12, 321);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.BackColor = System.Drawing.Color.White;
            this.buttonSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveItem.Location = new System.Drawing.Point(391, 321);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(115, 23);
            this.buttonSaveItem.TabIndex = 11;
            this.buttonSaveItem.Text = "Save";
            this.buttonSaveItem.UseVisualStyleBackColor = false;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // labelEditItem
            // 
            this.labelEditItem.AutoSize = true;
            this.labelEditItem.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEditItem.ForeColor = System.Drawing.Color.Black;
            this.labelEditItem.Location = new System.Drawing.Point(12, 10);
            this.labelEditItem.Name = "labelEditItem";
            this.labelEditItem.Size = new System.Drawing.Size(91, 27);
            this.labelEditItem.TabIndex = 10;
            this.labelEditItem.Text = "Edit Item";
            this.labelEditItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.labelEditItem);
            this.MaximumSize = new System.Drawing.Size(534, 394);
            this.MinimumSize = new System.Drawing.Size(534, 394);
            this.Name = "EditItem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.Label labelEditItem;
    }
}