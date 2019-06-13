using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstorieSiSocietate
{
    public partial class JocPuzzle : Form
    {
        private struct PartImage
        {
            public PartImage(PictureBox box, Image img)
            {
                ImgLocation = box;
                Img = img;
            }
            public PictureBox ImgLocation;
            public Image Img;
        }

        private readonly Image[] images = Directory.GetFiles("ImaginiPuzzle").Select(file => Image.FromFile(file)).ToArray();

        private readonly Bitmap[,] breakImages = new Bitmap[2, 3];
        private readonly List<PartImage> partImages = new List<PartImage>();
        private readonly Queue<PartImage> partImagesQueue = new Queue<PartImage>();

        private Point pic1Location, pic2Location, pic3Location, mouseDownLocation;

        private PictureBox pic1BoxLocation, pic2BoxLocation, pic3BoxLocation;

        private bool gameStarted = false;

        private int ticks=0;

        public JocPuzzle()
        {
            InitializeComponent();
        }

        #region ShuffleBox1
        private void PicShuffle1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void PicShuffle1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picShuffle1.Left = e.X + picShuffle1.Left - mouseDownLocation.X;
                picShuffle1.Top = e.Y + picShuffle1.Top - mouseDownLocation.Y;
            }
        }

        private void PicShuffle1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picOver = GetOverBox();
            if ((picOver != null) && (picOver == pic1BoxLocation))
            {
                picOver.Image = picShuffle1.Image;
                GetNewShuffleImage(1);
                if (picShuffle1.Image == null)
                {
                    picShuffle1.Enabled = false;
                }
            }

            picShuffle1.Location = pic1Location;
        }
        #endregion

        #region ShuffleBox2
        private void PicShuffle2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void PicShuffle2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picShuffle2.Left = e.X + picShuffle2.Left - mouseDownLocation.X;
                picShuffle2.Top = e.Y + picShuffle2.Top - mouseDownLocation.Y;
            }
        }

        private void PicShuffle2_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picOver = GetOverBox();
            if ((picOver != null) && (picOver == pic2BoxLocation))
            {
                picOver.Image = picShuffle2.Image;
                GetNewShuffleImage(2);
                if (picShuffle2.Image == null)
                {
                    picShuffle2.Enabled = false;
                }
            }

            picShuffle2.Location = pic2Location;
        }
        #endregion

        #region ShuffleBox3
        private void PicShuffle3_MouseDown(object sender, MouseEventArgs e)
        {
            //Debug.Print(picShuffle3.Enabled.ToString());
            if (e.Button == MouseButtons.Left) mouseDownLocation = e.Location;
        }

        private void PicShuffle3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picShuffle3.Left = e.X + picShuffle3.Left - mouseDownLocation.X;
                picShuffle3.Top = e.Y + picShuffle3.Top - mouseDownLocation.Y;
            }
        }

        private void PicShuffle3_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picOver = GetOverBox();
            if ((picOver != null) && (picOver == pic3BoxLocation))
            {
                picOver.Image = picShuffle3.Image;
                GetNewShuffleImage(3);
                if (picShuffle3.Image == null)
                {
                    picShuffle3.Enabled = false;
                }
            }

            picShuffle3.Location = pic3Location;
        }
        #endregion

        private void GetNewShuffleImage(int id)
        {
            PartImage part = new PartImage();
            if (partImagesQueue.Count != 0) part = partImagesQueue.Dequeue();
            else
            {
                part.Img = null;
                part.ImgLocation = null;
            }

            switch (id)
            {
                case 1:
                    if (part.Img == null)
                    {
                        picShuffle1.Enabled = false;
                    }
                    picShuffle1.Image = part.Img;
                    pic1BoxLocation = part.ImgLocation;
                    break;

                case 2:
                    if (part.Img == null)
                    {
                        picShuffle2.Enabled = false;
                    }
                    picShuffle2.Image = part.Img;
                    pic2BoxLocation = part.ImgLocation;
                    break;

                case 3:
                    if (part.Img == null)
                    {
                        picShuffle3.Enabled = false;
                    }
                    picShuffle3.Image = part.Img;
                    pic3BoxLocation = part.ImgLocation;
                    break;
            }
        }

        private PictureBox GetOverBox()
        {
            if (picArr00.ClientRectangle.Contains(picArr00.PointToClient(MousePosition))) return picArr00;
            if (picArr01.ClientRectangle.Contains(picArr01.PointToClient(MousePosition))) return picArr01;
            if (picArr02.ClientRectangle.Contains(picArr02.PointToClient(MousePosition))) return picArr02;

            if (picArr10.ClientRectangle.Contains(picArr10.PointToClient(MousePosition))) return picArr10;
            if (picArr11.ClientRectangle.Contains(picArr11.PointToClient(MousePosition))) return picArr11;
            if (picArr12.ClientRectangle.Contains(picArr12.PointToClient(MousePosition))) return picArr12;

            return null;
        }

        private void TimerBar_Tick(object sender, EventArgs e)
        {
            ticks++;
            if(!gameStarted)
            {
                if (ticks == 6)
                {
                    progressTimeLeft.Step = -1;
                    labelMem.Visible = false;

                    StartGame();
                }
                else
                {
                    textTimeLeft.Text = (6-ticks).ToString();
                }
            }
            else
            {
                if (CheckEnd() == true || ticks == 36)
                {
                    EndGame();
                }
                else
                {
                    textTimeLeft.Text = $"Timp rămas: {(36 - ticks).ToString()} secunde";
                }
            }

            progressTimeLeft.PerformStep();
        }

        private bool CheckEnd()
        {
            if ((picShuffle1.Enabled == false) && (picShuffle2.Enabled == false) && (picShuffle3.Enabled == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EndGame()
        {
            picInitial.Show();
            timerBar.Stop();
            gameStarted = false;

            partImages.Clear();
            partImagesQueue.Clear();

            if (CheckEnd() != true)
            {
                textTimeLeft.Text = "Nu ai reușit să termini la timp... :(";
            }
            else
            {
                textTimeLeft.Text = "Felicitări! Încă o rundă?";
            }


            #region Pics Cleanup
            picArr00.Image = null;
            picArr01.Image = null;
            picArr02.Image = null;
            picArr10.Image = null;
            picArr11.Image = null;
            picArr12.Image = null;

            picShuffle1.Enabled = false;
            picShuffle1.Image = null;
            picShuffle2.Enabled = false;
            picShuffle2.Image = null;
            picShuffle3.Enabled = false;
            picShuffle3.Image = null;
            #endregion

            btnGameStart.Enabled = true;
        }

        private void JocPuzzle_Load(object sender, EventArgs e)
        {
            pic1Location = picShuffle1.Location;
            pic2Location = picShuffle2.Location;
            pic3Location = picShuffle3.Location;

            picShuffle1.Enabled = false;
            picShuffle2.Enabled = false;
            picShuffle3.Enabled = false;
        }

        private void BtnGameStart_Click(object sender, EventArgs e)
        {
            Image image = images[new Random().Next(0, images.Length - 1)];
            picInitial.Image = image;

            ticks = 0;
            timerBar.Enabled = true;

            progressTimeLeft.Value = progressTimeLeft.Minimum;
            progressTimeLeft.Step = 6;

            labelMem.Visible = true;

            btnGameStart.Enabled = false;
        }

        private void StartGame()
        {
            labelMem.Visible = false;

            picShuffle1.Enabled = true;
            picShuffle2.Enabled = true;
            picShuffle3.Enabled = true;

            BreakImage();
            RandImages();
            SetInitialBoxes();

            picInitial.Visible = false;

            gameStarted = true;
        }

        private void SetInitialBoxes()
        {
            PartImage part;

            part = partImagesQueue.Dequeue();
            picShuffle1.Image = part.Img;
            pic1BoxLocation = part.ImgLocation;

            part = partImagesQueue.Dequeue();
            picShuffle2.Image = part.Img;
            pic2BoxLocation = part.ImgLocation;

            part = partImagesQueue.Dequeue();
            picShuffle3.Image = part.Img;
            pic3BoxLocation = part.ImgLocation;
        }

        private void RandImages()
        {
            while (partImages.Count != 0)
            {
                int index = new Random().Next(0, partImages.Count - 1);

                partImagesQueue.Enqueue(partImages[index]);
                partImages.RemoveAt(index);
            }
        }

        private void BreakImage()
        {
            Image initImage = picInitial.Image;

            int width = (int)(initImage.Width / 3.0 + 0.5);
            int height = (int)(initImage.Height / 3.0 + 0.5);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    breakImages[i, j] = new Bitmap(width, height);

                    using (Graphics graphics = Graphics.FromImage(breakImages[i, j]))
                    {
                        graphics.DrawImage(initImage, new Rectangle(0, 0, width, height), new Rectangle(j * width, i * height, width, height), GraphicsUnit.Pixel);
                    }

                    partImages.Add(new PartImage(GetBoxFromMatrix(i, j), breakImages[i, j]));
                }
            }
        }

        private PictureBox GetBoxFromMatrix(int i, int j)
        {
            if (i == 0 && j == 0) return picArr00;
            if (i == 0 && j == 1) return picArr01;
            if (i == 0 && j == 2) return picArr02;

            if (i == 1 && j == 0) return picArr10;
            if (i == 1 && j == 1) return picArr11;
            if (i == 1 && j == 2) return picArr12;

            throw new IndexOutOfRangeException();
        }
    }
}
