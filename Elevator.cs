using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ElevatorSystem
{
    class Elevator
    {
        public void Elevatordown(PictureBox elevator)
        {
            PictureBox o;
            o = elevator;

            // TODO: Complete member initialization

            elevator.Location = new Point(elevator.Location.X, elevator.Location.Y + 5);
        }
        public void Elevatorup(PictureBox elevator)
        {
            PictureBox p;
            p = elevator;
            p.Location = new Point(p.Location.X, p.Location.Y - 5);
        }
    }
}
