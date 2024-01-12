using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exam10
{
    public partial class Form1 : Form
    {
        //private Image originalImage2;
        private string n;
        private Image resizedImage;
        private Image resizedImage1;
        private Image resizedImage2;
        private bool IsRI = false;
        private bool ISH = false;
        public Form1()
        {
            InitializeComponent();

            Image originalImage = Image.FromFile("D:\\C#\\android_app\\Exam10\\gr_c.png");

            // Создание нового Bitmap с желаемым размером
            int newWidth = 30; // Новая ширина
            int newHeight = 30; // Новая высота
            resizedImage = new Bitmap(originalImage, newWidth, newHeight);

            Image originalImage1 = Image.FromFile("D:\\C#\\android_app\\Exam10\\bl_t.png");

            // Создание нового Bitmap с желаемым размером
            int newWidth1 = 30; // Новая ширина
            int newHeight1 = 30; // Новая высота
            resizedImage1 = new Bitmap(originalImage1, newWidth1, newHeight1);

            // Установка измененного изображения в качестве изображения кнопки
            button1.Image = resizedImage1;

            Image originalImage2 = Image.FromFile("D:\\C#\\android_app\\Exam10\\bl_c.png");

            // Создание нового Bitmap с желаемым размером
            int newWidth2 = 30; // Новая ширина
            int newHeight2 = 30; // Новая высота
            resizedImage2 = new Bitmap(originalImage2, newWidth2, newHeight2);

            // Установка измененного изображения в качестве изображения кнопки
            button1.Image = resizedImage2;

            kkk();
            //int count = 25;

            //Random random = new Random();
            //int k = 0;
            ////string n;
            //int cord = random.Next(count);
            //for (int i = 1; i <= count; i++)
            //{
            //    string buttonName = "button" + i;
            //    Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
            //    if (currentButton != null && random.Next(count) > 2)
            //    {
            //        if (random.Next(10) % 2 == 0)
            //        {
            //            currentButton.Image = resizedImage;
            //        }
            //        if (random.Next(10) % 2 != 0)
            //        {
            //            currentButton.Image = resizedImage1;
            //        }
            //        if (i==cord)
            //        {
            //            if (k == 0)
            //            {
            //                currentButton.Image = resizedImage2;
            //                k++;
            //                n = buttonName;
            //                currentButton.Tag = "false";

            //            }
            //            //currentButton.Image = resizedImage2;
            //        }
            //        //currentButton.Image = resizedImage;
            //    }
            //    else
            //    {
            //        currentButton.Image = null;
            //    }
            //}
            //MessageBox.Show(n);
        }
        int cc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Tag == "false")
            {
                IsRI = true;
                clickedButton.Tag = "";
                cc = -1;
                MessageBox.Show("Правильно");
            }
            cc++;
            label5.Text = cc.ToString();

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsRI)
            {
                i = 0;
                IsRI = false;
                kkk();
            }
            if (i == 15)
            {
                MessageBox.Show("lose");
                Close();
                //break;
            }
            i++;
            label1.Text = i.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //button25.Visible = false;
            //button24.Visible = false;
            //button23.Visible = false;
            //button22.Visible = false;
            //button21.Visible = false;
            //button16.Visible = false;
            //button15.Visible = false;
            //button14.Visible = false;
            //button13.Visible = false;

            if (ISH)
            {
                count = 25;
                button25.Visible = true;
                button24.Visible = true;
                button23.Visible = true;
                button22.Visible = true;
                button21.Visible = true;
                button16.Visible = true;
                button15.Visible = true;
                button14.Visible = true;
                button13.Visible = true;
            }
            else
            {
                button25.Visible = false;
                button24.Visible = false;
                button23.Visible = false;
                button22.Visible = false;
                button21.Visible = false;
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                button13.Visible = false;

                count = 16;
            }
            ISH = !ISH;
            kkk();
        }
        int count = 25;
        private void kkk()
        {
            Random random = new Random();

            //int emptyCoordCount = random.Next(1,count/2);
            int cord = random.Next(1,count+1);

            //List<int> list = new();
            //list.Add(cord);
            //for (int i = 1; i <= emptyCoordCount; i++)
            //{
            //    int coord = random.Next(count);
            //    if (!list.Contains(coord))
            //        list.Add(coord);
            //    else i--;
            //}

            //for (int i = 1; i <= count; i++)
            //{
            //    string buttonName = $"button{i}";
            //    Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
            //    if (currentButton != null)
            //    {
            //        if (list.Contains(i) && i!=cord)
            //        {
            //            currentButton.Image = null;
            //            continue;
            //        }

            //        if (i == cord)
            //        {
            //            currentButton.Image = resizedImage2;
            //            currentButton.Tag = "false";
            //        }
            //        else if (random.Next(2) == 0)
            //        {
            //            currentButton.Image = resizedImage;
            //        }
            //        else
            //        {
            //            currentButton.Image = resizedImage1;
            //        }
            //    }
            //}
            for (int i = 1; i <= count; i++)
            {
                string buttonName = "button" + i;
                Button currentButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (currentButton != null && random.Next(count) > 2)
                {
                    if (random.Next(10) % 2 == 0)
                    {
                        currentButton.Image = resizedImage;
                    }
                    if (random.Next(10) % 2 != 0)
                    {
                        currentButton.Image = resizedImage1;
                    }
                    if (i == cord)
                    {

                        currentButton.Image = resizedImage2;


                        currentButton.Tag = "false";


                        //currentButton.Image = resizedImage2;
                    }
                    //currentButton.Image = resizedImage;
                }
                else
                {
                    currentButton.Image = null;
                }
            }
        }

    }
}