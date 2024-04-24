using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
//using Hotcakes.CommerceDTO.v1.Catalog;
//using Hotcakes.CommerceDTO.v1.Contacts;
//using Hotcakes.CommerceDTO.v1.Membership;
//using Hotcakes.CommerceDTO.v1.Orders;
//using Hotcakes.CommerceDTO.v1.Taxes;
//using Hotcakes.Web;

//using Hotcakes.CommerceDTO.v1;
//using Hotcakes.CommerceDTO.v1.Catalog;
//using Hotcakes.CommerceDTO.v1.Client;

namespace InventoryManager
{
    //string url = "http://example.com";
    //string key = "YOUR-API-KEY";

    //Api proxy = new Api(url, key);

    // specify the product inventory object to find
    ///var inventoryId = "f82bcaad-97e4-4e03-8683-998a09346009";

    // call the API to get the product inventory record
    //var inventory = proxy.ProductInventoryFind(inventoryId).Content;

    // update one or more inventory properties
    //inventory.QuantityReserved = 20;

    // call the API to create the new product inventory record
    //ApiResponse<ProductInventoryDTO> response = proxy.ProductInventoryUpdate(inventory);


    public partial class Form1 : Form
    {
        private void Terméklista()
        {
            var url = string.Empty;
            var key = string.Empty;

            if (url == string.Empty) url = "http://20.234.113.211:8097";
            if (key == string.Empty) key = "1-ca1f8d38-16ec-4b6c-8130-327ebda13857";

            //var proxy = new Api(url, key);

            //var s = proxy.ProductsFindAll();

        }

        //placeholder amíg ki nem találom az API-t

        private List<Product> productTest = new List<Product>
        {
            new Product { Name = "Product 1", Category = "Category A", ReservedInventory = 10, QuantityOnHand = 20, LowStock = 5, OutOfStock = 2 },
            new Product { Name = "Product 2", Category = "Category B", ReservedInventory = 5, QuantityOnHand = 15, LowStock = 3, OutOfStock = 1 },
            new Product { Name = "Product 3", Category = "Category A", ReservedInventory = 20, QuantityOnHand = 25, LowStock = 8, OutOfStock = 3 },
            new Product { Name = "Product 4", Category = "Category C", ReservedInventory = 15, QuantityOnHand = 30, LowStock = 10, OutOfStock = 5 }
        };

        private List<Product> filteredProducts;

        private UserControl currentControl;

        public Form1()
        {
            InitializeComponent();

            listBoxProduct.SelectedIndex = -1;
            listBoxCategory.SelectedIndex = -1;

            filteredProducts = productTest.ToList();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            if (listBoxProduct.SelectedIndex == -1) // Show all products if no item is selected in listBoxProduct
            {
                dataGridView.DataSource = filteredProducts;
            }
            else
            {
                string productName = ((Product)listBoxProduct.SelectedItem).Name;
                dataGridView.DataSource = new List<Product> { filteredProducts.FirstOrDefault(p => p.Name == productName) };
            }
        }

        private void textBoxProduct_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxProduct.Text.ToLower();
            listBoxProduct.DataSource = filteredProducts
                .Where(p => string.IsNullOrEmpty(filterText) || p.Name.ToLower().Contains(filterText))
                .ToList();

            listBoxProduct.DisplayMember = "Name";
            listBoxProduct.SelectedIndex = -1;
        }

        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void SwitchToOverrideControl()
        {
            if (currentControl != null)
                panel.Controls.Remove(currentControl);

            UcOverride overrideControl = new UcOverride();
            overrideControl.Dock = DockStyle.Fill;
            panel.Controls.Add(overrideControl);
            currentControl = overrideControl;
        }

        private void SwitchToAddControl()
        {
            if (currentControl != null)
                panel.Controls.Remove(currentControl);

            UcAdd addControl = new UcAdd();
            addControl.Dock = DockStyle.Fill;
            panel.Controls.Add(addControl);
            currentControl = addControl;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            string catFilter = textBoxCategory.Text;
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            SwitchToAddControl();
        }

        private void btnOverride_Click_1(object sender, EventArgs e)
        {
            SwitchToOverrideControl();
        }


    }
}