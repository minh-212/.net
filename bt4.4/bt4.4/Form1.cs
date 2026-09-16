using System;
using System.Windows.Forms;

namespace bt4._4
{
    public partial class Form1 : Form
    {
        public class FoodItem
        {
            public string Name { get; set; } = string.Empty;
            public int Price { get; set; }

            public override string ToString()
            {
                return $"{Name} ({Price}k)";
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitMenu();
        }

        private void InitMenu()
        {
            lstMenu.Items.Clear();
            lstMenu.Items.Add(new FoodItem { Name = "Hamburger", Price = 50 });
            lstMenu.Items.Add(new FoodItem { Name = "Pizza", Price = 120 });
            lstMenu.Items.Add(new FoodItem { Name = "Ga Ran", Price = 35 });
            lstMenu.Items.Add(new FoodItem { Name = "Pepsi", Price = 15 });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem is FoodItem selectedFood)
            {
                lstSelected.Items.Add(selectedFood);
                UpdateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem is FoodItem selectedFood)
            {
                lstSelected.Items.Remove(selectedFood);
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            int total = 0;
            foreach (FoodItem item in lstSelected.Items)
            {
                total += item.Price;
            }
            lblTotal.Text = $"Tong tien: {total}k VNĐ";
        }
    }
}