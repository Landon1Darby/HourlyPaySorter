using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaySorter_lab__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.personelDataSet.Table);

        }

        private void SortAscending_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.personelDataSet.Table);
            dataGridView1.Sort(dataGridView1.Columns["hourlyPayRateDataGridViewTextBoxColumn"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Decending_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.personelDataSet.Table);
            dataGridView1.Sort(dataGridView1.Columns["hourlyPayRateDataGridViewTextBoxColumn"], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
