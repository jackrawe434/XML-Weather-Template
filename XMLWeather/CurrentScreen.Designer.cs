namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minOutputNight = new System.Windows.Forms.Label();
            this.maxOutputNight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dayTemp = new System.Windows.Forms.Label();
            this.nightTemp = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.currentImage = new System.Windows.Forms.PictureBox();
            this.dayBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNight = new System.Windows.Forms.PictureBox();
            this.pictureBoxDay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay)).BeginInit();
            this.SuspendLayout();
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(371, 102);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(474, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(462, 37);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(63, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(187, 13);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(152, 33);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "Stratford";
            // 
            // tempLabel
            // 
            this.tempLabel.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(166, 58);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(208, 110);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "0.0";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.Red;
            this.maxOutput.Location = new System.Drawing.Point(354, 130);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(59, 48);
            this.maxOutput.TabIndex = 45;
            this.maxOutput.Text = "0.0";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.DarkCyan;
            this.minOutput.Location = new System.Drawing.Point(354, 76);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(59, 48);
            this.minOutput.TabIndex = 44;
            this.minOutput.Text = "0.0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 47;
            this.label1.Text = "Night";
            // 
            // minOutputNight
            // 
            this.minOutputNight.BackColor = System.Drawing.Color.Transparent;
            this.minOutputNight.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutputNight.ForeColor = System.Drawing.Color.Red;
            this.minOutputNight.Location = new System.Drawing.Point(65, 340);
            this.minOutputNight.Name = "minOutputNight";
            this.minOutputNight.Size = new System.Drawing.Size(50, 27);
            this.minOutputNight.TabIndex = 50;
            this.minOutputNight.Text = "0.0";
            // 
            // maxOutputNight
            // 
            this.maxOutputNight.BackColor = System.Drawing.Color.Transparent;
            this.maxOutputNight.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutputNight.ForeColor = System.Drawing.Color.LimeGreen;
            this.maxOutputNight.Location = new System.Drawing.Point(144, 340);
            this.maxOutputNight.Name = "maxOutputNight";
            this.maxOutputNight.Size = new System.Drawing.Size(50, 27);
            this.maxOutputNight.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 33);
            this.label2.TabIndex = 54;
            this.label2.Text = "Day";
            // 
            // dayTemp
            // 
            this.dayTemp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dayTemp.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTemp.ForeColor = System.Drawing.Color.White;
            this.dayTemp.Location = new System.Drawing.Point(51, 273);
            this.dayTemp.Name = "dayTemp";
            this.dayTemp.Size = new System.Drawing.Size(160, 83);
            this.dayTemp.TabIndex = 55;
            this.dayTemp.Text = "0.0";
            this.dayTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nightTemp
            // 
            this.nightTemp.BackColor = System.Drawing.Color.MidnightBlue;
            this.nightTemp.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightTemp.ForeColor = System.Drawing.Color.White;
            this.nightTemp.Location = new System.Drawing.Point(331, 273);
            this.nightTemp.Name = "nightTemp";
            this.nightTemp.Size = new System.Drawing.Size(146, 71);
            this.nightTemp.TabIndex = 56;
            this.nightTemp.Text = "0.0";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(7, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(152, 33);
            this.dateLabel.TabIndex = 57;
            this.dateLabel.Text = "Stratford";
            // 
            // currentImage
            // 
            this.currentImage.Location = new System.Drawing.Point(56, 76);
            this.currentImage.Name = "currentImage";
            this.currentImage.Size = new System.Drawing.Size(102, 92);
            this.currentImage.TabIndex = 58;
            this.currentImage.TabStop = false;
            // 
            // dayBox
            // 
            this.dayBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dayBox.Location = new System.Drawing.Point(0, 208);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(260, 192);
            this.dayBox.TabIndex = 53;
            this.dayBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(256, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 192);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxNight
            // 
            this.pictureBoxNight.Location = new System.Drawing.Point(362, 261);
            this.pictureBoxNight.Name = "pictureBoxNight";
            this.pictureBoxNight.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxNight.TabIndex = 49;
            this.pictureBoxNight.TabStop = false;
            // 
            // pictureBoxDay
            // 
            this.pictureBoxDay.Location = new System.Drawing.Point(86, 261);
            this.pictureBoxDay.Name = "pictureBoxDay";
            this.pictureBoxDay.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxDay.TabIndex = 46;
            this.pictureBoxDay.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.currentImage);
            this.Controls.Add(this.dayTemp);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nightTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maxOutputNight);
            this.Controls.Add(this.minOutputNight);
            this.Controls.Add(this.pictureBoxNight);
            this.Controls.Add(this.pictureBoxDay);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(525, 400);
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.PictureBox pictureBoxDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNight;
        private System.Windows.Forms.Label minOutputNight;
        private System.Windows.Forms.Label maxOutputNight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dayTemp;
        private System.Windows.Forms.Label nightTemp;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox currentImage;
    }
}
