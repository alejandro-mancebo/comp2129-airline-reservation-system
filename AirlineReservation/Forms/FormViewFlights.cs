using Presention.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presention.Forms
{
    public partial class FormViewFlights : Form
    {

        private FlightsModel flights; // = new FlightsModel();


        public FormViewFlights()
        {
            InitializeComponent();

            flights = new FlightsModel();
        }


        private void ViewFlights_Load(object sender, EventArgs e)
        {
            ShowFlights();
        }


        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
           
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ShowFlights()
        {
            dataGridView1.DataSource = flights.ShowFlights();
        }


        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FlightsModel flightsModel = new FlightsModel();

                flightsModel.FlightNumber = dataGridView1.CurrentRow.Cells["Flight"].Value.ToString();
                flightsModel.Origin = dataGridView1.CurrentRow.Cells["Origin"].Value.ToString();
                flightsModel.Destination = dataGridView1.CurrentRow.Cells["Destination"].Value.ToString();
                flightsModel.Capacity = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Capacity"].Value.ToString());
                string price =Validation.RemoveChars( dataGridView1.CurrentRow.Cells["Price"].Value.ToString());
                //flightsModel.Price = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Price"].Value.ToString());
                flightsModel.Price = Convert.ToDouble(price);
                flightsModel.FlightDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Date"].Value.ToString());
                flightsModel.FlightTime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Time"].Value.ToString());
                flightsModel.Duration = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Duration"].Value.ToString());

                FormAddFlight form = new FormAddFlight(flightsModel);
                form.ShowDialog();
                
            }
        }
    }
}
