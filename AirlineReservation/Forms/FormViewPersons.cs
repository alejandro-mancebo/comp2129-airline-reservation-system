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
    public partial class FormViewPersons : Form
    {

        PersonModel personModel;


        public FormViewPersons()
        {
            InitializeComponent();

            personModel = new PersonModel();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormViewPersons_Load(object sender, EventArgs e)
        {
            ShowPersons();
        }


        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
           
        }


        private void ShowPersons()
        {
            dataGridView1.DataSource = personModel.ShowPersons();
        }


        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                personModel.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                personModel.FirstName = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                personModel.LastName = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                personModel.Phone = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                personModel.Email = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                personModel.Street = dataGridView1.CurrentRow.Cells["street"].Value.ToString();
                personModel.City = dataGridView1.CurrentRow.Cells["city"].Value.ToString();
                personModel.Province = dataGridView1.CurrentRow.Cells["province"].Value.ToString();
                personModel.PostalCode = dataGridView1.CurrentRow.Cells["postalCode"].Value.ToString();

                FormAddPerson form = new FormAddPerson(personModel);
                form.ShowDialog();
            }
        }
               
    }
}
