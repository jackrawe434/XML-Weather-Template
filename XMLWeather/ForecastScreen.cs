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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public static int forecastWeatherVal = Convert.ToInt16(Form1.days[0].forecastCondition);

        public void displayForecast()
        {
            //Taking information and displaying each day's respictive temps
            date1.Text = Form1.days[1].date;
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.0");
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.0");
            date2.Text = Form1.days[2].date;
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.0");
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.0");
            date3.Text = Form1.days[3].date;
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.0");
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.0");
            date4.Text = Form1.days[4].date;
            min4.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("0.0");
            max4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("0.0");


            //Day 1 images
            if (forecastWeatherVal >= 200 && forecastWeatherVal <= 232)
            {
                day1Image.BackgroundImage = Properties.Resources.Thunderstorm;
            }
            if (forecastWeatherVal >= 300 && forecastWeatherVal <= 321)
            {
                day1Image.BackgroundImage = Properties.Resources.drizzle;
            }
            if (forecastWeatherVal >= 500 && forecastWeatherVal <= 531)
            {
                day1Image.BackgroundImage = Properties.Resources.rain;
            }
            if (forecastWeatherVal >= 600 && forecastWeatherVal <= 622)
            {
                day1Image.Image = Properties.Resources.snow;
            }
            if (forecastWeatherVal >= 700 && forecastWeatherVal <= 781)
            {
                day1Image.Image = Properties.Resources.atmosphere;
            }
            if (forecastWeatherVal == 800)
            {
                day1Image.Image = Properties.Resources.clear;
            }
            if (forecastWeatherVal >= 801 && forecastWeatherVal <= 804)
            {
                day1Image.Image = Properties.Resources.cloudy;
            }

            //Day 2 images
            if (forecastWeatherVal >= 200 && forecastWeatherVal <= 232)
            {
                day2Image.BackgroundImage = Properties.Resources.Thunderstorm;
            }
            if (forecastWeatherVal >= 300 && forecastWeatherVal <= 321)
            {
                day2Image.BackgroundImage = Properties.Resources.drizzle;
            }
            if (forecastWeatherVal >= 500 && forecastWeatherVal <= 531)
            {
                day2Image.BackgroundImage = Properties.Resources.rain;
            }
            if (forecastWeatherVal >= 600 && forecastWeatherVal <= 622)
            {
                day2Image.Image = Properties.Resources.snow;
            }
            if (forecastWeatherVal >= 700 && forecastWeatherVal <= 781)
            {
                day2Image.Image = Properties.Resources.atmosphere;
            }
            if (forecastWeatherVal == 800)
            {
                day2Image.Image = Properties.Resources.clear;
            }
            if (forecastWeatherVal >= 801 && forecastWeatherVal <= 804)
            {
                day2Image.Image = Properties.Resources.cloudy;
            }

            //Day 3 images
            if (forecastWeatherVal >= 200 && forecastWeatherVal <= 232)
            {
                day3Image.BackgroundImage = Properties.Resources.Thunderstorm;
            }
            if (forecastWeatherVal >= 300 && forecastWeatherVal <= 321)
            {
                day3Image.BackgroundImage = Properties.Resources.drizzle;
            }
            if (forecastWeatherVal >= 500 && forecastWeatherVal <= 531)
            {
                day3Image.BackgroundImage = Properties.Resources.rain;
            }
            if (forecastWeatherVal >= 600 && forecastWeatherVal <= 622)
            {
                day3Image.Image = Properties.Resources.snow;
            }
            if (forecastWeatherVal >= 700 && forecastWeatherVal <= 781)
            {
                day3Image.Image = Properties.Resources.atmosphere;
            }
            if (forecastWeatherVal == 800)
            {
                day3Image.Image = Properties.Resources.clear;
            }
            if (forecastWeatherVal >= 801 && forecastWeatherVal <= 804)
            {
                day3Image.Image = Properties.Resources.cloudy;
            }

            //Day 4 images
            if (forecastWeatherVal >= 200 && forecastWeatherVal <= 232)
            {
                day4Image.BackgroundImage = Properties.Resources.Thunderstorm;
            }
            if (forecastWeatherVal >= 300 && forecastWeatherVal <= 321)
            {
                day4Image.BackgroundImage = Properties.Resources.drizzle;
            }
            if (forecastWeatherVal >= 500 && forecastWeatherVal <= 531)
            {
                day4Image.BackgroundImage = Properties.Resources.rain;
            }
            if (forecastWeatherVal >= 600 && forecastWeatherVal <= 622)
            {
                day4Image.Image = Properties.Resources.snow;
            }
            if (forecastWeatherVal >= 700 && forecastWeatherVal <= 781)
            {
                day4Image.Image = Properties.Resources.atmosphere;
            }
            if (forecastWeatherVal == 800)
            {
                day4Image.Image = Properties.Resources.clear;
            }
            if (forecastWeatherVal >= 801 && forecastWeatherVal <= 804)
            {
                day4Image.Image = Properties.Resources.cloudy;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //switching screens method
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
