using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LVQ__WITH_MNIST
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            saveFile.Enabled = false;
            panel1.Visible = false;
            panel2.Visible = false;
            test.Visible = false;
            richTextBox1.Visible = false;
            lvq_2.Visible = false;
            lvq_3.Visible = false;
            label5.Visible = false;
            epsilonR.Visible = false;
        }
        private List<Data> trainImages;//eğitim seti 
        private List<Data> trainCode;//eğitim seti 
        private List<Data> testImages;// test seti
        private Bitmap bitMap;//image
        private List<double> color;// image color
        private string path; 
        private string[] directoryPaths;
        private string[] directoryPathsTwo;
        private int directoryPathsTwoCount;
        private string[] filePaths;
        private int filePathsCount;
        private List<Data> codebooks;//codebook listesi
        private int codeN, n, cbCount, dd;//codebook sayısı //toplam eğitim veri saysı//10*codebook sayısı// resmin piksel sayısı
        private int x = 0, x1 = 0;
        private double s0 = 0, s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0, s6 = 0, s7 = 0, s8 = 0, s9 = 0, ss = 0;
        private Random r;
        private void openFile_Click(object sender, EventArgs e)//Dosya açma ve okuma
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)    //klasör açma 
                {
                    path = folderBrowserDialog.SelectedPath;
                    directoryPaths = Directory.GetDirectories(path);                   
                    directoryPathsTwo = Directory.GetDirectories(directoryPaths[1]);
                    directoryPathsTwoCount = directoryPathsTwo.Length;//10 klasor
                    trainImages = new List<Data>();
                    trainCode = new List<Data>();
                    for (int i = 0; i < directoryPathsTwoCount; i++)//eğitim verileri alınıyor
                    {
                        filePaths = Directory.GetFiles(directoryPathsTwo[i]);
                        filePathsCount = filePaths.Length;
                        for (int j = 0; j < filePathsCount; j++)
                        {
                            bitMap = new Bitmap(filePaths[j]);
                            trainImages.Add(new Data(i, 0, colorList(bitMap)));
                            trainCode.Add(new Data(i, 0, colorList(bitMap)));
                        }
                    }
                    directoryPathsTwo = Directory.GetDirectories(directoryPaths[0]);
                    testImages = new List<Data>();
                    for (int i = 0; i < directoryPathsTwoCount; i++)//test verileri alınıyor
                    {
                        filePaths = Directory.GetFiles(directoryPathsTwo[i]);
                        filePathsCount = filePaths.Length;
                        for (int j = 0; j < filePathsCount; j++)
                        {
                            bitMap = new Bitmap(filePaths[j]);
                            testImages.Add(new Data(i, 0, colorList(bitMap)));
                        }
                    }
                    MessageBox.Show("File reading successful.");
                    panel1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File reading Error:" + ex.Message);

            }
        }
        private List<double> colorList(Bitmap bitMap)// resmin tek rgb  renginden b yi max min ile tek listeye ekler
        {
            color = new List<double>();
            for (int xx = 0; xx < bitMap.Width; xx++)
            {
                for (int yy = 0; yy < bitMap.Height; yy++)
                {
                    color.Add((bitMap.GetPixel(xx, yy).B / 255.0));
                }
            }
            return color;
        }
        private void codebookList()//Codebook listesini yapar
        {
            int d;
            List<int> rNumber = new List<int>();
            codebooks = new List<Data>();
            r = new Random();
            int a = 0, b = 0, c = n / directoryPathsTwoCount;
            try
            {
                for (int i = 0; i < directoryPathsTwoCount; i++)
                {
                    rNumber.Clear();
                    a = b;
                    b += c;
                    for (int j = 0; j < codeN; j++)
                    {
                        d = r.Next(a, b);
                        if (rNumber.Contains(d))
                        {
                            j--;
                        }
                        else
                        {
                            codebooks.Add(trainCode[d]);
                            rNumber.Add(d);
                        }
                    }
                }
                MessageBox.Show("Codebooks creating successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Codebooks creating Error:" + ex.Message);
            }

        }
        private void trainShuffle() // Eğitim setini karıştırma
        {
            int d;
            Data t = new Data();
            for (int i = 0; i < n; i++)
            {
                d = r.Next(n);
                t = trainImages[i];
                trainImages[i] = trainImages[d];
                trainImages[d] = t;
            }
        }
        private void codebookCreate_Click(object sender, EventArgs e)//codebook oluşturma
        {
            if (codebookCount.Text != "")
            {
                richTextBox1.Visible = false;
                progressBar1.Visible = false;
                test.Visible = false;
                codebookCreate.Enabled = false;
                codebTrain.Enabled = true;
                codeN = Convert.ToInt32(codebookCount.Text);
                n = trainImages.Count;
                codebookList();
                dd = trainImages[0].vector.Count;
                lvq_2.Visible = true;
                lvq_3.Visible = true;
                panel2.Visible = true;
            }
            else
                MessageBox.Show("Do not enter a blank value");
        }
        private void codebTrain_Click(object sender, EventArgs e)//codebook eğitimi button
        {
            if (learningR.Text != "" && windowR.Text != "" && iterationC.Text != "" && epsilonR.Text != "")
            {
                double learningRate = Convert.ToDouble(learningR.Text), windowRate = Convert.ToDouble(windowR.Text), epsilon = Convert.ToDouble(epsilonR.Text);
                int iter = Convert.ToInt32(iterationC.Text);
                if (learningRate <= 1 && windowRate <= 1 && epsilon <= 1)
                {
                    codebTrain.Enabled = false;
                    codebookCreate.Enabled = false;

                    cbCount = codebooks.Count;
                    trainShuffle();
                    codeBookTrain(iter, learningRate, windowRate, epsilon);
                    test.Visible = true;
                    test.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please enter rates from one to small");
                }

            }
            else
            {
                MessageBox.Show("Do not enter a blank value");
            }
        }
        private void distanceCalculate(string what, int x)// train ve test datalarının codebook vektörlerine uzaklıgını hesaplar
        {
            double sum = 0;
            if (what == "train")
            {
                for (int i = 0; i < cbCount; i++)
                {
                    sum = 0;
                    for (int k = 0; k < dd; k++)
                    {
                        sum += Math.Pow((codebooks[i].vector[k] - trainImages[x].vector[k]), 2);

                    }
                    codebooks[i].distance = Math.Sqrt(sum);
                }
            }
            else if (what == "test")
            {
                for (int i = 0; i < cbCount; i++)
                {
                    sum = 0;
                    for (int k = 0; k < dd; k++)
                    {
                        sum += Math.Pow((codebooks[i].vector[k] - testImages[x].vector[k]), 2);
                    }
                    codebooks[i].distance = Math.Sqrt(sum);
                }
            }
        }
        private void codeBookTrain(int iter, double learn, double window, double epsilon)//codebook eğitimi
        {
            double s = (1 - window) / (1 + window);
            progressBar1.Visible = true;
            progressBar1.Maximum = iter;
            progressBar1.Value = 0;
            double minMax, maxMin, min;
            try
            {
                for (int i = 0; i < iter; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        distanceCalculate("train", j);
                        List<Data> minData = minDistanceFind("train");
                        minMax = minData[0].distance / minData[1].distance;
                        maxMin = minData[1].distance / minData[0].distance;
                        if (minMax <= maxMin)
                        {
                            min = minMax;
                        }
                        else
                        {
                            min = maxMin;
                        }
                        if (min > s)
                        {
                            if (lvq_2.Checked)
                            {
                                lvqTwo(j, x, learn);
                                lvqTwo(j, x1, learn);
                            }
                            else
                            {
                                if (minData[0].cls == minData[1].cls && minData[0].cls == trainImages[j].cls)
                                {
                                    lvqThree(j, x, learn, epsilon);

                                }
                                else
                                {
                                    lvqTwo(j, x, learn);
                                    lvqTwo(j, x1, learn);
                                }
                            }
                        }
                    }
                    Application.DoEvents();
                    progressBar1.Value = i + 1;
                   
                }
                MessageBox.Show("Codebook traing successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Codebook traing Error: " + ex.Message);

            }
        }
        private List<Data> minDistanceFind(string what)// minimun codebook vektorlerini bulma
        {
            List<Data> minData = new List<Data>();
            double min1 = double.MaxValue, min2 = double.MaxValue;
            Data minOne = new Data();
            Data minTwo = new Data();
            if (what == "train")
            {
                if (lvq_2.Checked)
                {
                    for (int i = 0; i < cbCount; i++)
                    {
                        if (codebooks[i].distance <= min1)
                        {
                            min1 = codebooks[i].distance;
                            minOne = codebooks[i];
                            x = i;
                        }
                        else
                        if (codebooks[i].distance <= min2 && codebooks[i].cls != minOne.cls)
                        {
                            min2 = codebooks[i].distance;
                            minTwo = codebooks[i];
                            x1 = i;
                        }
                    }
                    minData.Add(minOne);
                    minData.Add(minTwo);
                }
                else
                {
                    for (int i = 0; i < cbCount; i++)
                    {

                        if (codebooks[i].distance <= min1)
                        {
                            min1 = codebooks[i].distance;
                            minOne = codebooks[i];
                            x = i;
                        }
                        else
                        if (codebooks[i].distance <= min2 && i != x)
                        {
                            min2 = codebooks[i].distance;
                            minTwo = codebooks[i];
                            x1 = i;
                        }
                    }
                    minData.Add(minOne);
                    minData.Add(minTwo);
                }
            }
            else if (what == "test")
            {
                for (int i = 0; i < cbCount; i++)
                {

                    if (codebooks[i].distance < min1)
                    {
                        min1 = codebooks[i].distance;
                        minOne = codebooks[i];
                        x = i;
                    }
                }
                minData.Add(minOne);
            }
            return minData;
        }
        private void lvqTwo(int j, int k, double learn)//lvq2
        {
            double sub = 0;
            if (trainImages[j].cls == codebooks[k].cls)
            {
                for (int i = 0; i < dd; i++)
                {
                    sub = (trainImages[j].vector[i] - codebooks[k].vector[i]);
                    codebooks[k].vector[i] += learn * sub;
                }
            }
            else
            {
                for (int i = 0; i < dd; i++)
                {
                    sub = (trainImages[j].vector[i] - codebooks[k].vector[i]);
                    codebooks[k].vector[i] -= learn * sub;
                }
            }
        }
        private void lvqThree(int j, int k, double learn, double epsilon)//lvq3
        {
            double sub = 0;
            for (int i = 0; i < dd; i++)
            {
                sub = (trainImages[j].vector[i] - codebooks[k].vector[i]);
                codebooks[k].vector[i] += epsilon * learn * sub;
            }
        }
        private void test_Click(object sender, EventArgs e)// test button
        {
            test.Enabled = false;
            testing();
            richTextBox1.Visible = true;
            codebookCreate.Enabled = true;
            codebTrain.Enabled = true;
            saveFile.Enabled = true;
        }
        private void testing()//test
        {
            s0 = 0; s1 = 0; s2 = 0; s3 = 0; s4 = 0; s5 = 0; s6 = 0; s7 = 0; s8 = 0; s9 = 0; ss = 0;
            n = testImages.Count;
            int t = n / directoryPathsTwoCount;
            richTextBox1.Clear();
            try
            {
                for (int i = 0; i < n; i++)
                {
                    distanceCalculate("test", i);
                    List<Data> min = minDistanceFind("test");
                    if (testImages[i].cls == min[0].cls)
                    {
                        ss++;
                        switch (min[0].cls)
                        {
                            case 0: s0++; break;
                            case 1: s1++; break;
                            case 2: s2++; break;
                            case 3: s3++; break;
                            case 4: s4++; break;
                            case 5: s5++; break;
                            case 6: s6++; break;
                            case 7: s7++; break;
                            case 8: s8++; break;
                            case 9: s9++; break;

                        }
                    }
                }
                s0 = s0 / t;
                s1 = s1 / t;
                s2 = s2 / t;
                s3 = s3 / t;
                s4 = s4 / t;
                s5 = s5 / t;
                s6 = s6 / t;
                s7 = s7 / t;
                s8 = s8 / t;
                s9 = s9 / t;
                ss = ss / n;
                richTextBox1.Text = "0 için " + s0 +
                    "\n" + "1 için " + s1 +
                     "\n" + "2 için " + s2 +
                      "\n" + "3 için " + s3 +
                       "\n" + "4 için " + s4 +
                        "\n" + "5 için " + s5 +
                         "\n" + "6 için " + s6 +
                          "\n" + "7 için " + s7 +
                           "\n" + "8 için " + s8 +
                            "\n" + "9 için " + s9 +
                             "\n" + "Total Başarı " + ss;
                MessageBox.Show("Testing successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Testing Error: " + ex.Message);
            }
        }
        private void saveFile_Click(object sender, EventArgs e)//Dosyaya yazma
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Filter = "Metin Dosyası|*.txt";
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sv = new StreamWriter(save.FileName, append: true);
                    if (lvq_2.Checked)
                    {
                        sv.WriteLine(lvq_2.Text + " :> Codebook sayısı:" + codebookCount.Text + " Learning rate:" + learningR.Text
                       + " Window rate:" + windowR.Text + " Iteration:" + iterationC.Text);
                    }
                    else
                    {
                        sv.WriteLine(lvq_3.Text + ":> Codebook sayısı:" + codebookCount.Text + ", Learning rate:" + learningR.Text
                       + ", Window rate:" + windowR.Text + ", Epsilon rate:" + epsilonR.Text + " Iteration:" + iterationC.Text);
                    }
                    sv.WriteLine("Rakam sınıfı    : 0    1    2    3    4    5    6    7    8    9    Ortalama");
                    sv.WriteLine("Accuracy değeri : " + s0 + " " + s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5 + " " + s6 + " " + s7 + " " + s8 + " " + s9 + " " + ss);
                    sv.WriteLine("----------------------------------------------------------------------------");
				   sv.Close();
                    MessageBox.Show("Written to file");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not write to file Error:" + ex.Message);

            }
        }
        private void lvq_2_CheckedChanged(object sender, EventArgs e)
        {
            if (lvq_2.Checked)
            {
                label5.Visible = false;
                epsilonR.Visible = false;
            }
            else
            {
                label5.Visible = true;
                epsilonR.Visible = true;
            }
        }
        private void codebookCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void learningR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)08 && e.KeyChar != (char)46;
        }
        private void windowR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)08 && e.KeyChar != (char)46;
        }
        private void iterationC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void epsilonR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)46);
        }

    }
}