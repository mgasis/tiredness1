using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulatorInterface;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //initial all the arrows pointers back to null before each round
        private void initializing() {
            this.picArrow0.Image = null;
            this.picArrow1.Image = null;
            this.picArrow2.Image = null;
            this.picArrow3.Image = null;
            this.picArrow4.Image = null;
            this.picArrow5.Image = null;
            this.picArrow6.Image = null;
            this.picArrow7.Image = null;
            this.picArrow8.Image = null;
            this.picArrow9.Image = null;
            this.picArrow10.Image = null;
        }

        private void start_Click(object sender, EventArgs e)
        {

            /*
             //* Using SimConnect - intial tiredness veraible with the data inside the path

            SimConnect sc = new SimConnect();
            double tiredness = sc.getUser(1);
            */
            

            
            //*Test me - test the interface with random number between 0 to 1
            Random r = new Random();
            int value = new int();
            value = r.Next(0, 10);
            double tiredness = (double)value / 10;
            


            this.initializing();


            if (tiredness == 0.0)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow0.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.1)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow1.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.2)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow2.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.3)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow3.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.4)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow4.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.5)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow5.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.6)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow6.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.7)
            {
                resultpic.Image = picSafeDrive.Image;
                start.Text = "NO";
                this.picArrow7.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.8)
            {
                resultpic.Image = picCoffe.Image;
                start.Text = "YES";
                this.picArrow8.Image = this.picArrow.Image;
            }
            else if (tiredness == 0.9)
            {
                resultpic.Image = picCoffe.Image;
                start.Text = "YES";
                this.picArrow9.Image = this.picArrow.Image;
            }
            else
            {
                resultpic.Image = picCoffe.Image;
                start.Text = "YES";
                this.picArrow10.Image = this.picArrow.Image;
            }

            }

       
    }
}
