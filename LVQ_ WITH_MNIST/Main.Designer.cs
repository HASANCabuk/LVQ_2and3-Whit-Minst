namespace LVQ__WITH_MNIST
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.test = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.epsilonR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.windowR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationC = new System.Windows.Forms.TextBox();
            this.learningR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codebTrain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvq_3 = new System.Windows.Forms.RadioButton();
            this.lvq_2 = new System.Windows.Forms.RadioButton();
            this.codebookCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codebookCreate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 269);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 153);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(12, 228);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(418, 35);
            this.test.TabIndex = 25;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.epsilonR);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.windowR);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iterationC);
            this.panel2.Controls.Add(this.learningR);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.codebTrain);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(224, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 145);
            this.panel2.TabIndex = 24;
            // 
            // epsilonR
            // 
            this.epsilonR.Location = new System.Drawing.Point(99, 83);
            this.epsilonR.Name = "epsilonR";
            this.epsilonR.Size = new System.Drawing.Size(100, 20);
            this.epsilonR.TabIndex = 16;
            this.epsilonR.Text = "0.01";
            this.epsilonR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epsilonR_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Epsilon rate";
            // 
            // windowR
            // 
            this.windowR.Location = new System.Drawing.Point(99, 33);
            this.windowR.Name = "windowR";
            this.windowR.Size = new System.Drawing.Size(100, 20);
            this.windowR.TabIndex = 12;
            this.windowR.Text = "0.25";
            this.windowR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.windowR_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Learning rate";
            // 
            // iterationC
            // 
            this.iterationC.Location = new System.Drawing.Point(99, 59);
            this.iterationC.Name = "iterationC";
            this.iterationC.Size = new System.Drawing.Size(100, 20);
            this.iterationC.TabIndex = 14;
            this.iterationC.Text = "5";
            this.iterationC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iterationC_KeyPress);
            // 
            // learningR
            // 
            this.learningR.Location = new System.Drawing.Point(99, 4);
            this.learningR.Name = "learningR";
            this.learningR.Size = new System.Drawing.Size(100, 20);
            this.learningR.TabIndex = 4;
            this.learningR.Text = "0.01";
            this.learningR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.learningR_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Iteration ";
            // 
            // codebTrain
            // 
            this.codebTrain.Location = new System.Drawing.Point(99, 104);
            this.codebTrain.Name = "codebTrain";
            this.codebTrain.Size = new System.Drawing.Size(100, 23);
            this.codebTrain.TabIndex = 10;
            this.codebTrain.Text = "Codebook Train";
            this.codebTrain.UseVisualStyleBackColor = true;
            this.codebTrain.Click += new System.EventHandler(this.codebTrain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Window rate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvq_3);
            this.panel1.Controls.Add(this.lvq_2);
            this.panel1.Controls.Add(this.codebookCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.codebookCreate);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 145);
            this.panel1.TabIndex = 23;
            // 
            // lvq_3
            // 
            this.lvq_3.AutoSize = true;
            this.lvq_3.Location = new System.Drawing.Point(125, 60);
            this.lvq_3.Name = "lvq_3";
            this.lvq_3.Size = new System.Drawing.Size(55, 17);
            this.lvq_3.TabIndex = 7;
            this.lvq_3.TabStop = true;
            this.lvq_3.Text = "LVQ-3";
            this.lvq_3.UseVisualStyleBackColor = true;
            // 
            // lvq_2
            // 
            this.lvq_2.AutoSize = true;
            this.lvq_2.Checked = true;
            this.lvq_2.Location = new System.Drawing.Point(25, 60);
            this.lvq_2.Name = "lvq_2";
            this.lvq_2.Size = new System.Drawing.Size(55, 17);
            this.lvq_2.TabIndex = 6;
            this.lvq_2.TabStop = true;
            this.lvq_2.Text = "LVQ-2";
            this.lvq_2.UseVisualStyleBackColor = true;
            this.lvq_2.CheckedChanged += new System.EventHandler(this.lvq_2_CheckedChanged);
            // 
            // codebookCount
            // 
            this.codebookCount.Location = new System.Drawing.Point(102, 3);
            this.codebookCount.Name = "codebookCount";
            this.codebookCount.Size = new System.Drawing.Size(100, 20);
            this.codebookCount.TabIndex = 3;
            this.codebookCount.Text = "5";
            this.codebookCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codebookCount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codebook Vector";
            // 
            // codebookCreate
            // 
            this.codebookCreate.Location = new System.Drawing.Point(102, 29);
            this.codebookCreate.Name = "codebookCreate";
            this.codebookCreate.Size = new System.Drawing.Size(100, 23);
            this.codebookCreate.TabIndex = 5;
            this.codebookCreate.Text = "Codebook Create";
            this.codebookCreate.UseVisualStyleBackColor = true;
            this.codebookCreate.Click += new System.EventHandler(this.codebookCreate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(103, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(103, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(418, 22);
            this.progressBar1.TabIndex = 27;
            this.progressBar1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 428);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Lvq with mnist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox windowR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iterationC;
        private System.Windows.Forms.TextBox learningR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button codebTrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox codebookCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button codebookCreate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.RadioButton lvq_3;
        private System.Windows.Forms.RadioButton lvq_2;
        private System.Windows.Forms.TextBox epsilonR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

