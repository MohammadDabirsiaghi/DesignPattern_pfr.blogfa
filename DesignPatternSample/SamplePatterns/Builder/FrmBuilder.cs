using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamplePatterns.Builder
{
    public partial class FrmBuilder : Form
    {
        public FrmBuilder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleBuilder vehicleBuilder = new CarBuilder();
            Shop shop = new Shop();
            shop.Construct(vehicleBuilder);
            Vehicle vehicle = vehicleBuilder.GetVehicle();
            MessageBox.Show(vehicle.VehicleType.ToString());
        }
    }
}
