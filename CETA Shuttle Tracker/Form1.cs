﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CETA_Shuttle_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            //Makes the main screen visable and loads time and date and initializes a variable in settings
            MainScreen.Visible = true;
            label4.Text = "1";
            Timer();
            

        }
        //Takes syetem date and time displays it to text
        public void Timer()
        {
           DateTimer.Start();
           label12.Text = DateTime.Now.ToLongDateString();
           TimeText.Text = DateTime.Now.ToLongTimeString();
            //DataReciever();
        }

        //Starts the splash Screen
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        // TODO
        ///Public void DataReciever()
        ///{
        /// the application will recieve data from GPS trasmitter
        /// the main application will create a maps overlay and start tracking the shuttle
        /// 
        ///}

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the application
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();// Exits the application
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Makes setting screen visible and main screen invisible
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            MainScreen.Visible = false;
        }

        //makes Settings screen invisible and main screen visible
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            MainScreen.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Gets value from scroll bar and displays it
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        //changes time every second
        private void DateTimer_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongDateString();
            TimeText.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
