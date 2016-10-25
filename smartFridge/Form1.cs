using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace smartFridge
{
    public partial class Form1 : Form
    {
        bool decision;
        smartFridgeDBEntities context = new smartFridgeDBEntities();
        ProductInFridge deletedProduct = new ProductInFridge();
      //  List<Product> productList = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            panelInside.Visible = false;
            panelCookBook.Visible = false;
            panelAdd.Visible = false;
            panelWelcome.Visible = true;
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            panelInside.Visible = true;
            panelWelcome.Visible = false;
            panelCookBook.Visible = false;
            panelAdd.Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            panelWelcome.Visible = false;
            panelInside.Visible = false;
            panelCookBook.Visible = false;
        }
        private void btnCookbook_Click(object sender, EventArgs e)
        {
            panelCookBook.Visible = true;
            panelWelcome.Visible = false;
            panelInside.Visible = false;
            panelAdd.Visible = false;
        }
        private void codeTxtBox_TextChanged(object sender, EventArgs e)
        {
            String code = codeTxtBox.Text;
            codeLbl.Text = code;
        }
        public bool getProductData()
        {
            if (string.IsNullOrWhiteSpace(codeTxtBox.Text))
            {
                MessageBox.Show("Wprowadź kod produktu.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(nameTxtBox.Text))
            {
                MessageBox.Show("Wprowadź nazwę produktu.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(amountNumericUpDown.Text))
            {
                MessageBox.Show("Wprowadź ilość produktów.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(priceTxtBox.Text))
            {
                MessageBox.Show("Wprowadź cenę produktu.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(unitComboBox.Text))
            {
                MessageBox.Show("Wprowadź jednostkę produktu.");
                return false;
            }
            else
            {
                Console.WriteLine("Wprowadzono wszystkie dane");
                return true;
            }
        }
        public void cleanAllBoxes()
        {
            nameTxtBox.Clear();
            amountNumericUpDown.ResetText();
            priceTxtBox.Clear();
            unitComboBox.ResetText();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            barcodeChecked(decision);
        }

        //czy wjebac to do klas product i productInFridge
        private ProductInFridge addProductToFridge(String bcode, String amount, String unit)
        {
            ProductInFridge product = new ProductInFridge
            {
                BarcodeNumber = bcode,
                Amount = amount,
                Unit = unit
            };
            return product;
        }
        private Product addProduct(String prodName, String prodBarcode, String prodPrice)
        {
            Product product = new Product
            {
                Name = prodName,
                Barcode = prodBarcode,
                Price = prodPrice
            };
            return product;
        }
   
        private bool checkBarcode()
        {
            var prod = context.Products.Find(codeTxtBox.Text);                                      //używam PK
            if (prod == null)
            {
                MessageBox.Show("NIE MA TAKIEGO BARCODE, UZUPEŁNIJ RESZTĘ DANYCH");
                return false;
            }
            else
            {
                nameTxtBox.Text = prod.Name;
                priceTxtBox.Text = prod.Price;
                //MessageBox.Show("Dodaj ilość.");
                amountNumericUpDown.BackColor = Color.Red;
                unitComboBox.BackColor = Color.Red;
                return true;
            }
        }

        private void codeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decision = checkBarcode();
            }
        }

        private void barcodeChecked(bool decision)
        {
            if (decision)
            {
                if (amountNumericUpDown.Value != 0)
                {
                    context.ProductInFridges.Add(addProductToFridge(codeTxtBox.Text, amountNumericUpDown.Value.ToString(), unitComboBox.Text));
                    MessageBox.Show("Dodano do Products in fridge");
                }
                else
                {
                    MessageBox.Show("Dodaj ilość.");
                }
            }
            else
            {
                if (getProductData())
                {
                    context.Products.Add(addProduct(nameTxtBox.Text, codeTxtBox.Text, priceTxtBox.Text));
                    context.ProductInFridges.Add(addProductToFridge(codeTxtBox.Text, amountNumericUpDown.Value.ToString(), unitComboBox.Text));         //prod.barcode czy codeTxtBox.text
                    MessageBox.Show("Dodano do Products oraz Products in fridge");
                }
                else
                {
                    MessageBox.Show("Uzupełnij dane produktu");
                }
            }
            context.SaveChanges();
        }

        private ProductInFridge findProductInFridge(String barcode)
        {
            var prod = context.ProductInFridges.
                Where(p => p.BarcodeNumber == barcode).
                FirstOrDefault();                                                       //używam query
            if (prod == null)
            {
                return null;
            }
            else
            {
                return prod;
            }
         }

        void setBoxes(ProductInFridge prod)
        {
            deleteProdCodeTxtBox.Text = prod.BarcodeNumber;
            deleteNameTxtBox.Text = prod.Product.Name;
            deleteAmountTxtBox.Text = prod.Amount;
            deleteUnitLabel.Text = prod.Unit;
        }
        void cleanDeleteBoxes()
        {
            deleteProdCodeTxtBox.Clear();
            deleteNameTxtBox.Clear();
            deleteAmountTxtBox.Clear();
            deleteUnitLabel.Text = "[]";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(deleteProdCodeTxtBox.Text)) 
            {
                MessageBox.Show("Wprowadz kod produktu, który chcesz usunać.");
                deleteProdCodeTxtBox.BackColor = Color.Red;
            }
            else
            {
                context.ProductInFridges.Remove(deletedProduct);
                context.SaveChanges();
                MessageBox.Show("Usunięto produkt.");
                cleanDeleteBoxes();
                
            }
        }

        private void deleteProdCodeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var delProduct = findProductInFridge(deleteProdCodeTxtBox.Text);
                if (delProduct != null)
                {
                    deletedProduct = delProduct;
                    setBoxes(delProduct);
                }
                else
                {
                    MessageBox.Show("Nie ma takiego produktu");
                }
            }
            
        }



    }
}
