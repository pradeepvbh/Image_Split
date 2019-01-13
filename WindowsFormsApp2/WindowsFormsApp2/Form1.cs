using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"G:\vs\WindowsFormsApp2\WindowsFormsApp2\Images\images.jpg"); // a.png has 312X312 width and height
            int widthThird = (int)((double)img.Width / 4.0 + 1.0);
            int heightThird = (int)((double)img.Height / 4.0 + 1.0);
            Bitmap[,] bmps = new Bitmap[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    bmps[i, j] = new Bitmap(widthThird, heightThird);
                    Graphics g = Graphics.FromImage(bmps[i, j]);
                    g.DrawImage(img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, i * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);
                    g.Dispose();
                }
            pictureBox1.Image = bmps[0, 0];
            pictureBox2.Image = bmps[0, 1];
            pictureBox3.Image = bmps[0, 2];
            pictureBox4.Image = bmps[0, 3];
            pictureBox5.Image = bmps[1, 0];
            pictureBox6.Image = bmps[1, 1];
            pictureBox7.Image = bmps[1, 2];
            pictureBox8.Image = bmps[1, 3];
            pictureBox9.Image = bmps[2, 0];
            pictureBox10.Image = bmps[2, 1];
            pictureBox11.Image = bmps[2, 2];
            pictureBox12.Image = bmps[2, 3];
            pictureBox13.Image = bmps[3, 0];
            pictureBox14.Image = bmps[3, 1];
            pictureBox15.Image = bmps[3, 2];
            pictureBox16.Image = bmps[3, 3];


            pictureBox1.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\one.jpeg", ImageFormat.Jpeg);
            pictureBox2.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\two.jpeg", ImageFormat.Jpeg);
            pictureBox3.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\three.jpeg", ImageFormat.Jpeg);
            pictureBox4.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\four.jpeg", ImageFormat.Jpeg);
            pictureBox5.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\five.jpeg", ImageFormat.Jpeg);
            pictureBox6.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\six.jpeg", ImageFormat.Jpeg);
            pictureBox7.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\seven.jpeg", ImageFormat.Jpeg);
            pictureBox8.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\eight.jpeg", ImageFormat.Jpeg);
            pictureBox9.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\nine.jpeg", ImageFormat.Jpeg);
            pictureBox10.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\ten.jpeg", ImageFormat.Jpeg);
            pictureBox11.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\eleven.jpeg", ImageFormat.Jpeg);
            pictureBox12.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\twelve.jpeg", ImageFormat.Jpeg);
            pictureBox13.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\thirteen.jpeg", ImageFormat.Jpeg);
            pictureBox14.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\fourteen.jpeg", ImageFormat.Jpeg);
            pictureBox15.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\fifteen.jpeg", ImageFormat.Jpeg);
            pictureBox16.Image.Save(@"C:\Users\Pradeep Velavali\Desktop\images\sixteen.jpeg", ImageFormat.Jpeg);

        }
    }
}
