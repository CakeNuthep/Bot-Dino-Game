using BotDinoGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotDinoGame
{
    public partial class Form1 : Form
    {
        List<ProcessModel> listProcess = new List<ProcessModel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timerAutoRun_Tick(object sender, EventArgs e)
        {
            foreach (ProcessModel data in listProcess)
            {
                Image image = SpecificSnap.Snip(data.rect);
                if (checkBoxShowRealTimeSnip.Checked)
                {
                    pictureBoxRealtimeSnip.Image = image;
                }
                avoidObstacles(image, data);
            }
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            Image image;
            Rectangle rcSelect;
            this.Hide();
            Thread.Sleep(1000);
            if (SnippingTool.Snip(out image, out rcSelect))
            {
                DialogResult dr;
                ConditionForm conForm = new ConditionForm(rcSelect);
                dr = conForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    ProcessModel data = conForm.getResultData();

                    listProcess.Add(data);
                    listBoxCapture.Items.Add(string.Format("{0},threshold:{1}, operation:{2},action:{3}", rcSelect, data.threshold, data.operaion.Value, data.action.Value));
                    if (image != null)
                    {
                        pictureBoxFirstSnip.Image = image;
                    }
                    if (checkBoxShowRealTimeSnip.Checked)
                    {
                        pictureBoxRealtimeSnip.Image = SpecificSnap.Snip(rcSelect);
                    }
                }
                this.Show();
            }
        }

        private void buttonDeleteCapture_Click(object sender, EventArgs e)
        {
            if (listBoxCapture.SelectedIndex >= 0)
            {
                listProcess.RemoveAt(listBoxCapture.SelectedIndex);
                listBoxCapture.Items.RemoveAt(listBoxCapture.SelectedIndex);
            }
        }

        private void buttonAutoRun_Click(object sender, EventArgs e)
        {
            if (buttonAutoRun.Text == "Auto Run")
            {
                timerAutoRun.Start();
                buttonAutoRun.Text = "Stop";
            }
            else
            {
                timerAutoRun.Stop();
                buttonAutoRun.Text = "Auto Run";
            }
        }

        private bool avoidObstacles(Image image, ProcessModel data)
        {
            double avgColor = avgGrayScaleColor(image);
            Console.WriteLine(avgColor);
            if (data.operaion.Value == OperationModel.LessThan.Value)
            {
                if (avgColor < data.threshold)
                {
                    SendKeys.Send(data.action.Value);
                    return true;
                }
            }
            else if (data.operaion.Value == OperationModel.GreaterThan.Value)
            {
                if (avgColor > data.threshold)
                {
                    SendKeys.Send(data.action.Value);
                    return true;
                }
            }
            return false;
        }

        private double avgGrayScaleColor(Image image)
        {
            Bitmap bmpImage = (Bitmap)image;
            double totalGrayScaleColor = 0;
            double avgGrayScaleColor;
            for (int x = 0; x < bmpImage.Width; x++)
            {
                for (int y = 0; y < bmpImage.Height; y++)
                {
                    Color originalColor = ((Bitmap)image).GetPixel(x, y);
                    // convert RGB to Gray.
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                    totalGrayScaleColor += grayScale;
                }
            }
            //calculate the average of GrayScale picture.
            avgGrayScaleColor = (totalGrayScaleColor) / (bmpImage.Width * bmpImage.Height);
            return avgGrayScaleColor;
        }
    }
}
