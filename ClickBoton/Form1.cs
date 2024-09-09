namespace ClickBoton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible ==  true ) 
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible=true;
                pictureBox4.Visible = false;
                pictureBox5.Visible=false;
               
            
            }
             else if(pictureBox3.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                     

                    }
            else if (pictureBox4.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                

            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
             

            }

        }
    }
}