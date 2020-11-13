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
using Presentation.Tools;

namespace Presention.Forms
{
    public partial class FormAddFlight : Form
    {

        FlightsModel flight;
        private State state;


        public FormAddFlight()
        {
            InitializeComponent();

            flight = new FlightsModel();

            state = State.Additing;
            btnAddFlight.Text = "Add Flight";
        }


        public FormAddFlight(FlightsModel flightsModel)
        {
            InitializeComponent();

            flight = new FlightsModel();
            flight = flightsModel;

            state = State.Editing;
        }


        private void FormAddFlight_Load(object sender, EventArgs e)
        {
            if (state == State.Editing)
            {
                FillCells();
                btnAddFlight.Visible = false;
                txtFlightNumber.Enabled = false;
            }
        }


        private void btnAddFlight_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                try
                {
                    flight.InsertFlight(txtFlightNumber.Text,
                                        txtPortOrigin.Text,
                                        txtDestinationPort.Text,
                                        txtMaxNumberSeats.Text,
                                        txtPrice.Text,
                                        txtFlightDate.Text,
                                        txtFlightTime.Text,
                                        txtDuration.Text);

                    string message = "Insert Successful !!!";
                    // string caption = "Access to the Database";
                    MessageInformation.Success(message);

                    Close();
                }
                catch (Exception ex)
                {
                    MessageInformation.Error("Insertion fail\n\n" + ex);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    flight.EditFlight(txtFlightNumber.Text,
                                        txtPortOrigin.Text,
                                        txtDestinationPort.Text,
                                        txtMaxNumberSeats.Text,
                                        txtPrice.Text,
                                        txtFlightDate.Text,
                                        txtFlightTime.Text,
                                        txtDuration.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageInformation.Error(ex.ToString());
                }
            }
        }


        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtFlightNumber_Leave(object sender, EventArgs e)
        {
            txtFlightNumber.Text = txtFlightNumber.Text.ToUpper();
        }


        private void FillCells()
        {
            txtFlightNumber.Text = flight.FlightNumber.ToString();
            txtPortOrigin.Text = flight.Origin;
            txtDestinationPort.Text = flight.Destination;
            txtMaxNumberSeats.Text = flight.Capacity.ToString();
            txtPrice.Text = flight.Price.ToString();
            txtFlightDate.Text = String.Format("{0:MM/dd/yyyy}", flight.FlightDate);
            txtFlightTime.Text = String.Format("{0:hh:mm tt}", flight.FlightTime);
            txtDuration.Text = String.Format("{0:h:mm}", flight.Duration);
        }


        private bool ValidateInputs()
        {
            bool validate = true;

            if (!Validation.IsEmpty(txtFlightNumber))
                validate = false;
            if (!Validation.IsInteger(txtMaxNumberSeats))
                validate = false;
            if (!Validation.IsEmpty(txtPortOrigin))
                validate = false;
            if (!Validation.IsString(txtDestinationPort))
                validate = false;
            if (!Validation.IsDouble(txtPrice))
                validate = false;
            if (!Validation.IsDateTime(txtFlightDate))
                validate = false;
            if (!Validation.IsTime(txtFlightTime))
                validate = false;
            if (!Validation.IsTimeSpan(txtDuration))
                validate = false;

            if (!validate)
            {
                string message = "It is not allowed empty values or values are invalided !!!";
                MessageInformation.Error(message);
            }

            return validate;
        }


    }
}
