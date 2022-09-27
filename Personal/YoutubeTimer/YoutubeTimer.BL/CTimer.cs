using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using YoutubeTimer.CustomExceptions;


namespace YoutubeTimer.BL
{
    public class CTimer
    {

        // Instantiate a Timer object
        private Timer _clock = new Timer();


        // Declare the variables
        private TimeSpan span;
        bool Running = false;

        //Properties.
        private DateTime starttime;
        public DateTime Starttime
        {
            get { return starttime; }

        }

        private DateTime stoptime;
        public DateTime Stoptime
        {
            get { return stoptime; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string sessiontime;

        public string SessionTime
        {
            get { return sessiontime; }
            set { sessiontime = value; }
        }

        private string elapsedtime;

        public string ElapsedTime
        {
            // Returns the elapsed time in Hours:Minutes:Seconds.
            get { return elapsedtime = span.ToString(@"hh\:mm\:ss"); }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //Methods.
        public void StartClock()
        {
            try
            {
                // Check if the timer was already started
                if (Running == false)
                {
                    // Resets the clock
                    starttime = DateTime.Now;

                    stoptime = DateTime.Now;

                    span = stoptime.Subtract(starttime);

                    // Set the properties of _clock.
                    _clock.Interval = 1000;
                    _clock.Start();
                    _clock.Elapsed += _clock_Elapsed;

                    // Start _clock.
                    _clock.Start();

                    Running = true;
                }
                else
                {
                    // Throw a custom exception.
                    throw new StartException();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Do this whenever the Timer object ticks
        void _clock_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Gets current time for the stoptime
            stoptime = DateTime.Now;

            // Calculates difference between first and second time
            span = stoptime.Subtract(starttime);

        }

        public void StopClock()
        {
            try
            {
                // Check if the timer was already started
                if (Running == true)
                {
                    // Gets current time
                    stoptime = DateTime.Now;

                    // Calculates difference between first and second time
                    span = stoptime.Subtract(starttime);

                    // Stops the Timer object
                    _clock.Stop();

                    // Sets Timer started to false
                    Running = false;
                }
                else
                {
                    // Throws a custom exception
                    throw new StopException();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
