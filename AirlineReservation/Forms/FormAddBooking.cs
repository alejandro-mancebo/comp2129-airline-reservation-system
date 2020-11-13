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
using System.Windows;
using MessageBox = System.Windows.MessageBox;
using Presentation.Tools;
using System.Data.SqlClient;

namespace Presention.Forms
{
    public partial class FormAddBooking : Form
    {

        PersonModel personModel;
        FlightsModel flightModel;
        BookingModel bookingModel;

        private string customerId;
        private int capacity;
        private int numberPassengers;
        private double price;

        private State state;


        public FormAddBooking()
        {
            InitializeComponent();

            personModel = new PersonModel();
            flightModel = new FlightsModel();
            bookingModel = new BookingModel();

            customerId = "0";

            state = State.Additing;

            btnAddBooking.Text = "Add Booking";
        }


        public FormAddBooking(PersonModel personModel, FlightsModel flightModel, BookingModel bookingModel)
        {
            InitializeComponent();

            this.personModel = personModel;
            this.flightModel = flightModel;
            this.bookingModel = bookingModel;

            customerId = personModel.Id.ToString();

            state = State.Editing;

        }


        private void FormAddBooking_Load(object sender, EventArgs e)
        {

            cmbSelectCustomer.DataSource = personModel.PersonList();
            cmbSelectCustomer.ValueMember = "id";
            cmbSelectCustomer.DisplayMember = "Name";

            cmbSelectDestination.DataSource = flightModel.FlightDestinationList();
            cmbSelectDestination.ValueMember = "Destination";

            if (state == State.Additing)
            {
                cmbSelectCustomer.SelectedIndex = -1;
                cmbSelectDestination.SelectedIndex = -1;
            }
            else
            {
                label1.Visible = false;
                cmbSelectCustomer.Visible = false;

                label2.Visible = false;
                cmbSelectDestination.Visible = false;

                label3.Visible = false;
                txtNumberPassengers.Visible = false;

                textBox7.Enabled = false;
                btnSelectFlight.Visible = false;
                btnAddBooking.Visible = false;

                showCustomer();
                showFlight();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAddBooking_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                if ((capacity - numberPassengers) >= Convert.ToInt16(txtNumberPassengers.Text))
                {
                    BookingModel bookingModel = new BookingModel();

                    try
                    {
                        bookingModel.InsertBooking(textBox7.Text, textBox8.Text, customerId, textBox1.Text);
                      
                        string message = "Insert Successful !!!";
                        MessageInformation.Success(message);

                        clearSelecion();
                        clearFlightDetails();
                    }
                    catch (SqlException ex)
                    {
                        string message = $"Customer {personModel.FirstName} {personModel.LastName} was already booked.\n" +
                            $"Flight {flightModel.FlightNumber}.\n" +
                            $"Destination {flightModel.Destination}";
                        MessageInformation.Error(message);
                    }
                    catch (Exception ex)
                    {
                        string message = "Booking was not added !!!";
                        MessageInformation.Error(message);
                    }
                }
                else
                {
                    string message = $"Flight {textBox1.Text}\n\nIt has not capacity!!!";
                    MessageInformation.Error(message);
                }
            }
            else
            {
                string message = "";

                if (cmbSelectCustomer.SelectedValue == null)
                {
                    message += "- Please select a Customer\n\n";
                }
                else
                {
                    message += "- Please select a flight";
                }

                MessageInformation.Error(message);
            }
        }


        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            string message = $"Flight number: {flightModel.FlightNumber} \n" +
                $"From {flightModel.Origin} to {flightModel.Destination}\n" +
                $"Customer: {personModel.FirstName} {personModel.LastName}\n\n" +
                $"Do you want to cancel this order";

            MessageBoxResult result = MessageBox.Show(message, $"Cancel Booking Order: {bookingModel.Id}", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                bookingModel.CancelBooking(bookingModel.Id.ToString());
                string temp = "-" + textBox7.Text;               
                message = "Booking was Successful Canceled!!!";
                MessageInformation.Success(message);
            }

            Close();
        }


        private void btnAcceptCustomer_Click(object sender, EventArgs e)
        {
            BookingModel bookingModel = new BookingModel();

            if (customerId != "0")
            {
                dataGridView1.DataSource = bookingModel.ShowByCustomer(customerId);
            }
        }


        private void btnSelectFlight_Click(object sender, EventArgs e)
        {

            if (cmbSelectDestination.SelectedIndex != -1 && txtNumberPassengers.Text != null)
            {
                using (
                      FormSelectFlight selectedFlight = new FormSelectFlight(cmbSelectDestination.SelectedValue.ToString(), txtNumberPassengers.Text)
                      )
                {
                    if (selectedFlight.ShowDialog() == DialogResult.OK)
                    {
                        flightModel = selectedFlight.Flights;

                        textBox1.Text = selectedFlight.Flights.FlightNumber.ToString();
                        textBox2.Text = selectedFlight.Flights.Origin.ToString();
                        textBox3.Text = selectedFlight.Flights.Destination.ToString();
                        textBox4.Text = selectedFlight.Flights.FlightDate.ToString("ddd, MMM dd, yyyy");
                        textBox5.Text = selectedFlight.Flights.FlightTime.ToString("hh:mm tt");
                        price = Convert.ToDouble(selectedFlight.Flights.Price.ToString());
                        textBox6.Text = price.ToString();
                        textBox7.Text = txtNumberPassengers.Text;
                        double amount = price * Convert.ToInt32(txtNumberPassengers.Text);
                        textBox8.Text = amount.ToString();

                        capacity = Convert.ToInt16(selectedFlight.Flights.Capacity.ToString());
                        numberPassengers = Convert.ToInt16(selectedFlight.Flights.NumberPassengers.ToString());
                    }
                }
            }
        }


        private void cmbSelectCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {

            customerId = cmbSelectCustomer.SelectedValue.ToString();

            personModel.GetPerson(customerId);

            string firstName = personModel.FirstName;
            string lastName = personModel.LastName;
            string phone = personModel.Phone;
            lblName.Text = $"{firstName} {lastName} - {phone}";
            lblEmail.Text = personModel.Email;
            string city = personModel.City;
            string province = personModel.Province;
            lblAddress.Text = $"{city}, {province}";
        }

       
        private void txtNumberPassengers_TextChanged(object sender, EventArgs e)
        {
            if (Validation.IsEmpty(textBox7))
            {
                textBox7.Text = txtNumberPassengers.Text;
                double amount = price * Convert.ToInt32(txtNumberPassengers.Text);
                textBox8.Text = amount.ToString();
            }
        }


        private void cmbSelectDestination_TextChanged(object sender, EventArgs e)
        {
            clearFlightDetails();
        }


        private void showCustomer()
        {
            customerId = cmbSelectCustomer.SelectedValue.ToString();
            personModel.GetPerson(bookingModel.CustomerID.ToString());

            string firstName = personModel.FirstName;
            string lastName = personModel.LastName;
            string phone = personModel.Phone;
            lblName.Text = $"{firstName} {lastName} - {phone}";
            lblEmail.Text = personModel.Email;
            string city = personModel.City;
            string province = personModel.Province;
            lblAddress.Text = $"{city}, {province}";
        }


        private void showFlight()
        {
            textBox1.Text = flightModel.FlightNumber.ToString();
            textBox2.Text = flightModel.Origin.ToString();
            textBox3.Text = flightModel.Destination.ToString();
            textBox4.Text = flightModel.FlightDate.ToString("ddd, MMM dd, yyyy");
            textBox5.Text = flightModel.FlightTime.ToString("hh:mm tt");
            price = Convert.ToDouble(flightModel.Price.ToString());
            textBox6.Text = price.ToString();
            textBox7.Text = bookingModel.NumberTickets.ToString();
            double amount = price * Convert.ToInt32(txtNumberPassengers.Text);
            textBox8.Text = amount.ToString();

            capacity = Convert.ToInt16(flightModel.Capacity.ToString());
            numberPassengers = Convert.ToInt16(bookingModel.NumberTickets.ToString());
        }


        private void clearSelecion()
        {
            lblName.Text = "No Selected";
            lblEmail.Text = "";
            lblAddress.Text = "";
            cmbSelectCustomer.SelectedIndex = -1;
            cmbSelectDestination.SelectedIndex = -1;
            txtNumberPassengers.Text = "1";

        }


        private void clearFlightDetails()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }


        private bool ValidateInputs()
        {
            bool validate = true;

            if (cmbSelectCustomer.SelectedValue == null)
                validate = false;
            if (!Validation.IsEmpty(textBox1))
                validate = false;
            if (!Validation.IsEmpty(textBox2))
                validate = false;
            if (!Validation.IsEmpty(textBox3))
                validate = false;
            if (!Validation.IsEmpty(textBox4))
                validate = false;
            if (!Validation.IsEmpty(textBox5))
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
