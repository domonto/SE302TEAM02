using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collector
{
    public partial class EditCollection : Form
    {
        Main mainForm;
        CustomCollection customCol;
        private DatabaseController dbc;

        public class Field
        {
            public string name { get; set; }
            public string type { get; set; }
            public string desc { get; set; }
        }


        public EditCollection(Main mainForm, CustomCollection customCol)
        {
            InitializeComponent();

            dbc = new DatabaseController();

            this.mainForm = mainForm;
            this.customCol = customCol;

            comboBox1.Items.Add("text");
            comboBox1.Items.Add("number");
            comboBox1.Items.Add("date");
            comboBox1.SelectedItem = "text";

            listBox1.DisplayMember = "desc";

            foreach (Attribute attr in customCol.attributes)
            {
                Field fieldToAdd = new Field
                {
                    name = attr.name,
                    type = attr.type,
                    desc = "",
                };
                fieldToAdd.desc = fieldToAdd.name + " (" + fieldToAdd.type + ")";
                listBox1.Items.Add(fieldToAdd);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveCollection_Click(object sender, EventArgs e)
        {

            var customCollection = dbc.getCustomCollection();
            CustomCollection collectionToUpdate = customCollection.FindOne(Query.EQ("name", customCol.name));

            List<Attribute> attributes = new List<Attribute>();

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("At least one field is required.", "Error Creating Collection");
                return;
            }
            foreach (Field f in listBox1.Items)
            {
                var attr = new Attribute
                {
                    name = f.name,
                    type = f.type,
                };

                attributes.Add(attr);
            }
            collectionToUpdate.attributes = attributes;
            customCollection.Update(collectionToUpdate);
            mainForm.updateCollectionList();
            mainForm.updateItemList(collectionToUpdate);
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count != 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            String fieldName = textFieldName.Text;


            if (fieldName == "" || fieldName == null)
            {
                MessageBox.Show("Please enter a field name", "Error Adding Field");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please enter a field type", "Error Adding Field");
                return;
            }

            String fieldType = comboBox1.SelectedItem.ToString();


            Field fieldToAdd = new Field
            {
                name = fieldName,
                type = fieldType,
                desc = "",
            };
            fieldToAdd.desc = fieldToAdd.name + " (" + fieldToAdd.type + ")";

            if (!Regex.IsMatch(fieldToAdd.name, @"^[\p{L}]+$"))
            {
                MessageBox.Show("Field name can only have letters.", "Error Editing Collection");
                return;
            }

            foreach (Field field in listBox1.Items)
            {
                if (field.name == fieldToAdd.name)
                {
                    MessageBox.Show("Field is already added", "Error Adding Field");
                    return;
                }
            }

            listBox1.Items.Add(fieldToAdd);
        }

        private string RemoveAccent(string text)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

        private void buttonDeleteCollection_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to delete this collection?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            dbc.deleteCollection(customCol);

            mainForm.showInfoPanel();
            mainForm.updateCollectionList();
            mainForm.clearGrid();

            IEnumerable<CustomCollection> collectionList = mainForm.getCollectionList();
            if (collectionList.Count() > 0)
            {
                mainForm.setSelectedCollection(collectionList.First());
                mainForm.updateItemList(collectionList.First());
            }

            this.Close();
        }
    }
}
