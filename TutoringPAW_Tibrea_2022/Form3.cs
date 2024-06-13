using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoringPAW_Tibrea_2022
{
    public partial class Form3 : Form
    {
        List<Pacient> listaPacienti = new List<Pacient>();
        private const int margine = 10;
        bool verificaDate = false;
        public Form3(Medic m)
        {
            InitializeComponent();
            //MessageBox.Show(m.ToString());
            listaPacienti = m.ListaPacienti;
            if(listaPacienti.Count > 0 )
            {
                verificaDate = true;
                panel1.Invalidate();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (verificaDate)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + margine, 
                    panel1.ClientRectangle.Y + 4*margine, 
                    panel1.ClientRectangle.Width - 2*margine, 
                    panel1.ClientRectangle.Height - 5*margine);
                Pen pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaPacienti.Count / 3;
                double distanta = (rectangle.Width - listaPacienti.Count * latime) / (listaPacienti.Count + 1);
                double hMax = listaPacienti.Max(max => max.Tarif_consultatie);

                Rectangle[] rectangles = new Rectangle[listaPacienti.Count];
                for(int i = 0; i < listaPacienti.Count; ++i)
                {
                    rectangles[i] = new Rectangle(
                    (int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                    (int)(rectangle.Location.Y + rectangle.Height - listaPacienti[i].Tarif_consultatie / hMax * rectangle.Height),
                    (int)(latime),
                    (int)(listaPacienti[i].Tarif_consultatie / hMax * rectangle.Height));
                    g.DrawString(listaPacienti[i].Tarif_consultatie.ToString(), new Font(FontFamily.GenericSansSerif,
                        12, FontStyle.Bold), new SolidBrush(Color.Black),
                        new Point(rectangles[i].Location.X, rectangles[i].Location.Y + 12));
                }

                g.FillRectangles(new SolidBrush(Color.Red), rectangles);
            }
        }
    }
}
