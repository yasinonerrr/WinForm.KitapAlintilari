namespace WinForm.KitapAlintilari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.BackColor = Color.White;
            listBox1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(90, 89);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(448, 364);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(109, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(359, 32);
            label1.TabIndex = 1;
            label1.Text = "KİTAP VE ALINTI LİSTESİ";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.Location = new Point(573, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 54);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.Location = new Point(737, 376);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(127, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.Location = new Point(910, 376);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(114, 54);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(866, 491);
            button1.Name = "button1";
            button1.Size = new Size(234, 46);
            button1.TabIndex = 7;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(573, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(451, 252);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(682, 9);
            label3.Name = "label3";
            label3.Size = new Size(284, 32);
            label3.TabIndex = 9;
            label3.Text = "KAYIT VE DÜZENLEME";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(511, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1112, 540);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Alıntıları";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}