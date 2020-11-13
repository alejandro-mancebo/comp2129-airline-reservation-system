namespace Presention
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconCurrentForm = new System.Windows.Forms.PictureBox();
            this.lblCurrentFormTitle = new System.Windows.Forms.Label();
            this.iconRestore = new System.Windows.Forms.PictureBox();
            this.iconMinimize = new System.Windows.Forms.PictureBox();
            this.iconMaximize = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.btnViewPersons = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnViewFlights = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelForm.Controls.Add(this.panelContainer);
            this.panelForm.Controls.Add(this.panelHeader);
            this.panelForm.Controls.Add(this.panelMenu);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1200, 675);
            this.panelForm.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(210, 56);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(990, 619);
            this.panelContainer.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(214, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 150);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(159, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diamond Airlines";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelHeader.Controls.Add(this.iconCurrentForm);
            this.panelHeader.Controls.Add(this.lblCurrentFormTitle);
            this.panelHeader.Controls.Add(this.iconRestore);
            this.panelHeader.Controls.Add(this.iconMinimize);
            this.panelHeader.Controls.Add(this.iconMaximize);
            this.panelHeader.Controls.Add(this.iconClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(210, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(990, 56);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // iconCurrentForm
            // 
            this.iconCurrentForm.Image = ((System.Drawing.Image)(resources.GetObject("iconCurrentForm.Image")));
            this.iconCurrentForm.Location = new System.Drawing.Point(15, 12);
            this.iconCurrentForm.Name = "iconCurrentForm";
            this.iconCurrentForm.Size = new System.Drawing.Size(36, 36);
            this.iconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrentForm.TabIndex = 4;
            this.iconCurrentForm.TabStop = false;
            // 
            // lblCurrentFormTitle
            // 
            this.lblCurrentFormTitle.AutoSize = true;
            this.lblCurrentFormTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFormTitle.Location = new System.Drawing.Point(41, 19);
            this.lblCurrentFormTitle.Name = "lblCurrentFormTitle";
            this.lblCurrentFormTitle.Size = new System.Drawing.Size(74, 22);
            this.lblCurrentFormTitle.TabIndex = 5;
            this.lblCurrentFormTitle.Text = "  Home";
            // 
            // iconRestore
            // 
            this.iconRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestore.Image = ((System.Drawing.Image)(resources.GetObject("iconRestore.Image")));
            this.iconRestore.Location = new System.Drawing.Point(920, 8);
            this.iconRestore.Name = "iconRestore";
            this.iconRestore.Size = new System.Drawing.Size(28, 28);
            this.iconRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestore.TabIndex = 3;
            this.iconRestore.TabStop = false;
            this.iconRestore.Visible = false;
            this.iconRestore.Click += new System.EventHandler(this.iconRestore_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimize.Image")));
            this.iconMinimize.Location = new System.Drawing.Point(886, 8);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(28, 28);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimize.TabIndex = 2;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximize.Image")));
            this.iconMaximize.Location = new System.Drawing.Point(920, 9);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(28, 28);
            this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximize.TabIndex = 1;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(954, 8);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(28, 28);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClose.TabIndex = 0;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMenu.Controls.Add(this.btnViewBooking);
            this.panelMenu.Controls.Add(this.btnViewPersons);
            this.panelMenu.Controls.Add(this.btnAddPerson);
            this.panelMenu.Controls.Add(this.btnViewFlights);
            this.panelMenu.Controls.Add(this.btnAddBooking);
            this.panelMenu.Controls.Add(this.btnAddFlight);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 675);
            this.panelMenu.TabIndex = 0;
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewBooking.FlatAppearance.BorderSize = 0;
            this.btnViewBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBooking.Image")));
            this.btnViewBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewBooking.Location = new System.Drawing.Point(0, 209);
            this.btnViewBooking.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnViewBooking.Size = new System.Drawing.Size(210, 50);
            this.btnViewBooking.TabIndex = 6;
            this.btnViewBooking.Text = "  View Booking";
            this.btnViewBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewBooking.UseVisualStyleBackColor = true;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // btnViewPersons
            // 
            this.btnViewPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPersons.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewPersons.FlatAppearance.BorderSize = 0;
            this.btnViewPersons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnViewPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPersons.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPersons.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewPersons.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPersons.Image")));
            this.btnViewPersons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPersons.Location = new System.Drawing.Point(0, 159);
            this.btnViewPersons.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnViewPersons.Name = "btnViewPersons";
            this.btnViewPersons.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnViewPersons.Size = new System.Drawing.Size(210, 50);
            this.btnViewPersons.TabIndex = 2;
            this.btnViewPersons.Text = "  View Persons";
            this.btnViewPersons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPersons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewPersons.UseVisualStyleBackColor = true;
            this.btnViewPersons.Click += new System.EventHandler(this.btnViewPersons_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPerson.Location = new System.Drawing.Point(0, 320);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddPerson.Size = new System.Drawing.Size(210, 50);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "  Add Person";
            this.btnAddPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnViewFlights
            // 
            this.btnViewFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewFlights.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewFlights.FlatAppearance.BorderSize = 0;
            this.btnViewFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnViewFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFlights.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFlights.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewFlights.Image = ((System.Drawing.Image)(resources.GetObject("btnViewFlights.Image")));
            this.btnViewFlights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFlights.Location = new System.Drawing.Point(0, 109);
            this.btnViewFlights.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnViewFlights.Name = "btnViewFlights";
            this.btnViewFlights.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnViewFlights.Size = new System.Drawing.Size(210, 50);
            this.btnViewFlights.TabIndex = 3;
            this.btnViewFlights.Text = "  View Flights";
            this.btnViewFlights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFlights.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewFlights.UseVisualStyleBackColor = true;
            this.btnViewFlights.Click += new System.EventHandler(this.btnViewFlights_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddBooking.FlatAppearance.BorderSize = 0;
            this.btnAddBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBooking.Image")));
            this.btnAddBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBooking.Location = new System.Drawing.Point(0, 370);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddBooking.Size = new System.Drawing.Size(210, 50);
            this.btnAddBooking.TabIndex = 4;
            this.btnAddBooking.Text = "  Add Booking";
            this.btnAddBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddFlight.FlatAppearance.BorderSize = 0;
            this.btnAddFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFlight.Image")));
            this.btnAddFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFlight.Location = new System.Drawing.Point(0, 270);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddFlight.Size = new System.Drawing.Size(210, 50);
            this.btnAddFlight.TabIndex = 1;
            this.btnAddFlight.Text = "  Add Flight";
            this.btnAddFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diamond Airlines";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelForm.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.PictureBox iconMaximize;
        private System.Windows.Forms.PictureBox iconRestore;
        private System.Windows.Forms.PictureBox iconMinimize;
        private System.Windows.Forms.Button btnViewBooking;
        private System.Windows.Forms.Button btnViewPersons;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnViewFlights;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentFormTitle;
        private System.Windows.Forms.PictureBox iconCurrentForm;
    }
}

