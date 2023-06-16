using RavenloftClock;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace RavenloftTimer
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // To retrieve a setting
        private static readonly RTAppSettings timer_settings = new RTAppSettings();

        private const int HoursPerDay = 24;
        private const int DaysPerMonth = 28;
        private const int MonthsPerYear = 12;

        private int fakeMonth = timer_settings.Setting_Month;
        private int fakeDay = timer_settings.Setting_Day;
        private int fakeHour = timer_settings.Setting_Hour;

        private readonly NotifyIcon trayIcon;
        private readonly System.Drawing.Icon sun_icon = new System.Drawing.Icon("sun.ico");
        private readonly System.Drawing.Icon moon_icon = new System.Drawing.Icon("moon.ico");

        public Form1()
        {
            log.Error("An error occurred: ");
            try
            {
                InitializeComponent();
            } catch (Exception ex)
            {
                // Log the exception
                log.Error("An error occurred: ", ex);
            }

            trayIcon = new NotifyIcon();
            trayIcon.Icon = moon_icon;
            trayIcon.Text = Get_Text();
            trayIcon.Visible = true;
            trayIcon.MouseClick += new MouseEventHandler(TrayIcon_MouseClick);
            trayIcon.MouseDoubleClick += new MouseEventHandler(TrayIcon_MouseDoubleClick);

            label1.Text = Get_Text();

            numericUpDownHour.Enter += NumericUpDownHour_Enter;
            numericUpDownHour.Leave += NumericUpDownHour_Leave;
            numericUpDownDay.Enter += NumericUpDownDay_Enter;
            numericUpDownDay.Leave += NumericUpDownDay_Leave;
            numericUpDownMonth.Enter += NumericUpDownMonth_Enter;
            numericUpDownMonth.Leave += NumericUpDownMonth_Leave;

            // Handle the FormClosing event
            FormClosing += Form1_FormClosing;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Increment the fake time by 1 fake minute
            this.fakeHour++;

            // Check if we've reached the end of the fake day
            if (fakeHour >= HoursPerDay)
            {
                this.fakeHour = 0;
                this.fakeDay++;

                // Check if we've reached the end of the fake month
                if (this.fakeDay > DaysPerMonth)
                {
                    this.fakeDay = 1;
                    this.fakeMonth++;

                    // Check if we've reached the end of the fake year
                    if (this.fakeMonth > MonthsPerYear)
                    {
                        this.fakeMonth = 1;
                    }
                }
            }

            // Update the label on the form with the current fake date and time
            Update_Text();
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // Show form to set fake time
            this.Show();
        }


        private void TrayIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            // Show form to set fake time
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want the timer to stay open in the systray?", "Minimised", MessageBoxButtons.YesNoCancel);

            if (dg == DialogResult.Yes)
            {
                // Prevent form from closing, just hide it instead
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    // Minimize the form instead of closing it
                    e.Cancel = true;
                    WindowState = FormWindowState.Minimized;
                    Hide();
                }
            }
            else if (dg == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Show the form when double-clicking the system tray icon
            if (e.Button == MouseButtons.Left)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private string Get_Text()
        {
            return $"Hour: {this.fakeHour:00}\nDay: {this.fakeDay}\nMonth: {this.fakeMonth}";
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Set_Time();
            this.timer1.Stop();
            this.timer1.Start();
        }

        private void NumericUpDownHour_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Set_Hour();
            }
        }

        private void NumericUpDownDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Set_Day();
            }
        }

        private void NumericUpDownMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Set_Month();
            }
        }

        private void NumericUpDownHour_Enter(object sender, EventArgs e)
        {
            numericUpDownHour.Select(0, numericUpDownHour.Value.ToString().Length);
        }

        private void NumericUpDownHour_Leave(object sender, EventArgs e)
        {
            numericUpDownHour.Select(0, 0);
        }
        private void NumericUpDownDay_Enter(object sender, EventArgs e)
        {
            numericUpDownDay.Select(0, numericUpDownDay.Value.ToString().Length);
        }

        private void NumericUpDownDay_Leave(object sender, EventArgs e)
        {
            numericUpDownDay.Select(0, 0);
        }
        private void NumericUpDownMonth_Enter(object sender, EventArgs e)
        {
            numericUpDownMonth.Select(0, numericUpDownMonth.Value.ToString().Length);
        }

        private void NumericUpDownMonth_Leave(object sender, EventArgs e)
        {
            numericUpDownMonth.Select(0, 0);
        }

        private void Set_Hour()
        {
            fakeHour = (int)this.numericUpDownHour.Value;
            Update_Text();
        }

        private void Set_Day()
        {
            fakeDay = (int)this.numericUpDownDay.Value;
            Update_Text();
        }

        private void Set_Month()
        {
            fakeMonth = (int)this.numericUpDownMonth.Value;
            Update_Text();
        }

        private void Set_Time()
        {
            fakeHour = (int)this.numericUpDownHour.Value;
            fakeDay = (int)this.numericUpDownDay.Value;
            fakeMonth = (int)this.numericUpDownMonth.Value;
            Update_Text();
        }

        private void Update_Text()
        {
            if (fakeHour >= 18 || fakeHour <= 6)
            {
                Set_Moon_Icon();
            }
            else {
                Set_Sun_Icon();
            }

            label1.Text = Get_Text();
            trayIcon.Text = label1.Text;
        }

        private void Set_Sun_Icon()
        {
            trayIcon.Icon = sun_icon;
        }
        private void Set_Moon_Icon()
        {
            trayIcon.Icon = moon_icon;
        }

    }
}
