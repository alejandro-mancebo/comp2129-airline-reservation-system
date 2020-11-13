using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presention.Model;
using Domain;
using Presentation.Tools;
using System.Windows;
using SystemColors = System.Drawing.SystemColors;


namespace Presention.Forms
{
    public partial class FormAddPerson : Form
    {

        private PersonModel personModel;
        private State state;
        private string id;


        public FormAddPerson()
        {
            InitializeComponent();

            personModel = new PersonModel();

            state = State.Additing;
            btnAddCustomer.Text = "Add Person";
        }


        public FormAddPerson(PersonModel personModel)
        {
            InitializeComponent();

            this.personModel = personModel;

            state = State.Editing;
        }


        private void FormAddPerson_Load(object sender, EventArgs e)
        {
            if (state == State.Editing)
            {
                FillCells();
                btnAddCustomer.Text = "Save";
               btnAddCustomer.Visible = false;
            }
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {

                try
                {
                    personModel.InsertPerson(
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtPhone.Text,
                        txtEmail.Text,
                        txtStreet.Text,
                        txtCity.Text,
                        txtProvince.Text,
                        txtPostalCode.Text);

                    string message = "Insert Successful !!!";
                    MessageInformation.Success(message);
                    //string caption = "Access to the Database";
                    //MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Hand);

                }
                catch (Exception ex)
                {
                    MessageInformation.Error(ex.ToString());
                }

                Close();
            }            
        }


        private void btnSaveEdition_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    personModel.EditPerson(
                        id,
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtPhone.Text,
                        txtEmail.Text,
                        txtStreet.Text,
                        txtCity.Text,
                        txtProvince.Text,
                        txtPostalCode.Text);

                    string message = "Update Successful!!!";
                    // string caption = "Access to the Database";
                    MessageInformation.Success(message);

                    //Close();
                }
                catch (Exception ex)
                {
                    MessageInformation.Error(ex.ToString());
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.ForeColor = Color.Black;
        }


        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.ForeColor = Color.Black;
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
        }


        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.ForeColor = Color.Black;
        }


        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            txtStreet.ForeColor = Color.Black;
        }


        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            txtCity.ForeColor = Color.Black;
        }


        private void txtProvince_TextChanged(object sender, EventArgs e)
        {
            txtProvince.ForeColor = Color.Black;
        }


        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            txtPostalCode.ForeColor = SystemColors.WindowText; 
        }


        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            txtPostalCode.Text = txtPostalCode.Text.ToUpper();
        }


        private void FillCells()
        {
            id = personModel.Id.ToString();
            txtFirstName.Text = personModel.FirstName;
            txtLastName.Text = personModel.LastName;
            txtPhone.Text = personModel.Phone;
            txtEmail.Text = personModel.Email;
            txtStreet.Text = personModel.Street;
            txtCity.Text = personModel.City;
            txtProvince.Text = personModel.Province;
            txtPostalCode.Text = personModel.PostalCode;
        }


        private bool ValidateInputs()
        {
            bool validate = true;

            if (!Validation.IsString(txtFirstName))
                validate = false;
            if (!Validation.IsString(txtLastName))
                validate = false;
            if (!Validation.IsValidEmail(txtEmail))
                validate = false;
            if (!Validation.IsValidPhone(txtPhone))
                validate = false;
            if (!Validation.IsString(txtCity))
                validate = false;
            if (!Validation.IsString(txtProvince))
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
