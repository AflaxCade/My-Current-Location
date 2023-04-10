namespace Current_Location
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
            this.btnGetLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.lat = new System.Windows.Forms.Label();
            this.lon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetLocation
            // 
            this.btnGetLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetLocation.AutoSize = true;
            this.btnGetLocation.BackColor = System.Drawing.Color.Crimson;
            this.btnGetLocation.FlatAppearance.BorderSize = 0;
            this.btnGetLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetLocation.ForeColor = System.Drawing.Color.White;
            this.btnGetLocation.Location = new System.Drawing.Point(426, 513);
            this.btnGetLocation.Name = "btnGetLocation";
            this.btnGetLocation.Size = new System.Drawing.Size(206, 59);
            this.btnGetLocation.TabIndex = 0;
            this.btnGetLocation.Text = "Get Location";
            this.btnGetLocation.UseVisualStyleBackColor = false;
            this.btnGetLocation.Click += new System.EventHandler(this.btnGetLocation_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Current Location is:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // location
            // 
            this.location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.location.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(264, 217);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(531, 56);
            this.location.TabIndex = 2;
            this.location.Text = "City, Country";
            this.location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lat
            // 
            this.lat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat.Location = new System.Drawing.Point(355, 323);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(349, 37);
            this.lat.TabIndex = 3;
            this.lat.Text = "Latitude: 0.0";
            this.lat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lon
            // 
            this.lon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lon.Location = new System.Drawing.Point(355, 374);
            this.lon.Name = "lon";
            this.lon.Size = new System.Drawing.Size(349, 37);
            this.lon.TabIndex = 4;
            this.lon.Text = "Longitude: 0.0";
            this.lon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 644);
            this.Controls.Add(this.lon);
            this.Controls.Add(this.lat);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetLocation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatoin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label lat;
        private System.Windows.Forms.Label lon;
    }
}

