namespace Presention.Forms
{
    partial class FormAddFlight
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.txtMaxNumberSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortOrigin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinationPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFlightTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlightDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight number:";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlightNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNumber.Location = new System.Drawing.Point(276, 17);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(260, 31);
            this.txtFlightNumber.TabIndex = 1;
            this.txtFlightNumber.Leave += new System.EventHandler(this.txtFlightNumber_Leave);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(386, 377);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(150, 40);
            this.btnAddFlight.TabIndex = 2;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // txtMaxNumberSeats
            // 
            this.txtMaxNumberSeats.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxNumberSeats.Location = new System.Drawing.Point(276, 59);
            this.txtMaxNumberSeats.Name = "txtMaxNumberSeats";
            this.txtMaxNumberSeats.Size = new System.Drawing.Size(260, 31);
            this.txtMaxNumberSeats.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximum number of seats:";
            // 
            // txtPortOrigin
            // 
            this.txtPortOrigin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortOrigin.Location = new System.Drawing.Point(276, 103);
            this.txtPortOrigin.Name = "txtPortOrigin";
            this.txtPortOrigin.Size = new System.Drawing.Size(260, 31);
            this.txtPortOrigin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port of origin:";
            // 
            // txtDestinationPort
            // 
            this.txtDestinationPort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationPort.Location = new System.Drawing.Point(276, 146);
            this.txtDestinationPort.Name = "txtDestinationPort";
            this.txtDestinationPort.Size = new System.Drawing.Size(260, 31);
            this.txtDestinationPort.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destination port:";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(20, 377);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(150, 40);
            this.btnBackToMenu.TabIndex = 11;
            this.btnBackToMenu.Text = "Close";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(157, 30);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 21);
            this.lblMessage.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(276, 189);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 31);
            this.txtPrice.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFlightTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFlightDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFlightNumber);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaxNumberSeats);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBackToMenu);
            this.panel1.Controls.Add(this.txtPortOrigin);
            this.panel1.Controls.Add(this.txtDestinationPort);
            this.panel1.Controls.Add(this.btnAddFlight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(208, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 434);
            this.panel1.TabIndex = 18;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(276, 318);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(260, 31);
            this.txtDuration.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Duration:";
            // 
            // txtFlightTime
            // 
            this.txtFlightTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightTime.Location = new System.Drawing.Point(276, 275);
            this.txtFlightTime.Name = "txtFlightTime";
            this.txtFlightTime.Size = new System.Drawing.Size(260, 31);
            this.txtFlightTime.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Flight Time:";
            // 
            // txtFlightDate
            // 
            this.txtFlightDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightDate.Location = new System.Drawing.Point(276, 232);
            this.txtFlightDate.Name = "txtFlightDate";
            this.txtFlightDate.Size = new System.Drawing.Size(260, 31);
            this.txtFlightDate.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Flight Date (mm-dd-yyyy):";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(386, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessage);
            this.Name = "FormAddFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Flight";
            this.Load += new System.EventHandler(this.FormAddFlight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.TextBox txtMaxNumberSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortOrigin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinationPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFlightTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFlightDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}