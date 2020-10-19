using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();

            dateLabel.Text = DateTime.Now.ToString();

            DisplayCurrent();


        }

        public static int weatherVal = Convert.ToInt16(Form1.days[0].condition);

        public void DisplayCurrent()
        {
            //Displaying all information on current forecast
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0");
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.0");
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.0");
            dayTemp.Text = Convert.ToDouble(Form1.days[0].dayTemp).ToString("0.0");
            nightTemp.Text = Convert.ToDouble(Form1.days[0].nightTemp).ToString("0.0");
           
            //Day 0 images 
            if(weatherVal >= 200 && weatherVal <= 232)
            {
                currentImage.BackgroundImage = Properties.Resources.Thunderstorm;
            }
            if (weatherVal >= 300 && weatherVal <= 321)
            {
                currentImage.BackgroundImage = Properties.Resources.drizzle;
            }
            if (weatherVal >= 500 && weatherVal <= 531)
            {
                currentImage.BackgroundImage = Properties.Resources.rain;
            }
            if (weatherVal >= 600 && weatherVal <= 622)
            {
                currentImage.Image = Properties.Resources.snow;
            }
            if (weatherVal >= 700 && weatherVal <= 781)
            {
                currentImage.Image = Properties.Resources.atmosphere;
            }
            if (weatherVal == 800)
            {
                currentImage.Image = Properties.Resources.clear;
            }
            if (weatherVal >= 801 && weatherVal <= 804)
            {
                currentImage.Image = Properties.Resources.cloudy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //switching screens method
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }


    }
}
