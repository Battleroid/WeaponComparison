using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponComparison
{
    public partial class DropoffChart : Form
    {
        public DropoffChart() {
            InitializeComponent();
            this.dropoffDamageChart.Series.Clear();
        }

        private void DropoffChart_FormClosing(object sender, FormClosingEventArgs e) {
            // prevent closing of form to avoid crashing when Comparator calls for charts/form
            e.Cancel = true;
            this.Hide();
        }
    }
}
