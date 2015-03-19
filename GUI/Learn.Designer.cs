namespace GUI
{
    partial class Learn
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.wordRemainingLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuest = new System.Windows.Forms.Label();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.Option = new System.Windows.Forms.GroupBox();
            this.buttonOverride = new System.Windows.Forms.Button();
            this.buttonStartOver = new System.Windows.Forms.Button();
            this.checkBoxJap = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNotCorrect = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelTrueAns = new System.Windows.Forms.Label();
            this.labelYourAns = new System.Windows.Forms.Label();
            this.Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Lesson";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 254);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(196, 13);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(0, 13);
            this.roundLabel.TabIndex = 2;
            // 
            // wordRemainingLabel
            // 
            this.wordRemainingLabel.AutoSize = true;
            this.wordRemainingLabel.Location = new System.Drawing.Point(345, 13);
            this.wordRemainingLabel.Name = "wordRemainingLabel";
            this.wordRemainingLabel.Size = new System.Drawing.Size(0, 13);
            this.wordRemainingLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Round";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remaning";
            // 
            // labelQuest
            // 
            this.labelQuest.AutoSize = true;
            this.labelQuest.Font = new System.Drawing.Font("Honoka Mincho", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuest.Location = new System.Drawing.Point(151, 51);
            this.labelQuest.Name = "labelQuest";
            this.labelQuest.Size = new System.Drawing.Size(71, 23);
            this.labelQuest.TabIndex = 11;
            this.labelQuest.Text = "label4";
            // 
            // textBoxAns
            // 
            this.textBoxAns.Font = new System.Drawing.Font("Honoka Mincho", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAns.Location = new System.Drawing.Point(154, 85);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(441, 31);
            this.textBoxAns.TabIndex = 12;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(688, 85);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer.TabIndex = 13;
            this.buttonAnswer.Text = "Answers";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // Option
            // 
            this.Option.Controls.Add(this.buttonOverride);
            this.Option.Controls.Add(this.buttonStartOver);
            this.Option.Controls.Add(this.checkBoxJap);
            this.Option.Location = new System.Drawing.Point(154, 206);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(609, 100);
            this.Option.TabIndex = 14;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // buttonOverride
            // 
            this.buttonOverride.Location = new System.Drawing.Point(116, 42);
            this.buttonOverride.Name = "buttonOverride";
            this.buttonOverride.Size = new System.Drawing.Size(75, 23);
            this.buttonOverride.TabIndex = 16;
            this.buttonOverride.Text = "Override";
            this.buttonOverride.UseVisualStyleBackColor = true;
            this.buttonOverride.Click += new System.EventHandler(this.buttonOverride_Click);
            // 
            // buttonStartOver
            // 
            this.buttonStartOver.Location = new System.Drawing.Point(6, 42);
            this.buttonStartOver.Name = "buttonStartOver";
            this.buttonStartOver.Size = new System.Drawing.Size(75, 23);
            this.buttonStartOver.TabIndex = 1;
            this.buttonStartOver.Text = "Start Over";
            this.buttonStartOver.UseVisualStyleBackColor = true;
            this.buttonStartOver.Click += new System.EventHandler(this.buttonStartOver_Click);
            // 
            // checkBoxJap
            // 
            this.checkBoxJap.AutoSize = true;
            this.checkBoxJap.Location = new System.Drawing.Point(6, 19);
            this.checkBoxJap.Name = "checkBoxJap";
            this.checkBoxJap.Size = new System.Drawing.Size(113, 17);
            this.checkBoxJap.TabIndex = 0;
            this.checkBoxJap.Text = "See Japanese first";
            this.checkBoxJap.UseVisualStyleBackColor = true;
            this.checkBoxJap.CheckedChanged += new System.EventHandler(this.checkBoxJap_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Incorrect";
            // 
            // labelNotCorrect
            // 
            this.labelNotCorrect.AutoSize = true;
            this.labelNotCorrect.Location = new System.Drawing.Point(472, 13);
            this.labelNotCorrect.Name = "labelNotCorrect";
            this.labelNotCorrect.Size = new System.Drawing.Size(35, 13);
            this.labelNotCorrect.TabIndex = 16;
            this.labelNotCorrect.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Correct";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(622, 13);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(35, 13);
            this.labelCorrect.TabIndex = 18;
            this.labelCorrect.Text = "label6";
            // 
            // labelTrueAns
            // 
            this.labelTrueAns.AutoSize = true;
            this.labelTrueAns.Font = new System.Drawing.Font("Honoka Mincho", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrueAns.Location = new System.Drawing.Point(151, 127);
            this.labelTrueAns.Name = "labelTrueAns";
            this.labelTrueAns.Size = new System.Drawing.Size(71, 23);
            this.labelTrueAns.TabIndex = 19;
            this.labelTrueAns.Text = "label6";
            // 
            // labelYourAns
            // 
            this.labelYourAns.AutoSize = true;
            this.labelYourAns.Location = new System.Drawing.Point(151, 165);
            this.labelYourAns.Name = "labelYourAns";
            this.labelYourAns.Size = new System.Drawing.Size(35, 13);
            this.labelYourAns.TabIndex = 20;
            this.labelYourAns.Text = "label7";
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 318);
            this.Controls.Add(this.labelYourAns);
            this.Controls.Add(this.labelTrueAns);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNotCorrect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.labelQuest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordRemainingLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Learn";
            this.Text = "Learn";
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label wordRemainingLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.Button buttonStartOver;
        private System.Windows.Forms.CheckBox checkBoxJap;
        private System.Windows.Forms.Button buttonOverride;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNotCorrect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label labelTrueAns;
        private System.Windows.Forms.Label labelYourAns;
    }
}