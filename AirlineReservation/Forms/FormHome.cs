using Presention.Forms;
using Presention.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presention
{
    public partial class FormHome : Form
    {

        private Button currentButton;
        private string projectDirectory;
        private Form currentForm;      


        public FormHome()
        {
            InitializeComponent();

            string workingDirectory = Environment.CurrentDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestore.Visible = true;
            iconMaximize.Visible = false;
        }


        private void iconRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconMaximize.Visible = true;
            iconRestore.Visible = false;
        }


        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void ActiveButton(object senderBtn, Image image)
        {
            if (senderBtn != null)
            {
                currentButton = (Button)senderBtn;
                iconCurrentForm.Image = image;
                lblCurrentFormTitle.Text = currentButton.Text;
            }
        }


        private void DisableButton()
        {
            if (currentButton != null)
                lblCurrentFormTitle.Text = currentButton.Text;
        }


        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(projectDirectory + "\\icons\\flight_black_36x36.png");
            ActiveButton(sender, image);
            OpenForm(new FormAddFlight());
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(projectDirectory + "\\icons\\person_add_black_36x36.png");
            ActiveButton(sender, image);
            OpenForm(new FormAddPerson());
        }


        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(projectDirectory + @"\icons\description_black_36x36.png");
            ActiveButton(sender, image);
            OpenForm(new FormViewFlights());
        }


        private void btnViewPersons_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(projectDirectory + @"\icons\group_black_36x36.png");
            ActiveButton(sender, image);
            OpenForm(new FormViewPersons());
        }


        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(projectDirectory + @"\icons\chrome_reader_mode_black_36x36.png");
            ActiveButton(sender, image);
            OpenForm(new FormViewBooking());
        }


        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(projectDirectory + @"\icons\add_shopping_cart_black_36x36.png");
            ActiveButton(sender, image);
            OpenForm(new FormAddBooking());
        }


        private void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
