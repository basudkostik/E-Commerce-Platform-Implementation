using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Marketplace
{
    public partial class FirstEnterForm : Form
    {
        private List<marketItem> virtualObjects;
        private BinarySearchTree bst;
        private MaxHeap heap;
        private HashTable hashTable;

        public FirstEnterForm(BinarySearchTree bst, MaxHeap heap, HashTable hashTable, List<marketItem> virtualObjects)
        {
            InitializeComponent();
            this.bst = bst;
            this.heap = heap;
            this.hashTable = hashTable;
            this.virtualObjects = virtualObjects;
        }

        private void InitializeComponent()
        {
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.buttonEditObject = new System.Windows.Forms.Button();
            this.buttonShowTotalPrice = new System.Windows.Forms.Button();
            this.buttonDeleteObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.Location = new System.Drawing.Point(12, 41);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(100, 23);
            this.buttonAddObject.TabIndex = 1;
            this.buttonAddObject.Text = "Add Object";
            this.buttonAddObject.UseVisualStyleBackColor = true;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.Location = new System.Drawing.Point(12, 70);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchByName.TabIndex = 2;
            this.buttonSearchByName.Text = "Search by Name";
            this.buttonSearchByName.UseVisualStyleBackColor = true;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // buttonEditObject
            // 
            this.buttonEditObject.Location = new System.Drawing.Point(12, 99);
            this.buttonEditObject.Name = "buttonEditObject";
            this.buttonEditObject.Size = new System.Drawing.Size(100, 23);
            this.buttonEditObject.TabIndex = 3;
            this.buttonEditObject.Text = "Edit Object";
            this.buttonEditObject.UseVisualStyleBackColor = true;
            this.buttonEditObject.Click += new System.EventHandler(this.buttonEditObject_Click);
            // 
            // buttonShowTotalPrice
            // 
            this.buttonShowTotalPrice.Location = new System.Drawing.Point(12, 128);
            this.buttonShowTotalPrice.Name = "buttonShowTotalPrice";
            this.buttonShowTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.buttonShowTotalPrice.TabIndex = 4;
            this.buttonShowTotalPrice.Text = "Show Total Price";
            this.buttonShowTotalPrice.UseVisualStyleBackColor = true;
            this.buttonShowTotalPrice.Click += new System.EventHandler(this.buttonShowTotalPrice_Click);
            // 
            // buttonDeleteObject
            // 
            this.buttonDeleteObject.Location = new System.Drawing.Point(12, 157);
            this.buttonDeleteObject.Name = "buttonDeleteObject";
            this.buttonDeleteObject.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteObject.TabIndex = 5;
            this.buttonDeleteObject.Text = "Delete Object";
            this.buttonDeleteObject.UseVisualStyleBackColor = true;
            this.buttonDeleteObject.Click += new System.EventHandler(this.buttonDeleteObject_Click);
            // 
            // FirstEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.buttonDeleteObject);
            this.Controls.Add(this.buttonShowTotalPrice);
            this.Controls.Add(this.buttonEditObject);
            this.Controls.Add(this.buttonSearchByName);
            this.Controls.Add(this.buttonAddObject);
            this.Name = "FirstEnterForm";
            this.Text = "FirstEnterForm";
            this.ResumeLayout(false);
        }

        private void buttonAddObject_Click(object sender, EventArgs e)
        {
            string category = Microsoft.VisualBasic.Interaction.InputBox("Enter category:", "Add Object", "");
            string brand = Microsoft.VisualBasic.Interaction.InputBox("Enter brand:", "Add Object", "");
            string model = Microsoft.VisualBasic.Interaction.InputBox("Enter model:", "Add Object", "");
            string priceStr = Microsoft.VisualBasic.Interaction.InputBox("Enter price:", "Add Object", "");
            string quantityStr = Microsoft.VisualBasic.Interaction.InputBox("Enter quantity:", "Add Object", "");

            if (decimal.TryParse(priceStr, out decimal price) && int.TryParse(quantityStr, out int quantity))
            {
                marketItem newObj = new marketItem { Category = category, Brand = brand, Model = model, Price = price, Quantity = quantity };
                virtualObjects.Add(newObj);
                bst.Insert(newObj);
                heap.Add(newObj);
                hashTable.Add(newObj.Model, newObj);
                MessageBox.Show("Object added successfully.");
            }
            else
            {
                MessageBox.Show("Invalid price or quantity.");
            }
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            string model = Microsoft.VisualBasic.Interaction.InputBox("Enter model:", "Search by Name", "");

            var result = hashTable.Get(model);
            if (result != null)
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                MessageBox.Show("Object not found.");
            }
        }

        private void buttonEditObject_Click(object sender, EventArgs e)
        {
            string model = Microsoft.VisualBasic.Interaction.InputBox("Enter model of the object to edit:", "Edit Object", "");

            var obj = hashTable.Get(model);
            if (obj != null)
            {
                string newCategory = Microsoft.VisualBasic.Interaction.InputBox("Enter new category:", "Edit Object", obj.Category);
                string newBrand = Microsoft.VisualBasic.Interaction.InputBox("Enter new brand:", "Edit Object", obj.Brand);
                string newPriceStr = Microsoft.VisualBasic.Interaction.InputBox("Enter new price:", "Edit Object", obj.Price.ToString());
                string newQuantityStr = Microsoft.VisualBasic.Interaction.InputBox("Enter new quantity:", "Edit Object", obj.Quantity.ToString());

                if (decimal.TryParse(newPriceStr, out decimal newPrice) && int.TryParse(newQuantityStr, out int newQuantity))
                {
                    obj.Category = newCategory;
                    obj.Brand = newBrand;
                    obj.Price = newPrice;
                    obj.Quantity = newQuantity;
                    MessageBox.Show("Object updated successfully.");
                }
                else
                {
                    MessageBox.Show("Invalid price or quantity.");
                }
            }
            else
            {
                MessageBox.Show("Object not found.");
            }
        }

        private void buttonShowTotalPrice_Click(object sender, EventArgs e)
        {
            decimal totalPrice = CustomerRegistry.GetAllCustomers().Sum(c => c.TotalSpent);
            MessageBox.Show($"Total price of all sold objects: {totalPrice:C}");
        }

        private void buttonDeleteObject_Click(object sender, EventArgs e)
        {
            string model = Microsoft.VisualBasic.Interaction.InputBox("Enter model of the object to delete:", "Delete Object", "");

            var obj = hashTable.Get(model);
            if (obj != null)
            {
                virtualObjects.Remove(obj);
                bst.Delete(obj);
                heap.Remove(obj);
                hashTable.Remove(model, obj);
                MessageBox.Show("Object deleted successfully.");
            }
            else
            {
                MessageBox.Show("Object not found.");
            }
        }

        private Button buttonAddObject;
        private Button buttonSearchByName;
        private Button buttonEditObject;
        private Button buttonShowTotalPrice;
        private Button buttonDeleteObject;
    }
}
