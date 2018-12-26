using LiteDB;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collector
{
    public partial class Main : Form
    {
        private AddCollection addCollectionForm;
        private EditCollection editCollection;

        private CustomCollection selectedCollection;

        private AddItem addItem;
        private EditItem editItem;

        private DatabaseController dbc;

        private IEnumerable<CustomCollection> collectionList;

        public Main()
        {
            InitializeComponent();
            dbc = new DatabaseController();

            collectionPanel.Hide();
            updateCollectionList();

            if(collectionList.Count() > 0)
            {
                Button defaultButton = flowLayoutPanel1.Controls[0] as Button;
                selectedCollection = collectionList.First();
                updateItemList(selectedCollection);
            }
        }

        public void setSelectedCollection(CustomCollection selectedCollection)
        {
            this.selectedCollection = selectedCollection;
        }

        public IEnumerable<CustomCollection> getCollectionList()
        {
            return collectionList;
        }

        public void showInfoPanel()
        {
            collectionPanel.Hide();
            infoPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCollectionForm = new AddCollection(this);
       
            addCollectionForm.ControlBox = false;
            addCollectionForm.Show();
        }

        public void clearGrid()
        {
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            this.dataGridView1.Update();
            this.dataGridView1.Refresh();
        }

        public void updateItemList(CustomCollection collection)
        {
            infoPanel.Hide();
            collectionPanel.Show();
            collectionLabel.Text = collection.aliase;

            selectedCollection = collection;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Update();
            dataGridView1.Refresh();

            List<dynamic> itemList = dbc.getDocuments(collection);

            fieldSelectionBox.Items.Clear();

            DataTable dt = new DataTable();
            dt.Columns.Add("_id");

            foreach (Attribute attr in collection.attributes)
            {
                var columnSpec = new DataColumn
                {
                    DataType = typeof(String), 
                    ColumnName = attr.name 
                };

                if (attr.type == "date")
                {
                    columnSpec.DataType = typeof(DateTime);
                }

                fieldSelectionBox.Items.Add(attr.name);
                dt.Columns.Add(columnSpec);
            }

            fieldSelectionBox.SelectedItem = collection.attributes[0].name;

            foreach (dynamic item in itemList)
            {
                DataRow row = dt.NewRow();
                row["_id"] = item._id;

                foreach (Attribute attr in collection.attributes)
                {
                    String name = attr.name;

                    if (attr.type == "date")
                    {

                        String dateString = item[name];

                        if (dateString == null)
                        {
                            DateTime date = DateTime.ParseExact("01.01.2000", "d.M.yyyy", CultureInfo.InvariantCulture);
                            row[name] = date;
                        }
                        else
                        {
                            DateTime date = DateTime.ParseExact(dateString, "d.M.yyyy", CultureInfo.InvariantCulture);
                            row[name] = date;
                        }
                    }
                    else
                    {
                        row[name] = item[name];

                    }
                }
                dt.Rows.Add(row);
            }

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt;

            if (dataGridView1.Columns["_id"] != null)
            {
                dataGridView1.Columns["_id"].Visible = false;
            }
        }
        public void updateCollectionList()
        {
            flowLayoutPanel1.Controls.Clear();

            collectionList = dbc.getCollections();

            foreach (CustomCollection collection in collectionList)
            {
                Button button = new Button();
                button.Width = 170;
                button.Height = 35;
                button.Anchor = AnchorStyles.None;

                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.White;
                button.Font = new Font("Microsoft YaHei", 8.25f);
                button.Text = collection.aliase;
                button.Click += (s, e) =>
                {
                    updateItemList(collection);
                };
                flowLayoutPanel1.Controls.Add(button);
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEditCollection_Click(object sender, EventArgs e)
        {
            editCollection = new EditCollection(this, selectedCollection);
            editCollection.ControlBox = false;
            editCollection.Show();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            addItem = new AddItem(this, selectedCollection);
            addItem.ControlBox = false;
            addItem.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }

            if (selectedRow == null)
            {
                MessageBox.Show("Please select an item");
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            List<ObjectId> itemsToDelete = new List<ObjectId>();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dynamic d = JObject.Parse(item.Cells[0].Value.ToString());
                String id = d["$oid"];
                var nid = new ObjectId(id);
                itemsToDelete.Add(nid);
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            dbc.deleteDocument(selectedCollection, itemsToDelete);

        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }

            if (selectedRow == null)
            {
                MessageBox.Show("Please select an item");
                return;
            }

            editItem = new EditItem(this, selectedCollection, selectedRow);
            editItem.ControlBox = false;
            editItem.Show();
        }

        private void buttonSearchCollection_Click(object sender, EventArgs e)
        {

            if (fieldSelectionBox.SelectedItem == null || textboxSearch.Text == "")
            {
                updateItemList(selectedCollection);
                return;
            }

            String searchField = fieldSelectionBox.SelectedItem.ToString();
            String searchText = textboxSearch.Text;

            List<dynamic> searchResuts = dbc.searchCollection(selectedCollection, searchField, searchText);

            DataTable dt = new DataTable();

            dt.Columns.Add("_id");

            foreach (Attribute attr in selectedCollection.attributes)
            {
                dt.Columns.Add(attr.name);
            }

            foreach (dynamic item in searchResuts)
            {
                DataRow row = dt.NewRow();

                foreach (Attribute attr in selectedCollection.attributes)
                {
                    String name = attr.name;
                    row[name] = item[name];
                }

                row["_id"] = item._id;
                dt.Rows.Add(row);
            }

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Columns.Clear();

            dataGridView1.DataSource = dt;

            if (dataGridView1.Columns["_id"] != null)
            {
                dataGridView1.Columns["_id"].Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

