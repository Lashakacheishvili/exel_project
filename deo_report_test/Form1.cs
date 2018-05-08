using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deo_report_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dep_excel_testEntities dp = new dep_excel_testEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var dataSave = new dep_excel()
            {
                dasaxeleba = dasaxeleba.Text,
                qalaqi = qalaqi.Text,
                raioni = raioni.Text,
                municipaliteti = municipaliteti.Text,
                daba = daba.Text,
                sofeli = sofeli.Text
            };
            dp.dep_excel.Add(dataSave);
            dp.SaveChanges();
            MessageBox.Show("Test");
        }
    }
}
