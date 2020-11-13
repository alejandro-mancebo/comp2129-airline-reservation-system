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
using Presention.Model;

namespace Presention.Forms
{
    public partial class FormSelectFlight : Form
    {

       
        private FlightsModel flightsModel = new FlightsModel();

        private string flightDestiantion;
        private string numberPassengers;


        public FlightsModel Flights { get => flightsModel; }


        public FormSelectFlight(string flightDestiantion, string numberPassengers)
        {
            InitializeComponent();

            this.flightDestiantion = flightDestiantion;
            this.numberPassengers = numberPassengers;
        }


        private void ShowFlights()
        {
            dataGridView1.DataSource = flightsModel.ShowFlights(flightDestiantion, numberPassengers);
        }


        private void FormSelectFlight_Load(object sender, EventArgs e)
        {
            ShowFlights();
        }


        private void btnAcceptCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                flightsModel.FlightNumber = dataGridView1.CurrentRow.Cells["Flight"].Value.ToString();
                flightsModel.Origin = dataGridView1.CurrentRow.Cells["Origin"].Value.ToString();
                flightsModel.Destination = dataGridView1.CurrentRow.Cells["Destination"].Value.ToString();
                flightsModel.Capacity =Convert.ToInt16( dataGridView1.CurrentRow.Cells["Capacity"].Value.ToString()); 
                
                if (dataGridView1.CurrentRow.Cells["Passengers"].Value.ToString() == "")
                {
                    flightsModel.NumberPassengers = 0;
                }
                else
                {
                    flightsModel.NumberPassengers = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Passengers"].Value.ToString());
                }

                flightsModel.Price = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Price"].Value.ToString());
                flightsModel.FlightDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Date"].Value.ToString());
                flightsModel.FlightTime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Time"].Value.ToString());

                Close();
            }
        }
    }
}
