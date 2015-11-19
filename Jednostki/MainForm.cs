using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jednostki
{
    public partial class MainForm : Form
    {
        private VoltageUnit Volt = new VoltageUnit();
        private ElectricUnit Electric = new ElectricUnit();
        private LenghtUnits Lenght = new LenghtUnits();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void rbtnVoltage_Click(object sender, EventArgs e)
        {
            cmbFirst.Items.Clear();
            cmbSecond.Items.Clear();
            cmbFirst.ValueMember = "value";
            cmbFirst.DisplayMember = "name";

            cmbFirst.DataSource = Volt.preUnits;

            //foreach(PreUnits preUnits in Volt.preUnits)
            //{

            //    cmbSecond.Items.Add(preUnits);
            //}
        }

        private void rbtnLenght_Click(object sender, EventArgs e)
        {
            cmbFirst.Items.Clear();
            cmbSecond.Items.Clear();
            foreach(PreUnits preUnit in Lenght.preUnits)
            {
                cmbFirst.Items.Add(preUnit);
            }

            foreach(PreUnits preUnit in Lenght.preUnits)
            {
              
                cmbSecond.Items.Add(preUnit.name + Lenght.unit);
            }
        }

        private void rbtnElectricCulomb_Click(object sender, EventArgs e)
        {
            cmbFirst.Items.Clear();
            cmbSecond.Items.Clear();
            foreach (PreUnits preUnit in Electric.preUnits)
            {
                cmbFirst.Items.Add(preUnit.name + Electric.unit);
            }

            foreach (PreUnits preUnit in Electric.preUnits)
            {
                cmbSecond.Items.Add(preUnit.name + Electric.unit);
            }
        }
    }
}
