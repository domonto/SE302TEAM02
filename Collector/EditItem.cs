using LiteDB;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collector
{
    public partial class EditItem : Form
    {

        Main mainForm;
        CustomCollection customCol;
        DataGridViewRow selectedRow;
        private DatabaseController dbc;

        public EditItem(Main mainForm, CustomCollection customCol, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            dbc = new DatabaseController();

            this.mainForm = mainForm;
            this.customCol = customCol;
            this.selectedRow = selectedRow;

            tableLayoutPanel1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = customCol.attributes.Count;


            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (int y = 0; y < customCol.attributes.Count; y++)
            {

                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

                Label fieldName = new Label();
                fieldName.Text = customCol.attributes[y].name;
                fieldName.TextAlign = ContentAlignment.MiddleRight;
                fieldName.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                tableLayoutPanel1.Controls.Add(fieldName, 0, y);



                if (customCol.attributes[y].type == "text")
                {
                    TextBox fieldTextBox = new TextBox();
                    fieldTextBox.Text = selectedRow.Cells[customCol.attributes[y].name].Value.ToString();
                    fieldTextBox.Tag = customCol.attributes[y].name;
                    fieldTextBox.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                    tableLayoutPanel1.Controls.Add(fieldTextBox, 1, y);
                }
                else if (customCol.attributes[y].type == "number")
                {
                    TextBox fieldTextBox = new TextBox();
                    fieldTextBox.Text = selectedRow.Cells[customCol.attributes[y].name].Value.ToString();
                    fieldTextBox.Tag = customCol.attributes[y].name;
                    fieldTextBox.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                    tableLayoutPanel1.Controls.Add(fieldTextBox, 1, y);
                }
                else if (customCol.attributes[y].type == "date")
                {

                    DateTimePicker fieldDate = new DateTimePicker();

                    fieldDate.Text = selectedRow.Cells[customCol.attributes[y].name].Value.ToString();

                    fieldDate.Tag = customCol.attributes[y].name;
                    fieldDate.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                    tableLayoutPanel1.Controls.Add(fieldDate, 1, y);
                }

            }

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(new Label(), 0, customCol.attributes.Count);
            tableLayoutPanel1.Controls.Add(new Label(), 1, customCol.attributes.Count);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            var item = new BsonDocument();

            dynamic d = JObject.Parse(selectedRow.Cells["_id"].Value.ToString());
            String id = d["$oid"];
            var nid = new ObjectId(id);

            item["_id"] = nid;

            for (int y = 0; y < customCol.attributes.Count; y++)
            {

                
                if (customCol.attributes[y].type == "text")
                {
                    TextBox textBox = tableLayoutPanel1.GetControlFromPosition(1, y) as TextBox;
                    item[textBox.Tag.ToString()] = textBox.Text;
                }
                else if (customCol.attributes[y].type == "number")
                {
                    TextBox textBox = tableLayoutPanel1.GetControlFromPosition(1, y) as TextBox;
                    int parsedValue;

                    if (textBox.Text != "")
                    {
                        if (!int.TryParse(textBox.Text, out parsedValue))
                        {
                            MessageBox.Show(customCol.attributes[y].name + " must be a number");
                            return;
                        }
                    }
                    item[textBox.Tag.ToString()] = textBox.Text;

                }
                else if (customCol.attributes[y].type == "date")
                {
                    DateTimePicker datePicker = tableLayoutPanel1.GetControlFromPosition(1, y) as DateTimePicker;
                    item[datePicker.Tag.ToString()] = datePicker.Value.ToString("dd.MM.yyyy");
                }

            }

            dbc.updateDocument(customCol, item);

            mainForm.updateCollectionList();
            mainForm.updateItemList(customCol);
            this.Close();

        }
    }
}
