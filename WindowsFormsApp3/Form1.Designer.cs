namespace WindowsFormsApp3
{
    partial class Form1
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtPassengers = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.rbPlane = new System.Windows.Forms.RadioButton();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbShip = new System.Windows.Forms.RadioButton();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnShowAllInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 29);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 0;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(94, 91);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtSpeed.TabIndex = 1;
            // 
            // txtPassengers
            // 
            this.txtPassengers.Location = new System.Drawing.Point(94, 330);
            this.txtPassengers.Name = "txtPassengers";
            this.txtPassengers.Size = new System.Drawing.Size(100, 22);
            this.txtPassengers.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(94, 270);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 3;
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(94, 150);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(100, 22);
            this.txtAltitude.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(94, 205);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 5;
            // 
            // rbPlane
            // 
            this.rbPlane.AutoSize = true;
            this.rbPlane.Location = new System.Drawing.Point(43, 388);
            this.rbPlane.Name = "rbPlane";
            this.rbPlane.Size = new System.Drawing.Size(63, 20);
            this.rbPlane.TabIndex = 6;
            this.rbPlane.TabStop = true;
            this.rbPlane.Text = "Plane";
            this.rbPlane.UseVisualStyleBackColor = true;
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(171, 388);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(103, 20);
            this.rbCar.TabIndex = 7;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "radioButton2";
            this.rbCar.UseVisualStyleBackColor = true;
            // 
            // rbShip
            // 
            this.rbShip.AutoSize = true;
            this.rbShip.Location = new System.Drawing.Point(323, 388);
            this.rbShip.Name = "rbShip";
            this.rbShip.Size = new System.Drawing.Size(103, 20);
            this.rbShip.TabIndex = 8;
            this.rbShip.TabStop = true;
            this.rbShip.Text = "radioButton3";
            this.rbShip.UseVisualStyleBackColor = true;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(30, 415);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddVehicle.TabIndex = 9;
            this.btnAddVehicle.Text = "button1";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnShowAllInfo
            // 
            this.btnShowAllInfo.Location = new System.Drawing.Point(199, 415);
            this.btnShowAllInfo.Name = "btnShowAllInfo";
            this.btnShowAllInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllInfo.TabIndex = 10;
            this.btnShowAllInfo.Text = "button2";
            this.btnShowAllInfo.UseVisualStyleBackColor = true;
            this.btnShowAllInfo.Click += new System.EventHandler(this.btnShowAllInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAllInfo);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.rbShip);
            this.Controls.Add(this.rbCar);
            this.Controls.Add(this.rbPlane);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAltitude);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPassengers);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtPassengers;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.RadioButton rbPlane;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbShip;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnShowAllInfo;
    }
}

