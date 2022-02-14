
namespace _5412_Ficha1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maisA = new System.Windows.Forms.Button();
            this.menosA = new System.Windows.Forms.Button();
            this.maisB = new System.Windows.Forms.Button();
            this.menosB = new System.Windows.Forms.Button();
            this.labelTempo = new System.Windows.Forms.Label();
            this.equipaA = new System.Windows.Forms.Label();
            this.equipaB = new System.Windows.Forms.Label();
            this.ScoreA = new System.Windows.Forms.Label();
            this.ScoreB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.parte = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maisA
            // 
            this.maisA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maisA.Location = new System.Drawing.Point(45, 360);
            this.maisA.Name = "maisA";
            this.maisA.Size = new System.Drawing.Size(47, 36);
            this.maisA.TabIndex = 0;
            this.maisA.Text = "+";
            this.maisA.UseVisualStyleBackColor = true;
            this.maisA.Click += new System.EventHandler(this.button1_Click);
            // 
            // menosA
            // 
            this.menosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menosA.Location = new System.Drawing.Point(112, 362);
            this.menosA.Name = "menosA";
            this.menosA.Size = new System.Drawing.Size(44, 33);
            this.menosA.TabIndex = 1;
            this.menosA.Text = "-";
            this.menosA.UseVisualStyleBackColor = true;
            this.menosA.Click += new System.EventHandler(this.button2_Click);
            // 
            // maisB
            // 
            this.maisB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maisB.Location = new System.Drawing.Point(444, 355);
            this.maisB.Name = "maisB";
            this.maisB.Size = new System.Drawing.Size(52, 40);
            this.maisB.TabIndex = 2;
            this.maisB.Text = "+";
            this.maisB.UseVisualStyleBackColor = true;
            this.maisB.Click += new System.EventHandler(this.cliqueAqui);
            // 
            // menosB
            // 
            this.menosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menosB.Location = new System.Drawing.Point(516, 355);
            this.menosB.Name = "menosB";
            this.menosB.Size = new System.Drawing.Size(52, 40);
            this.menosB.TabIndex = 4;
            this.menosB.Text = "-";
            this.menosB.UseVisualStyleBackColor = true;
            this.menosB.Click += new System.EventHandler(this.menosB_Click);
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempo.Location = new System.Drawing.Point(241, 101);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(151, 59);
            this.labelTempo.TabIndex = 7;
            this.labelTempo.Text = "00:00";
            // 
            // equipaA
            // 
            this.equipaA.AutoSize = true;
            this.equipaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipaA.Location = new System.Drawing.Point(58, 263);
            this.equipaA.Name = "equipaA";
            this.equipaA.Size = new System.Drawing.Size(104, 29);
            this.equipaA.TabIndex = 8;
            this.equipaA.Text = "Tondela";
            // 
            // equipaB
            // 
            this.equipaB.AutoSize = true;
            this.equipaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipaB.Location = new System.Drawing.Point(472, 263);
            this.equipaB.Name = "equipaB";
            this.equipaB.Size = new System.Drawing.Size(73, 29);
            this.equipaB.TabIndex = 9;
            this.equipaB.Text = "Porto";
            // 
            // ScoreA
            // 
            this.ScoreA.AutoSize = true;
            this.ScoreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreA.Location = new System.Drawing.Point(93, 313);
            this.ScoreA.Name = "ScoreA";
            this.ScoreA.Size = new System.Drawing.Size(27, 29);
            this.ScoreA.TabIndex = 10;
            this.ScoreA.Text = "0";
            // 
            // ScoreB
            // 
            this.ScoreB.AutoSize = true;
            this.ScoreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreB.Location = new System.Drawing.Point(495, 313);
            this.ScoreB.Name = "ScoreB";
            this.ScoreB.Size = new System.Drawing.Size(27, 29);
            this.ScoreB.TabIndex = 11;
            this.ScoreB.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(421, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // parte
            // 
            this.parte.AutoSize = true;
            this.parte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parte.Location = new System.Drawing.Point(264, 180);
            this.parte.Name = "parte";
            this.parte.Size = new System.Drawing.Size(100, 29);
            this.parte.TabIndex = 12;
            this.parte.Text = "1ª parte";
            // 
            // inicio
            // 
            this.inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.Location = new System.Drawing.Point(209, 322);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(189, 73);
            this.inicio.TabIndex = 13;
            this.inicio.Text = "COMEÇAR O JOGO";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Carregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.parte);
            this.Controls.Add(this.ScoreB);
            this.Controls.Add(this.ScoreA);
            this.Controls.Add(this.equipaB);
            this.Controls.Add(this.equipaA);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menosB);
            this.Controls.Add(this.maisB);
            this.Controls.Add(this.menosA);
            this.Controls.Add(this.maisA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maisA;
        private System.Windows.Forms.Button menosA;
        private System.Windows.Forms.Button maisB;
        private System.Windows.Forms.Button menosB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Label equipaA;
        private System.Windows.Forms.Label equipaB;
        private System.Windows.Forms.Label ScoreA;
        private System.Windows.Forms.Label ScoreB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label parte;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

