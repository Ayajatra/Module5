using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module5
{
    public partial class MainMenuForm : CoreForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Hide();
            new PurchaseForm().ShowDialog();
            Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Hide();
            new ReportForm().ShowDialog();
            Show();
        }
    }
}