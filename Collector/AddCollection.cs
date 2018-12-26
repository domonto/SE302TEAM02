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

    public partial class AddCollection : Form
    {
        Main mainForm;
        private DatabaseController dbc;

        public AddCollection(Main mainForm)
        {
            InitializeComponent();

            dbc = new DatabaseController();
            this.mainForm = mainForm;

            comboBox1.Items.Add("text");
            comboBox1.Items.Add("number");
            comboBox1.Items.Add("date");

            comboBox1.SelectedItem = "text";

            listBox1.DisplayMember = "desc";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textCollectionName.Text == "" || textCollectionName.Text == null)
            {
                MessageBox.Show("Collection name is required.", "Error Creating Collection");
                return;
            }
            if(!Regex.IsMatch(textCollectionName.Text, @"^[\p{L}]+$"))
            {
                MessageBox.Show("Collection name can only have letters.", "Error Creating Collection");
                return;
            }


            IEnumerable<CustomCollection> allCollections = dbc.getCollections();

            String newCollectionName = dbc.RemoveTurkishCharacters(textCollectionName.Text);

            foreach (CustomCollection collection in allCollections)
            {
                if (collection.name == newCollectionName)
                {
                    MessageBox.Show("Collection already exists.", "Error Creating Collection");
                    return;
                }
            }

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

            var customCollection = new CustomCollection
            {
                name = dbc.RemoveTurkishCharacters(textCollectionName.Text),
                aliase = textCollectionName.Text,
                attributes = attributes,
            };

            dbc.createCollection(newCollectionName, attributes);

            mainForm.updateCollectionList();
            mainForm.updateItemList(customCollection);
            mainForm.setSelectedCollection(customCollection);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string RemoveAccent(string text)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

        public class Field
        {
            public string name { get; set; }
            public string type { get; set; }
            public string desc { get; set; }
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
                MessageBox.Show("Field name can only have letters.", "Error Creating Collection");
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count != 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
