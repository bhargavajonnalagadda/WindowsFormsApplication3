using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// loading the text box with sample from the email problem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Driver Dan");
            sb.Append(Environment.NewLine);

            sb.Append("Driver Lauren ");
            sb.Append(Environment.NewLine);

            sb.Append("Driver Kumi");
            sb.Append(Environment.NewLine);

            sb.Append("Trip Dan 07:15 07:45 17.3 ");
            sb.Append(Environment.NewLine);

            sb.Append("Trip Dan 06:12 06:32 21.8 ");
            sb.Append(Environment.NewLine);

            sb.Append("Trip Lauren 12:01 13:16 42 ");
            sb.Append(Environment.NewLine);
            textBox1.Text = sb.ToString();
        }

        //button click event to process commands
        private void button1_Click(object sender, EventArgs e)
        {
            string[] commands = textBox1.Text.TrimEnd().Split(new string[] { "\r\n" }, StringSplitOptions.None);

            UtilObjectCreator.createObject(commands);
           

            //now calculate trip
            List<String> report = new List<string>();
            report = UtilObjectCreator.calculateandComputeTripReport();
            
            StringBuilder result = new StringBuilder();
            foreach (string s in report)
            {
                result.Append(s);
                result.Append(Environment.NewLine);


            }

            textBox1.Text = result.ToString();
        }

        
    }
}
