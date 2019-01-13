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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap[,] bmps = new Bitmap[0,0];
            pictureBox1.Image = bmps[0, 0];
            Image img1 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\one");
            Image img2 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\two");
            Image img3 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\three");
            Image img4 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\four");
            Image img5 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\five");
            Image img6 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\six");
            Image img7 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\seven");
            Image img8 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\eight");
            Image img9 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\nine");
            Image img10 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\ten");
            Image img11 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\eleven");
            Image img12 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\twelve");
            Image img13 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\thirteen");
            Image img14 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\fourteen");
            Image img15 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\fifteen");
            Image img16 = Image.FromFile(@"C: \Users\Pradeep Velavali\Desktop\images\sixteen");

            int width = img1.Width + img2.Width + img3.Width + img4.Width + img5.Width + img6.Width + img7.Width + img8.Width + img9.Width + img10.Width + img11.Width + img12.Width + img13.Width + img14.Width + img15.Width + img16.Width;
            int height = (img1.Height + img2.Height + img3.Height + img4.Height + img5.Height + img6.Height + img7.Height + img8.Height + img9.Height + img10.Height + img11.Height + img12.Height + img13.Height + img14.Height + img15.Height + img16.Height);

            Bitmap img = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img);

            img.Save(@"C:\Users\Pradeep Velavali\Desktop\images\main", ImageFormat.Jpeg);
            
        }
    }
}
