using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Marketplace
{
    public partial class SecondEnterForm : Form
    {
        private List<marketItem> virtualObjects;
        private BinarySearchTree bst;
        private MaxHeap heap;
        private HashTable hashTable;

        public SecondEnterForm(BinarySearchTree bst, MaxHeap heap, HashTable hashTable, List<marketItem> virtualObjects)
        {
            InitializeComponent();
            this.bst = bst;
            this.heap = heap;
            this.hashTable = hashTable;
            this.virtualObjects = virtualObjects;
        }

        private void InitializeComponent()
        {
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.buttonSearchByPriceRange = new System.Windows.Forms.Button();
            this.buttonListByCategory = new System.Windows.Forms.Button();
            this.buttonOrderProduct = new System.Windows.Forms.Button();
            this.buttonSearchByWord = new System.Windows.Forms.Button();
            this.buttonAddTopNToShoppingList = new System.Windows.Forms.Button();
            this.buttonBalanceTrees = new System.Windows.Forms.Button();
            this.buttonRegisterCustomer = new System.Windows.Forms.Button();
            this.buttonShoppingList = new System.Windows.Forms.Button();
            this.buttonWriteReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.Location = new System.Drawing.Point(12, 12);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(200, 23);
            this.buttonSearchByName.TabIndex = 0;
            this.buttonSearchByName.Text = "Search Product by Name";
            this.buttonSearchByName.UseVisualStyleBackColor = true;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // buttonSearchByPriceRange
            // 
            this.buttonSearchByPriceRange.Location = new System.Drawing.Point(12, 41);
            this.buttonSearchByPriceRange.Name = "buttonSearchByPriceRange";
            this.buttonSearchByPriceRange.Size = new System.Drawing.Size(200, 23);
            this.buttonSearchByPriceRange.TabIndex = 1;
            this.buttonSearchByPriceRange.Text = "Search by Price Range";
            this.buttonSearchByPriceRange.UseVisualStyleBackColor = true;
            this.buttonSearchByPriceRange.Click += new System.EventHandler(this.buttonSearchByPriceRange_Click);
            // 
            // buttonListByCategory
            // 
            this.buttonListByCategory.Location = new System.Drawing.Point(12, 70);
            this.buttonListByCategory.Name = "buttonListByCategory";
            this.buttonListByCategory.Size = new System.Drawing.Size(200, 23);
            this.buttonListByCategory.TabIndex = 2;
            this.buttonListByCategory.Text = "List by Category";
            this.buttonListByCategory.UseVisualStyleBackColor = true;
            this.buttonListByCategory.Click += new System.EventHandler(this.buttonListByCategory_Click);
            // 
            // buttonOrderProduct
            // 
            this.buttonOrderProduct.Location = new System.Drawing.Point(12, 99);
            this.buttonOrderProduct.Name = "buttonOrderProduct";
            this.buttonOrderProduct.Size = new System.Drawing.Size(200, 23);
            this.buttonOrderProduct.TabIndex = 3;
            this.buttonOrderProduct.Text = "Order and Purchase Product";
            this.buttonOrderProduct.UseVisualStyleBackColor = true;
            this.buttonOrderProduct.Click += new System.EventHandler(this.buttonOrderProduct_Click);
            // 
            // buttonSearchByWord
            // 
            this.buttonSearchByWord.Location = new System.Drawing.Point(12, 128);
            this.buttonSearchByWord.Name = "buttonSearchByWord";
            this.buttonSearchByWord.Size = new System.Drawing.Size(200, 23);
            this.buttonSearchByWord.TabIndex = 4;
            this.buttonSearchByWord.Text = "Search by Word";
            this.buttonSearchByWord.UseVisualStyleBackColor = true;
            this.buttonSearchByWord.Click += new System.EventHandler(this.buttonSearchByWord_Click);
            // 
            // buttonAddTopNToShoppingList
            // 
            this.buttonAddTopNToShoppingList.Location = new System.Drawing.Point(12, 157);
            this.buttonAddTopNToShoppingList.Name = "buttonAddTopNToShoppingList";
            this.buttonAddTopNToShoppingList.Size = new System.Drawing.Size(200, 23);
            this.buttonAddTopNToShoppingList.TabIndex = 5;
            this.buttonAddTopNToShoppingList.Text = "Add Top N to Shopping List";
            this.buttonAddTopNToShoppingList.UseVisualStyleBackColor = true;
            this.buttonAddTopNToShoppingList.Click += new System.EventHandler(this.buttonAddTopNToShoppingList_Click);
            // 
            // buttonBalanceTrees
            // 
            this.buttonBalanceTrees.Location = new System.Drawing.Point(12, 186);
            this.buttonBalanceTrees.Name = "buttonBalanceTrees";
            this.buttonBalanceTrees.Size = new System.Drawing.Size(200, 23);
            this.buttonBalanceTrees.TabIndex = 6;
            this.buttonBalanceTrees.Text = "Balance Trees";
            this.buttonBalanceTrees.UseVisualStyleBackColor = true;
            this.buttonBalanceTrees.Click += new System.EventHandler(this.buttonBalanceTrees_Click);
            // 
            // buttonRegisterCustomer
            // 
            this.buttonRegisterCustomer.Location = new System.Drawing.Point(12, 215);
            this.buttonRegisterCustomer.Name = "buttonRegisterCustomer";
            this.buttonRegisterCustomer.Size = new System.Drawing.Size(200, 23);
            this.buttonRegisterCustomer.TabIndex = 7;
            this.buttonRegisterCustomer.Text = "Register Customer";
            this.buttonRegisterCustomer.UseVisualStyleBackColor = true;
            this.buttonRegisterCustomer.Click += new System.EventHandler(this.buttonRegisterCustomer_Click);
            // 
            // buttonShoppingList
            // 
            this.buttonShoppingList.Location = new System.Drawing.Point(12, 244);
            this.buttonShoppingList.Name = "buttonShoppingList";
            this.buttonShoppingList.Size = new System.Drawing.Size(200, 23);
            this.buttonShoppingList.TabIndex = 8;
            this.buttonShoppingList.Text = "Shopping List";
            this.buttonShoppingList.UseVisualStyleBackColor = true;
            this.buttonShoppingList.Click += new System.EventHandler(this.buttonShoppingList_Click);
            // 
            // buttonWriteReview
            // 
            this.buttonWriteReview.Location = new System.Drawing.Point(12, 273);
            this.buttonWriteReview.Name = "buttonWriteReview";
            this.buttonWriteReview.Size = new System.Drawing.Size(200, 23);
            this.buttonWriteReview.TabIndex = 9;
            this.buttonWriteReview.Text = "Write Review";
            this.buttonWriteReview.UseVisualStyleBackColor = true;
            this.buttonWriteReview.Click += new System.EventHandler(this.buttonWriteReview_Click);
            // 
            // SecondEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.buttonWriteReview);
            this.Controls.Add(this.buttonShoppingList);
            this.Controls.Add(this.buttonRegisterCustomer);
            this.Controls.Add(this.buttonBalanceTrees);
            this.Controls.Add(this.buttonAddTopNToShoppingList);
            this.Controls.Add(this.buttonSearchByWord);
            this.Controls.Add(this.buttonOrderProduct);
            this.Controls.Add(this.buttonListByCategory);
            this.Controls.Add(this.buttonSearchByPriceRange);
            this.Controls.Add(this.buttonSearchByName);
            this.Name = "SecondEnterForm";
            this.Text = "SecondEnterForm";
            this.ResumeLayout(false);
        }

        // Event handler for "Search Product by Name"
        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter product name:", "Search Product by Name", "");

            var results = virtualObjects.Where(obj => obj.Model.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, results.Select(r => r.ToString())));
            }
            else
            {
                MessageBox.Show("No products found.");
            }
        }

        // Event handler for "Search by Price Range"
        private void buttonSearchByPriceRange_Click(object sender, EventArgs e)
        {
            string minPriceStr = Microsoft.VisualBasic.Interaction.InputBox("Enter minimum price:", "Search by Price Range", "");
            string maxPriceStr = Microsoft.VisualBasic.Interaction.InputBox("Enter maximum price:", "Search by Price Range", "");

            if (decimal.TryParse(minPriceStr, out decimal minPrice) && decimal.TryParse(maxPriceStr, out decimal maxPrice))
            {
                var results = virtualObjects.Where(obj => obj.Price >= minPrice && obj.Price <= maxPrice).ToList();
                if (results.Any())
                {
                    MessageBox.Show(string.Join(Environment.NewLine, results.Select(r => r.ToString())));
                }
                else
                {
                    MessageBox.Show("No products found in the specified price range.");
                }
            }
            else
            {
                MessageBox.Show("Invalid price values.");
            }
        }

        // Event handler for "List by Category"
        private void buttonListByCategory_Click(object sender, EventArgs e)
        {
            string category = Microsoft.VisualBasic.Interaction.InputBox("Enter category:", "List by Category", "");

            var results = bst.FindByCategory(category);
            if (results.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, results.Select(r => $"{r} (Depth: {bst.GetDepth(bst.Root)}, Level: {bst.GetLevel(bst.Root, r)})")));
                MessageBox.Show($"Tree Depth: {bst.GetDepth(bst.Root)}, Number of Elements: {bst.Count}");
            }
            else
            {
                MessageBox.Show("No products found in the specified category.");
            }
        }

        // Event handler for "Order and Purchase Product"
        private void buttonOrderProduct_Click(object sender, EventArgs e)
        {
            string customerEmail = Microsoft.VisualBasic.Interaction.InputBox("Enter your email:", "Order and Purchase Product", "");
            var customer = CustomerRegistry.GetCustomerByEmail(customerEmail);

            if (customer == null)
            {
                MessageBox.Show("Customer not found. Please register first.");
                return;
            }

            var shoppingList = customer.GetShoppingList();
            var tempShoppingList = shoppingList.ToList();

            foreach (var item in tempShoppingList)
            {
                var obj = virtualObjects.FirstOrDefault(o => o.Model == item.Model);
                if (obj != null)
                {
                    obj.Quantity -= item.Quantity;
                    if (obj.Quantity == 0)
                    {
                        bst.Delete(obj);
                        heap.Remove(obj);
                        hashTable.Remove(item.Model, obj);
                        virtualObjects.Remove(obj);
                    }
                    customer.Purchase(obj, item.Quantity);
                }
            }

            MessageBox.Show("Products purchased successfully.");
        }

        // Event handler for "Search by Word"
        private void buttonSearchByWord_Click(object sender, EventArgs e)
        {
            string word = Microsoft.VisualBasic.Interaction.InputBox("Enter word to search for:", "Search by Word", "");

            var results = hashTable.SearchByWord(word);
            if (results.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, results.Select(r => r.ToString())));
            }
            else
            {
                MessageBox.Show("No products found containing the specified word.");
            }
        }

        // Event handler for "Add Top N to Shopping List"
        private void buttonAddTopNToShoppingList_Click(object sender, EventArgs e)
        {
            string customerEmail = Microsoft.VisualBasic.Interaction.InputBox("Enter your email:", "Add Top N to Shopping List", "");
            var customer = CustomerRegistry.GetCustomerByEmail(customerEmail);

            if (customer == null)
            {
                MessageBox.Show("Customer not found. Please register first.");
                return;
            }

            string category = Microsoft.VisualBasic.Interaction.InputBox("Enter category:", "Add Top N to Shopping List", "");
            string nStr = Microsoft.VisualBasic.Interaction.InputBox("Enter number of products to add:", "Add Top N to Shopping List", "");

            if (int.TryParse(nStr, out int n) && n > 0)
            {
                var results = heap.GetTopNCheapest(category, n).ToList();
                if (results.Any())
                {
                    foreach (var obj in results)
                    {
                        customer.AddToShoppingList(new marketItem
                        {
                            Category = obj.Category,
                            Brand = obj.Brand,
                            Model = obj.Model,
                            Quantity = obj.Quantity,
                            Price = obj.Price,
                            Review = obj.Review
                        });
                    }
                    MessageBox.Show("Products added to shopping list.");
                }
                else
                {
                    MessageBox.Show("No products found in the specified category.");
                }
            }
            else
            {
                MessageBox.Show("Invalid number of products.");
            }
        }

        // Event handler for "Balance Trees"
        private void buttonBalanceTrees_Click(object sender, EventArgs e)
        {
            bst.Balance();
            MessageBox.Show("Trees balanced successfully.");
        }

        // Event handler for "Register Customer"
        private void buttonRegisterCustomer_Click(object sender, EventArgs e)
        {
            string customerName = Microsoft.VisualBasic.Interaction.InputBox("Enter customer name:", "Register Customer", "");
            string customerEmail = Microsoft.VisualBasic.Interaction.InputBox("Enter customer email:", "Register Customer", "");

            var customer = new Customer(customerName, customerEmail);
            CustomerRegistry.Register(customer);

            MessageBox.Show("Customer registered successfully.");
        }

        // Event handler for "Shopping List"
        private void buttonShoppingList_Click(object sender, EventArgs e)
        {
            string customerEmail = Microsoft.VisualBasic.Interaction.InputBox("Enter your email:", "Shopping List", "");
            var customer = CustomerRegistry.GetCustomerByEmail(customerEmail);

            if (customer == null)
            {
                MessageBox.Show("Customer not found. Please register first.");
                return;
            }

            string model = Microsoft.VisualBasic.Interaction.InputBox("Enter product model to add to shopping list:", "Shopping List", "");
            string quantityStr = Microsoft.VisualBasic.Interaction.InputBox("Enter quantity:", "Shopping List", "1");

            if (int.TryParse(quantityStr, out int quantity) && quantity > 0)
            {
                var obj = virtualObjects.FirstOrDefault(o => o.Model == model);
                if (obj != null && obj.Quantity >= quantity)
                {
                    customer.AddToShoppingList(new marketItem
                    {
                        Category = obj.Category,
                        Brand = obj.Brand,
                        Model = obj.Model,
                        Quantity = quantity,
                        Price = obj.Price,
                        Review = obj.Review
                    });
                    MessageBox.Show("Product added to shopping list.");
                }
                else
                {
                    MessageBox.Show("Product not found or insufficient stock.");
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity.");
            }
        }

        // Event handler for "Write Review"
        private void buttonWriteReview_Click(object sender, EventArgs e)
        {
            string customerEmail = Microsoft.VisualBasic.Interaction.InputBox("Enter your email:", "Write Review", "");
            var customer = CustomerRegistry.GetCustomerByEmail(customerEmail);

            if (customer == null)
            {
                MessageBox.Show("Customer not found. Please register first.");
                return;
            }

            string model = Microsoft.VisualBasic.Interaction.InputBox("Enter product model to review:", "Write Review", "");

            var obj = virtualObjects.FirstOrDefault(o => o.Model == model);
            if (obj != null)
            {
                string reviewText = Microsoft.VisualBasic.Interaction.InputBox("Enter review text:", "Write Review", "");
                string reviewWithCustomer = $"{customer.Name}: {reviewText}";

                if (string.IsNullOrEmpty(obj.Review))
                {
                    obj.Review = reviewWithCustomer;
                }
                else
                {
                    obj.Review += $", {reviewWithCustomer}";
                }
                MessageBox.Show("Review added successfully.");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private Button buttonSearchByName;
        private Button buttonSearchByPriceRange;
        private Button buttonListByCategory;
        private Button buttonOrderProduct;
        private Button buttonSearchByWord;
        private Button buttonAddTopNToShoppingList;
        private Button buttonBalanceTrees;
        private Button buttonRegisterCustomer;
        private Button buttonShoppingList;
        private Button buttonWriteReview;
    }
}
