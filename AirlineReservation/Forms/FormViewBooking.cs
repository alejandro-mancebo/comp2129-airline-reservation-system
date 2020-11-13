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
    public partial class FormViewBooking : Form
    {

        BookingModel bookingModel;


        public FormViewBooking()
        {
            InitializeComponent();

            bookingModel = new BookingModel();
        }


        private void FormViewBooking_Load(object sender, EventArgs e)
        {
            ShowBooking();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                bool isCanceled = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsCanceled"].Value.ToString());
                string bookingID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                if (!isCanceled) { 

                BookingModel bookingModel = new BookingModel();                
                bookingModel.GetBooking(bookingID);

                FlightsModel flightsModel = new FlightsModel();
                string flightNumber = dataGridView1.CurrentRow.Cells["Flight"].Value.ToString();
                flightsModel.GetFlight(flightNumber);

                PersonModel personModel = new PersonModel();
                string id = dataGridView1.CurrentRow.Cells["Cust. Id"].Value.ToString();
                personModel.GetPerson(id); 

                    FormAddBooking form = new FormAddBooking(personModel, flightsModel, bookingModel);
                form.ShowDialog();              
}
                else
                {
                    string message = $"This booking order {bookingID} is already canceled!!!";
                    MessageInformation.Information(message);
                }               
            }
        }


        private void ShowBooking()
        {
            dataGridView1.DataSource = bookingModel.Show();
        }

    }
}
