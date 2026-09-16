using System;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace bt4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string name = txtName.Text;

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvData.Rows.Add(code, name);
            txtCode.Clear();
            txtName.Clear();
            txtCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvData.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui long chon dong can xoa!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}