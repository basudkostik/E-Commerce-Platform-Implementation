using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Marketplace
{
    public partial class Form1 : Form
    {
        private BinarySearchTree bst;
        private MaxHeap heap;
        private HashTable hashTable;
        private List<marketItem> virtualObjects;

        public Form1()
        {
            InitializeComponent();
            bst = new BinarySearchTree();
            heap = new MaxHeap();
            hashTable = new HashTable(100);

            LoadDataFromFile(@"C:\\Users\\turka\\OneDrive\\Masaüstü\\baduman\\Marketplace\\data.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void buttonFirstEnter_Click(object sender, EventArgs e)
        {
            FirstEnterForm firstEnterForm = new FirstEnterForm(bst, heap, hashTable, virtualObjects);
            firstEnterForm.Show();
        }

        private void buttonSecondEnter_Click(object sender, EventArgs e)
        {
            SecondEnterForm secondEnterForm = new SecondEnterForm(bst, heap, hashTable, virtualObjects);
            secondEnterForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxDisplay.Items.Clear();

            foreach (marketItem obj in virtualObjects)
            {
                listBoxDisplay.Items.Add(obj.ToString());
            }
        }

        private void LoadDataFromFile(string filePath)
        {
            var objects = marketItem.ReadObjectsFromFile(filePath);
            virtualObjects = new List<marketItem>(objects);

            foreach (var obj in virtualObjects)
            {
                heap.Add(obj);
                bst.Insert(obj);
                hashTable.Add(obj.Model, obj); 
            }
        }

        private void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
