using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        private VehicleCollectionGeneric<Vehicle> vehicleCollection;
        public Form1()
        {
            InitializeComponent();
            rbPlane.CheckedChanged += rb_CheckedChanged;
            rbCar.CheckedChanged += rb_CheckedChanged;
            rbShip.CheckedChanged += rb_CheckedChanged;
            vehicleCollection = new VehicleCollectionGeneric<Vehicle>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                if (rb == rbPlane)
                {
                    txtAltitude.Enabled = true;
                    txtPassengers.Enabled = false;
                    txtPort.Enabled = false;
                }
                else if (rb == rbCar)
                {
                    txtAltitude.Enabled = false;
                    txtPassengers.Enabled = false;
                    txtPort.Enabled = false;
                }
                else if (rb == rbShip)
                {
                    txtAltitude.Enabled = false;
                    txtPassengers.Enabled = true;
                    txtPort.Enabled = true;
                }
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            Vehicle vehicle;
            if (rbPlane.Checked)
            {
                vehicle = new Plane();
                (vehicle as Plane).Altitude = Convert.ToDouble(txtAltitude.Text);
            }
            else if (rbCar.Checked)
            {
                vehicle = new Car();
            }
            else
            {
                vehicle = new Ship();
                (vehicle as Ship).NumberOfPassengers = Convert.ToInt32(txtPassengers.Text);
                (vehicle as Ship).PortOfRegistry = txtPort.Text;
            }

            vehicle.Price = Convert.ToDouble(txtPrice.Text);
            vehicle.Speed = Convert.ToDouble(txtSpeed.Text);
            vehicle.Year = Convert.ToInt32(txtYear.Text);

            vehicleCollection.AddVehicle(vehicle);
        }

        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {
            vehicleCollection.DisplayAllVehiclesInfo();
        }
    }

    class VehicleCollectionGeneric<T> where T : Vehicle
    {
        private Queue<T> vehiclesQueue;

        public VehicleCollectionGeneric()
        {
            vehiclesQueue = new Queue<T>();
        }

        public void AddVehicle(T vehicle)
        {
            vehiclesQueue.Enqueue(vehicle);
        }

        public void DisplayAllVehiclesInfo()
        {
            foreach (T vehicle in vehiclesQueue)
            {
                vehicle.DisplayInfo();
            }
        }
    }

    abstract class Vehicle
    {
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public abstract void DisplayInfo();
    }

    class Plane : Vehicle
    {
        public double Altitude { get; set; }

        public override void DisplayInfo()
        {
            MessageBox.Show($"Plane - Price: {Price}, Speed: {Speed}, Year: {Year}, Altitude: {Altitude}");
        }
    }

    class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            MessageBox.Show($"Car - Price: {Price}, Speed: {Speed}, Year: {Year}");
        }
    }

    class Ship : Vehicle
    {
        public int NumberOfPassengers { get; set; }
        public string PortOfRegistry { get; set; }

        public override void DisplayInfo()
        {
            MessageBox.Show($"Ship - Price: {Price}, Speed: {Speed}, Year: {Year}, Passengers: {NumberOfPassengers}, Port: {PortOfRegistry}");
        }
    }
}
