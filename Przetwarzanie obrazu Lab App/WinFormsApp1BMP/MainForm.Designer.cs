namespace WinFormsApp1BMP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            OpenFilebtn1 = new Button();
            pictureBox2 = new PictureBox();
            H = new TrackBar();
            S = new TrackBar();
            V = new TrackBar();
            H2 = new TrackBar();
            S2 = new TrackBar();
            V2 = new TrackBar();
            Htxt = new TextBox();
            Stxt = new TextBox();
            Vtxt = new TextBox();
            H2txt = new TextBox();
            S2txt = new TextBox();
            V2txt = new TextBox();
            Recalculatebtn = new Button();
            pictureBox3 = new PictureBox();
            OpenFilebtn2 = new Button();
            Image1Label = new Label();
            Image2Label = new Label();
            Image3Label = new Label();
            hist_button = new Button();
            hist_button_2 = new Button();
            gauss_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)H).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S).BeginInit();
            ((System.ComponentModel.ISupportInitialize)V).BeginInit();
            ((System.ComponentModel.ISupportInitialize)H2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)V2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(14, 41);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(652, 807);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFilebtn1
            // 
            OpenFilebtn1.Location = new Point(971, 901);
            OpenFilebtn1.Margin = new Padding(3, 4, 3, 4);
            OpenFilebtn1.Name = "OpenFilebtn1";
            OpenFilebtn1.Size = new Size(127, 31);
            OpenFilebtn1.TabIndex = 1;
            OpenFilebtn1.Text = "Otwórz plik 1";
            OpenFilebtn1.UseVisualStyleBackColor = true;
            OpenFilebtn1.Click += LoadImage1btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(687, 41);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(652, 807);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // H
            // 
            H.LargeChange = 100;
            H.Location = new Point(3, 915);
            H.Margin = new Padding(3, 4, 3, 4);
            H.Maximum = 360;
            H.Name = "H";
            H.Size = new Size(334, 56);
            H.TabIndex = 3;
            H.Value = 100;
            H.Scroll += H_Scroll;
            // 
            // S
            // 
            S.Location = new Point(3, 971);
            S.Margin = new Padding(3, 4, 3, 4);
            S.Maximum = 255;
            S.Name = "S";
            S.Size = new Size(334, 56);
            S.TabIndex = 4;
            S.Value = 100;
            S.Scroll += S_Scroll;
            // 
            // V
            // 
            V.Location = new Point(3, 1024);
            V.Margin = new Padding(3, 4, 3, 4);
            V.Maximum = 255;
            V.Name = "V";
            V.Size = new Size(334, 56);
            V.TabIndex = 5;
            V.Value = 100;
            V.Scroll += V_Scroll;
            // 
            // H2
            // 
            H2.LargeChange = 100;
            H2.Location = new Point(427, 901);
            H2.Margin = new Padding(3, 4, 3, 4);
            H2.Maximum = 360;
            H2.Name = "H2";
            H2.Size = new Size(334, 56);
            H2.TabIndex = 6;
            H2.Value = 150;
            H2.Scroll += H2_Scroll;
            // 
            // S2
            // 
            S2.LargeChange = 100;
            S2.Location = new Point(427, 969);
            S2.Margin = new Padding(3, 4, 3, 4);
            S2.Maximum = 255;
            S2.Name = "S2";
            S2.Size = new Size(334, 56);
            S2.TabIndex = 7;
            S2.Value = 255;
            S2.Scroll += S2_Scroll;
            // 
            // V2
            // 
            V2.LargeChange = 100;
            V2.Location = new Point(427, 1019);
            V2.Margin = new Padding(3, 4, 3, 4);
            V2.Maximum = 255;
            V2.Name = "V2";
            V2.Size = new Size(334, 56);
            V2.TabIndex = 8;
            V2.Value = 255;
            V2.Scroll += V2_Scroll;
            // 
            // Htxt
            // 
            Htxt.Location = new Point(343, 912);
            Htxt.Margin = new Padding(3, 4, 3, 4);
            Htxt.Name = "Htxt";
            Htxt.Size = new Size(46, 27);
            Htxt.TabIndex = 9;
            Htxt.Leave += Htxt_Leave;
            // 
            // Stxt
            // 
            Stxt.Location = new Point(343, 969);
            Stxt.Margin = new Padding(3, 4, 3, 4);
            Stxt.Name = "Stxt";
            Stxt.Size = new Size(46, 27);
            Stxt.TabIndex = 10;
            Stxt.Leave += Stxt_Leave;
            // 
            // Vtxt
            // 
            Vtxt.Location = new Point(343, 1041);
            Vtxt.Margin = new Padding(3, 4, 3, 4);
            Vtxt.Name = "Vtxt";
            Vtxt.Size = new Size(46, 27);
            Vtxt.TabIndex = 11;
            Vtxt.Leave += Vtxt_Leave;
            // 
            // H2txt
            // 
            H2txt.Location = new Point(779, 912);
            H2txt.Margin = new Padding(3, 4, 3, 4);
            H2txt.Name = "H2txt";
            H2txt.Size = new Size(46, 27);
            H2txt.TabIndex = 12;
            H2txt.Leave += H2txt_Leave;
            // 
            // S2txt
            // 
            S2txt.Location = new Point(779, 971);
            S2txt.Margin = new Padding(3, 4, 3, 4);
            S2txt.Name = "S2txt";
            S2txt.Size = new Size(46, 27);
            S2txt.TabIndex = 13;
            S2txt.Leave += S2txt_Leave;
            // 
            // V2txt
            // 
            V2txt.Location = new Point(779, 1024);
            V2txt.Margin = new Padding(3, 4, 3, 4);
            V2txt.Name = "V2txt";
            V2txt.Size = new Size(46, 27);
            V2txt.TabIndex = 14;
            V2txt.Leave += V2txt_Leave;
            // 
            // Recalculatebtn
            // 
            Recalculatebtn.Location = new Point(1202, 901);
            Recalculatebtn.Margin = new Padding(3, 4, 3, 4);
            Recalculatebtn.Name = "Recalculatebtn";
            Recalculatebtn.Size = new Size(86, 31);
            Recalculatebtn.TabIndex = 15;
            Recalculatebtn.Text = "Przelicz";
            Recalculatebtn.UseVisualStyleBackColor = true;
            Recalculatebtn.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(1360, 41);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(652, 807);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // OpenFilebtn2
            // 
            OpenFilebtn2.Location = new Point(971, 944);
            OpenFilebtn2.Margin = new Padding(3, 4, 3, 4);
            OpenFilebtn2.Name = "OpenFilebtn2";
            OpenFilebtn2.Size = new Size(127, 31);
            OpenFilebtn2.TabIndex = 20;
            OpenFilebtn2.Text = "Otwórz plik 2";
            OpenFilebtn2.UseVisualStyleBackColor = true;
            OpenFilebtn2.Click += LoadImage2btn_Click;
            // 
            // Image1Label
            // 
            Image1Label.AutoSize = true;
            Image1Label.Location = new Point(14, 12);
            Image1Label.Name = "Image1Label";
            Image1Label.Size = new Size(50, 20);
            Image1Label.TabIndex = 21;
            Image1Label.Text = "label1";
            // 
            // Image2Label
            // 
            Image2Label.AutoSize = true;
            Image2Label.Location = new Point(687, 12);
            Image2Label.Name = "Image2Label";
            Image2Label.Size = new Size(50, 20);
            Image2Label.TabIndex = 22;
            Image2Label.Text = "label2";
            // 
            // Image3Label
            // 
            Image3Label.AutoSize = true;
            Image3Label.Location = new Point(1360, 17);
            Image3Label.Name = "Image3Label";
            Image3Label.Size = new Size(50, 20);
            Image3Label.TabIndex = 23;
            Image3Label.Text = "label3";
            // 
            // hist_button
            // 
            hist_button.Location = new Point(1342, 904);
            hist_button.Margin = new Padding(3, 4, 3, 4);
            hist_button.Name = "hist_button";
            hist_button.Size = new Size(86, 31);
            hist_button.TabIndex = 24;
            hist_button.Text = "histogram";
            hist_button.UseVisualStyleBackColor = true;
            hist_button.Click += HistBtn_Click;
            // 
            // hist_button_2
            // 
            hist_button_2.Location = new Point(1342, 944);
            hist_button_2.Margin = new Padding(3, 4, 3, 4);
            hist_button_2.Name = "hist_button_2";
            hist_button_2.Size = new Size(215, 31);
            hist_button_2.TabIndex = 25;
            hist_button_2.Text = "histogram - rozciagniety";
            hist_button_2.UseVisualStyleBackColor = true;
            hist_button_2.Click += hist_button_2_Click;
            // 
            // gauss_button
            // 
            gauss_button.Location = new Point(1202, 944);
            gauss_button.Margin = new Padding(3, 4, 3, 4);
            gauss_button.Name = "gauss_button";
            gauss_button.Size = new Size(86, 54);
            gauss_button.TabIndex = 26;
            gauss_button.Text = "Rozmycie Gaussa";
            gauss_button.UseVisualStyleBackColor = true;
            gauss_button.Click += gauss_button_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(gauss_button);
            Controls.Add(hist_button_2);
            Controls.Add(hist_button);
            Controls.Add(Image3Label);
            Controls.Add(Image2Label);
            Controls.Add(Image1Label);
            Controls.Add(OpenFilebtn2);
            Controls.Add(pictureBox3);
            Controls.Add(Recalculatebtn);
            Controls.Add(V2txt);
            Controls.Add(S2txt);
            Controls.Add(H2txt);
            Controls.Add(Vtxt);
            Controls.Add(Stxt);
            Controls.Add(Htxt);
            Controls.Add(V2);
            Controls.Add(S2);
            Controls.Add(H2);
            Controls.Add(V);
            Controls.Add(S);
            Controls.Add(H);
            Controls.Add(pictureBox2);
            Controls.Add(OpenFilebtn1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)H).EndInit();
            ((System.ComponentModel.ISupportInitialize)S).EndInit();
            ((System.ComponentModel.ISupportInitialize)V).EndInit();
            ((System.ComponentModel.ISupportInitialize)H2).EndInit();
            ((System.ComponentModel.ISupportInitialize)S2).EndInit();
            ((System.ComponentModel.ISupportInitialize)V2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button OpenFilebtn1;
        private PictureBox pictureBox2;
        private TrackBar H;
        private TrackBar S;
        private TrackBar V;
        private TrackBar H2;
        private TrackBar S2;
        private TrackBar V2;
        private TextBox Htxt;
        private TextBox Stxt;
        private TextBox Vtxt;
        private TextBox H2txt;
        private TextBox S2txt;
        private TextBox V2txt;
        private Button Recalculatebtn;
        private PictureBox pictureBox3;
        private Button OpenFilebtn2;
        private Label Image1Label;
        private Label Image2Label;
        private Label Image3Label;
        private Button hist_button;
        private Button hist_button_2;
        private Button gauss_button;
    }
}
