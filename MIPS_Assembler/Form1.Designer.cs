namespace MIPS_Assembler
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox_MIPS = new System.Windows.Forms.RichTextBox();
            this.richTextBox_cod_maq = new System.Windows.Forms.RichTextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_sep = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDoMifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirmifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_comentarios = new System.Windows.Forms.RichTextBox();
            this.pictureBox_convert = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog_mif = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_convert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_MIPS
            // 
            this.richTextBox_MIPS.Location = new System.Drawing.Point(289, 56);
            this.richTextBox_MIPS.Name = "richTextBox_MIPS";
            this.richTextBox_MIPS.Size = new System.Drawing.Size(117, 595);
            this.richTextBox_MIPS.TabIndex = 0;
            this.richTextBox_MIPS.Text = "ADD $1, $2, $3\nSUB $1, $2, $3\nAND $1, $2, $3\nOR $1, $2, $3\nSLT $1, $2, $3\nLW $1, " +
    "5($2) \nSW $1, 5($2)\nBEQ $1, $2, 5\nADDi $1, $2, 5\nJ 5";
            // 
            // richTextBox_cod_maq
            // 
            this.richTextBox_cod_maq.Location = new System.Drawing.Point(412, 56);
            this.richTextBox_cod_maq.Name = "richTextBox_cod_maq";
            this.richTextBox_cod_maq.ReadOnly = true;
            this.richTextBox_cod_maq.Size = new System.Drawing.Size(238, 595);
            this.richTextBox_cod_maq.TabIndex = 1;
            this.richTextBox_cod_maq.Text = "";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(13, 30);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(249, 20);
            this.textBox_Status.TabIndex = 3;
            this.textBox_Status.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assembly MIPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código de Máquina";
            // 
            // checkBox_sep
            // 
            this.checkBox_sep.AutoSize = true;
            this.checkBox_sep.Location = new System.Drawing.Point(582, 36);
            this.checkBox_sep.Name = "checkBox_sep";
            this.checkBox_sep.Size = new System.Drawing.Size(32, 17);
            this.checkBox_sep.TabIndex = 6;
            this.checkBox_sep.Text = "_";
            this.checkBox_sep.UseVisualStyleBackColor = true;
            this.checkBox_sep.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirmifToolStripMenuItem,
            this.converterToolStripMenuItem,
            this.configuraçõesDoMifToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.converterToolStripMenuItem.Text = "Converter";
            this.converterToolStripMenuItem.Click += new System.EventHandler(this.converterToolStripMenuItem_Click);
            // 
            // configuraçõesDoMifToolStripMenuItem
            // 
            this.configuraçõesDoMifToolStripMenuItem.Name = "configuraçõesDoMifToolStripMenuItem";
            this.configuraçõesDoMifToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.configuraçõesDoMifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuraçõesDoMifToolStripMenuItem.Text = "Configurações ";
            this.configuraçõesDoMifToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesDoMifToolStripMenuItem_Click);
            // 
            // abrirmifToolStripMenuItem
            // 
            this.abrirmifToolStripMenuItem.Name = "abrirmifToolStripMenuItem";
            this.abrirmifToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.abrirmifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirmifToolStripMenuItem.Text = "Abrir";
            this.abrirmifToolStripMenuItem.Click += new System.EventHandler(this.abrirmifToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(268, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(21, 595);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "00\n01\n02\n03\n04\n05\n06\n07\n08\n09\n0A\n0B\n0C\n0D\n0E\n0F\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n1A\n" +
    "1B\n1C\n1D\n1E\n1F\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n3A\n3B\n3C";
            // 
            // richTextBox_comentarios
            // 
            this.richTextBox_comentarios.EnableAutoDragDrop = true;
            this.richTextBox_comentarios.Location = new System.Drawing.Point(13, 56);
            this.richTextBox_comentarios.Name = "richTextBox_comentarios";
            this.richTextBox_comentarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_comentarios.Size = new System.Drawing.Size(249, 557);
            this.richTextBox_comentarios.TabIndex = 9;
            this.richTextBox_comentarios.Text = "Comentários";
            // 
            // pictureBox_convert
            // 
            this.pictureBox_convert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_convert.Image = global::MIPS_Assembler.Properties.Resources.refresh_icon_8;
            this.pictureBox_convert.Location = new System.Drawing.Point(620, 23);
            this.pictureBox_convert.Name = "pictureBox_convert";
            this.pictureBox_convert.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_convert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_convert.TabIndex = 15;
            this.pictureBox_convert.TabStop = false;
            this.pictureBox_convert.Click += new System.EventHandler(this.converterToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MIPS_Assembler.Properties.Resources.download__1_;
            this.pictureBox3.Location = new System.Drawing.Point(219, 619);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MIPS_Assembler.Properties.Resources.UFCG_lateral;
            this.pictureBox2.Location = new System.Drawing.Point(99, 619);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MIPS_Assembler.Properties.Resources.rafael_logo_retangulo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 619);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog_mif
            // 
            this.openFileDialog_mif.FileName = "openFileDialog1";
            this.openFileDialog_mif.Filter = "MIF (*.mif)|*.mif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 655);
            this.Controls.Add(this.pictureBox_convert);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox_comentarios);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox_sep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.richTextBox_cod_maq);
            this.Controls.Add(this.richTextBox_MIPS);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MIPS Assembler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_convert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_MIPS;
        private System.Windows.Forms.RichTextBox richTextBox_cod_maq;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_sep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDoMifToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox_comentarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_convert;
        private System.Windows.Forms.ToolStripMenuItem abrirmifToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog_mif;
    }
}

