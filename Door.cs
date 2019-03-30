using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace ElevatorSystem
{
    class Door
    {
        public void Door0open(PictureBox door0, PictureBox door00)
        {
            PictureBox l, m;
            l = door0;
            m = door00;
            l.Location = new Point(l.Location.X - 2, l.Location.Y);
            m.Location = new Point(m.Location.X + 2, m.Location.Y);
           
        }
        public void Door0close(PictureBox door0,PictureBox door00)
        {
            PictureBox l, m;
            l = door0;
            m = door00;
            l.Location = new Point(l.Location.X + 2, l.Location.Y);
            m.Location = new Point(m.Location.X - 2, m.Location.Y);
          
        }
        public void Door1open(PictureBox door1,PictureBox door11)
        {
            PictureBox o, k;
            o = door1;
            k = door11;
            // TODO: Complete member initialization

            o.Location = new Point(o.Location.X - 2, o.Location.Y);
            k.Location = new Point(k.Location.X + 2, k.Location.Y);
        }
        public void Door1close(PictureBox door1, PictureBox door11)
        {
            PictureBox o, k;
            o = door1;
            k = door11;
            // TODO: Complete member initialization

            o.Location = new Point(o.Location.X + 2, o.Location.Y);
            k.Location = new Point(k.Location.X - 2, k.Location.Y);
        }
    }
}
