using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RippleButton
{
   
    public class RippleBtn:Button
    {
        private Point clickPoint = new Point();
        private Timer timer;
        private int radius = 0;
        private int ind = 0;

        private List<points> pList = new List<points>();

        private enum colors
        {
            //Red,
            //Blue,
            white
        }
        public RippleBtn() { }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            //clickPoint.X = e.X;
            //clickPoint.Y = e.Y;

            points p = new points();
            p.x = e.X;
            p.y = e.Y;
            p.rad = 0;

            pList.Add(p);

            if(timer==null||!timer.Enabled)
            {
                timer = new Timer();
                timer.Interval = 10;
                timer.Tick += TimerTick;
                timer.Start();
            }

            Invalidate();

        }
        

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            Brush b =null;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            foreach (points cp in pList)
            {
                
                b = new SolidBrush(Color.FromArgb(20, Color.FromName(((colors)(ind % 3)).ToString())));
                g.FillEllipse(b, cp.x - cp.rad, cp.y - cp.rad, 2 * cp.rad, 2 * cp.rad);

                if(cp.rad<Width)
                {
                    cp.rad += 8;
                }
                else
                {
                    //pList.RemoveAt(0);
                }


                
                
            }
            string txt = "Click";
            g.DrawString(txt, new Font("Arial", 16), new SolidBrush(Color.White), (Width/2)-(txt.Length*6) , (Height / 3) );
            if (b!=null) b.Dispose();
            
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (pList[0].rad >= Width)
            {
                pList.RemoveAt(0);
                //ind++;

            }
            if (pList.Count == 0)
            {
                //if (pList.rad >= Width)
                //{
                //    ///pList = null;
                //    timer.Stop();
                //}
                timer.Stop();
            }
            //else
            //{
            //    timer.Stop();
            //    ind++;
            //    pList.RemoveAt(0);

            //}
            Invalidate();
        }
    }


}
