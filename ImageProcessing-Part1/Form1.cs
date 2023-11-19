namespace ImageProcessing_Part1
{
    public partial class Form1 : Form
    {
        Bitmap image, newImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            image = new Bitmap(openFileDialog1.FileName);

            pictureBox1.Image = image;
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color imageColor = image.GetPixel(i, j);
                    newImage.SetPixel(i, j, imageColor);
                }
            }

            pictureBox2.Image = newImage;
            image = newImage;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    int gray = (int)(changeColor.R + changeColor.G + changeColor.B) / 3;
                    newImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureBox2.Image = newImage;
            image = newImage;
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    newImage.SetPixel(i, j, Color.FromArgb(255 - changeColor.R, 255 - changeColor.G, 255 - changeColor.B));
                }
            }

            pictureBox2.Image = newImage;
            image = newImage;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    int gray = (int)(changeColor.R + changeColor.G + changeColor.B) / 3;
                    newImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            int[] histogramData = new int[256];
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color greyscaleData = newImage.GetPixel(i, j);
                    histogramData[greyscaleData.R]++;
                }
            }

            Bitmap histogramGraph = new Bitmap(256, 800);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    histogramGraph.SetPixel(i, j, Color.White);
                }
            }

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Math.Min(histogramData[i] / 5, 800); j++)
                {
                    histogramGraph.SetPixel(i, j, Color.Black);
                }
            }

            pictureBox2.Image = histogramGraph;
        }

        private void scepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color changeColor = image.GetPixel(i, j);
                    int red = (int)(changeColor.R);
                    int green = (int)(changeColor.G);
                    int blue = (int)(changeColor.B);
                    int sepiaRed = (int)((0.393 * red) + (0.769 * green) + (0.189 * blue));
                    int sepiaGreen = (int)((0.349 * red) + (0.686 * green) + (0.168 * blue));
                    int sepiaBlue = (int)((0.272 * red) + (0.534 * green) + (0.131 * blue));

                    if (sepiaRed > 255)
                    {
                        red = 255;
                    }
                    else
                    {
                        red = sepiaRed;
                    }

                    if (sepiaGreen > 255)
                    {
                        green = 255;
                    }
                    else
                    {
                        green = sepiaGreen;
                    }

                    if (sepiaBlue > 255)
                    {
                        blue = 255;
                    }
                    else
                    {
                        blue = sepiaBlue;
                    }

                    newImage.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }

            pictureBox2.Image = newImage;
            image = newImage;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            newImage.Save(saveFileDialog1.FileName);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}