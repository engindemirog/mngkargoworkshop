using Shopping.Business;
using Shopping.DataAccess;
using Shopping.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.FormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new SqlServerProductDal());

            MessageBox.Show(productManager.GetAll()[0].ProductName);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new SqlServerProductDal());
            productManager.Add(new Product {ProductName = "Engin" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new ProductDal());
            dataGridView1.DataSource = productManager.GetAll();
        }
    }
}
