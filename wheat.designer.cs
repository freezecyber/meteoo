namespace Weather
{
    partial class wheat
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
            this.lblDt = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.lblPresure = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Location = new System.Drawing.Point(91, 80);
            this.lblDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(46, 17);
            this.lblDt.TabIndex = 0;
            this.lblDt.Text = "label1";
            this.lblDt.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(157, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(16, 31);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(132, 22);
            this.tbCity.TabIndex = 2;
            this.tbCity.Text = "saguenay";
            // 
            // pbWeather
            // 
            this.pbWeather.Location = new System.Drawing.Point(16, 80);
            this.pbWeather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(67, 62);
            this.pbWeather.TabIndex = 10;
            this.pbWeather.TabStop = false;
            // 
            // lblPresure
            // 
            this.lblPresure.AutoSize = true;
            this.lblPresure.Location = new System.Drawing.Point(16, 247);
            this.lblPresure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresure.Name = "lblPresure";
            this.lblPresure.Size = new System.Drawing.Size(46, 17);
            this.lblPresure.TabIndex = 11;
            this.lblPresure.Text = "label1";
            this.lblPresure.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 164);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "label1";
            this.lblName.Visible = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(16, 191);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(46, 17);
            this.lblTemp.TabIndex = 13;
            this.lblTemp.Text = "label1";
            this.lblTemp.Visible = false;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(16, 219);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(46, 17);
            this.lblHumidity.TabIndex = 14;
            this.lblHumidity.Text = "label1";
            this.lblHumidity.Visible = false;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(16, 276);
            this.lblWindSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(46, 17);
            this.lblWindSpeed.TabIndex = 15;
            this.lblWindSpeed.Text = "label1";
            this.lblWindSpeed.Visible = false;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(91, 113);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(46, 17);
            this.lblDes.TabIndex = 16;
            this.lblDes.Text = "label1";
            this.lblDes.Visible = false;
            // 
            // wheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.ClientSize = new System.Drawing.Size(276, 305);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPresure);
            this.Controls.Add(this.pbWeather);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "wheat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Времето";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.wheat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.PictureBox pbWeather;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Label lblPresure;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.Label lblHumidity;
        public System.Windows.Forms.Label lblWindSpeed;
        public System.Windows.Forms.Label lblDes;
    }
}

