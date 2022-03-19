namespace WindowsFormsApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.studenciListBox = new System.Windows.Forms.ListBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2463, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1148, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(413, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(632, 253);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(150, 31);
            this.nazwiskoTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 154);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dodaj studenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studenciListBox
            // 
            this.studenciListBox.FormattingEnabled = true;
            this.studenciListBox.ItemHeight = 25;
            this.studenciListBox.Location = new System.Drawing.Point(1115, 90);
            this.studenciListBox.Name = "studenciListBox";
            this.studenciListBox.Size = new System.Drawing.Size(392, 379);
            this.studenciListBox.TabIndex = 8;
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(632, 193);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(150, 31);
            this.imieTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(413, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 60);
            this.label3.TabIndex = 13;
            this.label3.Text = "Imie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2463, 903);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.studenciListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lista studentów";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox nazwiskoTextBox;
        private Button button2;
        private ListBox studenciListBox;
        private TextBox imieTextBox;
        private Label label3;
    }
}