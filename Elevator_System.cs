using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    
    public partial class Elevator_System : Form
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int f = 0;
        int g = 0;
        int h = 0;
        int i = 0;
        public Elevator_System()
        {
         
            InitializeComponent();
            if (elevator.Location.Y >= 150)
            {
                lblfloor.Text = "0";
                lbl1.Text = "0";
                lbl2.Text = "0";
            }
            if (elevator.Location.Y < 150)
            {
                lblfloor.Text = "1";
                lbl1.Text = "1";
                lbl2.Text = "1";
            }
            
        }

        private void Elevator_System_Load(object sender, EventArgs e)
        {
            GlobalConnection.DbConnection();
            LoadData();
            

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btn0.BackColor = Color.Red;
            if (timer6.Enabled == true || timer7.Enabled == true || timer8.Enabled == true)
            {
                btn1.BackColor = Color.Silver;
            }
            if (elevator.Location.Y <= 12 && door1.Location.X >= 0)
            {
                timer1.Enabled = true;
            }
            if (elevator.Location.Y >= 425 && door0.Location.X <= 155)
            {
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            d = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            if (door1.Location.X >= 0 && door0.Location.X >= 0)
            {
                Elevator el = new Elevator();
                el.Elevatordown(elevator);
                
              //   elevator.Location = new Point(elevator.Location.X, elevator.Location.Y + 5);
            }


            if (elevator.Location.Y >= 425 && door0.Location.X >= 0)
            {
                c++;
                if (c==1)
                {
                    try
                    {
                        Database dc = new Database();
                        dc.elevatordown(DateTime.Now, "Elevator Down","0");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), " Error");
                    }
                    LoadData();
                }

               
                timer2.Enabled = true;
            }
            if (elevator.Location.Y >= 150)
            {
                lblfloor.Text = "0";
                lbl1.Text = "0";
                lbl2.Text = "0";
            }
            if (elevator.Location.Y < 150)
            {
                lblfloor.Text = "1";
                lbl1.Text = "1";
                lbl2.Text = "1";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            c = 0;
          
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            btn0.BackColor = Color.Silver;
            down.BackColor = Color.Silver;
            timer1.Enabled = false;
            btnclose.Enabled = false;
            if (elevator.Location.Y >= 425 && door0.Location.X >= -65)
            {
                Door lm = new Door();
                lm.Door0open(door0, door00);

                  //   door0.Location=new Point(door0.Location.X-2,door0.Location.Y);
                  //   door00.Location = new Point(door00.Location.X + 2, door00.Location.Y);

            }
            if (door0.Location.X <= -65 && elevator.Location.Y >= 425)
            {
                d++;
                if (d == 15)
                {
                    try
                    {
                        Database dc = new Database();
                        dc.elevatordown(DateTime.Now, "Down door open","0");
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), " Error");
                    }
                    btnclose.Enabled = true;
                    LoadData();
                }
                a = 0;
                
                timer3.Enabled = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Red;
            if (timer2.Enabled == true || timer3.Enabled == true || timer4.Enabled == true)
            {
                btn0.BackColor = Color.Silver;
            }
            if (elevator.Location.Y >= 425 && door0.Location.X >= 0)
            {
                timer5.Enabled = true;
            }
            if (elevator.Location.Y <= 12 && door1.Location.X >= 0)
            {
                timer6.Enabled = true;
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            up.BackColor = Color.Red;
            if (elevator.Location.Y >= 420 && door0.Location.X >=-65)
            {
                timer5.Enabled = true;
            }
            if (elevator.Location.Y <= 12 && door1.Location.X >= -65)
            {

                timer6.Enabled = true;
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            down.BackColor = Color.Red;
            if (elevator.Location.Y <= 12 && door1.Location.X >= -65)
            {
                timer1.Enabled = true;
            }
            if (elevator.Location.Y >= 425 && door0.Location.X >= -65)
            {

                timer2.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            btnclose.Enabled = true;
            timer2.Enabled = false;
            down.BackColor = Color.Silver;
            btn0.BackColor = Color.Silver;
            if (a <= 10)
            {
                a++;
            }
            else
            {
                timer4.Enabled = true;
            }
            btn0.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            c = 0;
            d = 0;
          
            g = 0;
            h = 0;
            i = 0;
            timer3.Enabled = false;
            down.BackColor = Color.Silver;
            btn0.BackColor = Color.Silver;
            btnopen.Enabled = false;
            if (elevator.Location.Y >= 425 && door0.Location.X <= 0)
            {
               
                Door cl = new Door();
                cl.Door0close(door0, door00);
               //  door0.Location = new Point(door0.Location.X + 2, door0.Location.Y);
               //  door00.Location = new Point(door00.Location.X - 2, door00.Location.Y);

            }
            if (btn1.BackColor == Color.Red && elevator.Location.Y >= 425 && door0.Location.X >= -65)
            {
                btn1.PerformClick();
            }
            if (up.BackColor == Color.Red && elevator.Location.Y >= 425 && door0.Location.X >= -65)
            {
                up.PerformClick();
            }
            if (door0.Location.X >= 0 && elevator.Location.Y>=425)
            {
                f++;
                c = 0;
                d = 0;
           
                g = 0;
                h = 0;
                i = 0;

                if (f == 1)
                {
                    try
                    {
                        Database dc = new Database();
                        dc.elevatordown(DateTime.Now, "down door close","0");
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                        btnopen.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), " Error");
                    }
                    LoadData();
                }
                timer4.Enabled = false;
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            if (elevator.Location.Y >= 425 && door0.Location.X >= -65)
            {
                timer2.Enabled = true;
            }
            if (elevator.Location.Y <= 12 && door1.Location.X >= -65)
            {
                timer6.Enabled = true;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            
            
            
            a = 10;
            b = 10;
            if (elevator.Location.Y >= 425 && door0.Location.X <=-65)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
            if (elevator.Location.Y <= 3 && door1.Location.X <=-65)
            {
                timer7.Enabled = false;
                timer8.Enabled = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            c = 0;
            d = 0;
            f = 0;
           
            h = 0;
            i = 0;
            
            timer5.Enabled = false;
            
            up.BackColor = Color.Silver;
            btn1.BackColor = Color.Silver;
            if (elevator.Location.Y <= 10 && door1.Location.X >= -65)
            {

                btnclose.Enabled = false;
                Door dl = new Door();
                dl.Door1open(door1, door11);

               //    door1.Location = new Point(door1.Location.X - 2, door1.Location.Y);
               //    door11.Location = new Point(door11.Location.X + 2, door11.Location.Y);
            }
            if (door1.Location.X <= -65 && elevator.Location.Y<=3)
            {
                
                g++;
                if (g == 15)
                {
                    try
                    {
                        Database dc = new Database();
                        dc.elevatordown(DateTime.Now, "Up door open","1");
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), " Error");
                    }
                    
                    LoadData();
                }
                b = 0;
                timer7.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            c = 0;
            d = 0;
            f = 0;
            g = 0;
           
            i = 0;
            if (door1.Location.X >= 0 && door0.Location.X >= 0)
            {
                
                Elevator hl = new Elevator();
                hl.Elevatorup(elevator);
               // elevator.Location= new Point(elevator.Location.X, elevator.Location.Y - 5);
            }
            if (elevator.Location.Y <=3 && door1.Location.X >= 0)
            {
                h++;
                if (h == 1)
                {
                    try
                    {
                        Database dc = new Database();
                        dc.elevatordown(DateTime.Now, "Elevator Up","1");
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), " Error");
                    }
                    LoadData();
                }
                timer6.Enabled = true;
            }
            if (elevator.Location.Y >= 150)
            {
                lblfloor.Text = "0";
                lbl1.Text = "0";
                lbl2.Text = "0";
            }
            if (elevator.Location.Y < 150)
            {
                lblfloor.Text = "1";
                lbl1.Text = "1";
                lbl2.Text = "1";
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
           
            timer6.Enabled = false;
            up.BackColor = Color.Silver;
            btn1.BackColor = Color.Silver;
            if (b <= 10)
            {
                b++;
            }
            else
            {
                timer8.Enabled = true;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            c = 0;
            d = 0;
            f = 0;
            g = 0;
            h = 0;
            btnopen.Enabled = false;
            timer7.Enabled = false;
            up.BackColor = Color.Silver;
            btn1.BackColor = Color.Silver;
            if (elevator.Location.Y <= 3 && door1.Location.X <= 0)
            {
               
                Door pl = new Door();
                pl.Door1close(door1, door11);
               //   door1.Location = new Point(door1.Location.X + 2, door1.Location.Y);
               //   door11.Location = new Point(door11.Location.X - 2, door11.Location.Y);

            }
            if (btn0.BackColor == Color.Red && elevator.Location.Y <= 3 && door1.Location.X >= 0)
            {
                btn0.PerformClick();
            }
            if (down.BackColor == Color.Red && elevator.Location.Y <= 3 && door1.Location.X >= 0)
            {
                down.PerformClick();
            }
            if (door1.Location.X >= 0 && elevator.Location.Y<=3)
            {
                i++;
                if (i == 1)
                {
                    try
                    {
                        Database dc = new Database();
                        dc.elevatordown(DateTime.Now, "Up door close","1");
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                       
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), " Error");
                    }
                    LoadData();
                }
                btnopen.Enabled = true;
                timer8.Enabled = false;
            }
        }

        private void door00_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                btn0.Enabled = true;
                btnclose.Enabled = true;
                Database s = new Database();
                DataTable dt = s.View();
                dataGridView1.DataSource = dt;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR!!");
            }

        
      

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Controlpanel_Click(object sender, EventArgs e)
        {

        }

    }
}
