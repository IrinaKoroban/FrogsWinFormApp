namespace FrogsWinFormsApp
{
    partial class FrogsForm
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
            this.leftFrogPictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.начатьСНачалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьСНачалаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftFrogPictureBox2 = new System.Windows.Forms.PictureBox();
            this.leftFrogPictureBox3 = new System.Windows.Forms.PictureBox();
            this.leftFrogPictureBox4 = new System.Windows.Forms.PictureBox();
            this.emptyPictureBox = new System.Windows.Forms.PictureBox();
            this.rightFrogPictureBox1 = new System.Windows.Forms.PictureBox();
            this.rightFrogPictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightFrogPictureBox3 = new System.Windows.Forms.PictureBox();
            this.rightFrogPictureBox4 = new System.Windows.Forms.PictureBox();
            this.movesNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // leftFrogPictureBox1
            // 
            this.leftFrogPictureBox1.Image = global::FrogsWinFormsApp.Properties.Resources.left_frog;
            this.leftFrogPictureBox1.Location = new System.Drawing.Point(0, 33);
            this.leftFrogPictureBox1.Name = "leftFrogPictureBox1";
            this.leftFrogPictureBox1.Size = new System.Drawing.Size(110, 110);
            this.leftFrogPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftFrogPictureBox1.TabIndex = 0;
            this.leftFrogPictureBox1.TabStop = false;
            this.leftFrogPictureBox1.Tag = "leftFrog";
            this.leftFrogPictureBox1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьСНачалаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // начатьСНачалаToolStripMenuItem
            // 
            this.начатьСНачалаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.начатьСНачалаToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.начатьСНачалаToolStripMenuItem.Name = "начатьСНачалаToolStripMenuItem";
            this.начатьСНачалаToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.начатьСНачалаToolStripMenuItem.Text = "Файл";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // начатьСНачалаToolStripMenuItem1
            // 
            this.начатьСНачалаToolStripMenuItem1.Name = "начатьСНачалаToolStripMenuItem1";
            this.начатьСНачалаToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.начатьСНачалаToolStripMenuItem1.Text = "Начать с начала";
            this.начатьСНачалаToolStripMenuItem1.Click += new System.EventHandler(this.начатьСНачалаToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // leftFrogPictureBox2
            // 
            this.leftFrogPictureBox2.Image = global::FrogsWinFormsApp.Properties.Resources.left_frog;
            this.leftFrogPictureBox2.Location = new System.Drawing.Point(110, 33);
            this.leftFrogPictureBox2.Name = "leftFrogPictureBox2";
            this.leftFrogPictureBox2.Size = new System.Drawing.Size(110, 110);
            this.leftFrogPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftFrogPictureBox2.TabIndex = 2;
            this.leftFrogPictureBox2.TabStop = false;
            this.leftFrogPictureBox2.Tag = "leftFrog";
            this.leftFrogPictureBox2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // leftFrogPictureBox3
            // 
            this.leftFrogPictureBox3.Image = global::FrogsWinFormsApp.Properties.Resources.left_frog;
            this.leftFrogPictureBox3.Location = new System.Drawing.Point(220, 33);
            this.leftFrogPictureBox3.Name = "leftFrogPictureBox3";
            this.leftFrogPictureBox3.Size = new System.Drawing.Size(110, 110);
            this.leftFrogPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftFrogPictureBox3.TabIndex = 3;
            this.leftFrogPictureBox3.TabStop = false;
            this.leftFrogPictureBox3.Tag = "leftFrog";
            this.leftFrogPictureBox3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // leftFrogPictureBox4
            // 
            this.leftFrogPictureBox4.Image = global::FrogsWinFormsApp.Properties.Resources.left_frog;
            this.leftFrogPictureBox4.Location = new System.Drawing.Point(330, 33);
            this.leftFrogPictureBox4.Name = "leftFrogPictureBox4";
            this.leftFrogPictureBox4.Size = new System.Drawing.Size(110, 110);
            this.leftFrogPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftFrogPictureBox4.TabIndex = 4;
            this.leftFrogPictureBox4.TabStop = false;
            this.leftFrogPictureBox4.Tag = "leftFrog";
            this.leftFrogPictureBox4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // emptyPictureBox
            // 
            this.emptyPictureBox.Image = global::FrogsWinFormsApp.Properties.Resources.empty_leaf;
            this.emptyPictureBox.Location = new System.Drawing.Point(440, 33);
            this.emptyPictureBox.Name = "emptyPictureBox";
            this.emptyPictureBox.Size = new System.Drawing.Size(110, 110);
            this.emptyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyPictureBox.TabIndex = 5;
            this.emptyPictureBox.TabStop = false;
            this.emptyPictureBox.Tag = "emptyLeaf";
            this.emptyPictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // rightFrogPictureBox1
            // 
            this.rightFrogPictureBox1.Image = global::FrogsWinFormsApp.Properties.Resources.right_frog;
            this.rightFrogPictureBox1.Location = new System.Drawing.Point(550, 33);
            this.rightFrogPictureBox1.Name = "rightFrogPictureBox1";
            this.rightFrogPictureBox1.Size = new System.Drawing.Size(110, 110);
            this.rightFrogPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightFrogPictureBox1.TabIndex = 6;
            this.rightFrogPictureBox1.TabStop = false;
            this.rightFrogPictureBox1.Tag = "rightFrog";
            this.rightFrogPictureBox1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // rightFrogPictureBox2
            // 
            this.rightFrogPictureBox2.Image = global::FrogsWinFormsApp.Properties.Resources.right_frog;
            this.rightFrogPictureBox2.Location = new System.Drawing.Point(660, 33);
            this.rightFrogPictureBox2.Name = "rightFrogPictureBox2";
            this.rightFrogPictureBox2.Size = new System.Drawing.Size(110, 110);
            this.rightFrogPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightFrogPictureBox2.TabIndex = 7;
            this.rightFrogPictureBox2.TabStop = false;
            this.rightFrogPictureBox2.Tag = "rightFrog";
            this.rightFrogPictureBox2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // rightFrogPictureBox3
            // 
            this.rightFrogPictureBox3.Image = global::FrogsWinFormsApp.Properties.Resources.right_frog;
            this.rightFrogPictureBox3.Location = new System.Drawing.Point(770, 33);
            this.rightFrogPictureBox3.Name = "rightFrogPictureBox3";
            this.rightFrogPictureBox3.Size = new System.Drawing.Size(110, 110);
            this.rightFrogPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightFrogPictureBox3.TabIndex = 8;
            this.rightFrogPictureBox3.TabStop = false;
            this.rightFrogPictureBox3.Tag = "rightFrog";
            this.rightFrogPictureBox3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // rightFrogPictureBox4
            // 
            this.rightFrogPictureBox4.Image = global::FrogsWinFormsApp.Properties.Resources.right_frog;
            this.rightFrogPictureBox4.Location = new System.Drawing.Point(880, 33);
            this.rightFrogPictureBox4.Name = "rightFrogPictureBox4";
            this.rightFrogPictureBox4.Size = new System.Drawing.Size(110, 110);
            this.rightFrogPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightFrogPictureBox4.TabIndex = 9;
            this.rightFrogPictureBox4.TabStop = false;
            this.rightFrogPictureBox4.Tag = "rightFrog";
            this.rightFrogPictureBox4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // movesNumberLabel
            // 
            this.movesNumberLabel.AutoSize = true;
            this.movesNumberLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movesNumberLabel.Location = new System.Drawing.Point(12, 156);
            this.movesNumberLabel.Name = "movesNumberLabel";
            this.movesNumberLabel.Size = new System.Drawing.Size(194, 22);
            this.movesNumberLabel.TabIndex = 10;
            this.movesNumberLabel.Text = "Количество ходов: ";
            // 
            // FrogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 223);
            this.Controls.Add(this.movesNumberLabel);
            this.Controls.Add(this.rightFrogPictureBox4);
            this.Controls.Add(this.rightFrogPictureBox3);
            this.Controls.Add(this.rightFrogPictureBox2);
            this.Controls.Add(this.rightFrogPictureBox1);
            this.Controls.Add(this.emptyPictureBox);
            this.Controls.Add(this.leftFrogPictureBox4);
            this.Controls.Add(this.leftFrogPictureBox3);
            this.Controls.Add(this.leftFrogPictureBox2);
            this.Controls.Add(this.leftFrogPictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лягушки";
            this.Click += new System.EventHandler(this.PictureBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftFrogPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFrogPictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox leftFrogPictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem начатьСНачалаToolStripMenuItem;
        private ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private PictureBox leftFrogPictureBox2;
        private PictureBox leftFrogPictureBox3;
        private PictureBox leftFrogPictureBox4;
        private PictureBox emptyPictureBox;
        private PictureBox rightFrogPictureBox1;
        private PictureBox rightFrogPictureBox2;
        private PictureBox rightFrogPictureBox3;
        private PictureBox rightFrogPictureBox4;
        private Label movesNumberLabel;
        private ToolStripMenuItem начатьСНачалаToolStripMenuItem1;
    }
}