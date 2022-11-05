
namespace praca_filmy
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tytulTxt = new System.Windows.Forms.TextBox();
            this.RezyserTxt = new System.Windows.Forms.TextBox();
            this.AktorTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuńWybraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zastąpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderTytul = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRezyser = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderData = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAktor = new System.Windows.Forms.ColumnHeader();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tytulTxt
            // 
            this.tytulTxt.Location = new System.Drawing.Point(141, 63);
            this.tytulTxt.Name = "tytulTxt";
            this.tytulTxt.Size = new System.Drawing.Size(100, 23);
            this.tytulTxt.TabIndex = 0;
            // 
            // RezyserTxt
            // 
            this.RezyserTxt.Location = new System.Drawing.Point(141, 123);
            this.RezyserTxt.Name = "RezyserTxt";
            this.RezyserTxt.Size = new System.Drawing.Size(100, 23);
            this.RezyserTxt.TabIndex = 2;
            // 
            // AktorTxt
            // 
            this.AktorTxt.Location = new System.Drawing.Point(365, 123);
            this.AktorTxt.Name = "AktorTxt";
            this.AktorTxt.Size = new System.Drawing.Size(100, 23);
            this.AktorTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reżyser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aktor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Wczytaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńWybraneToolStripMenuItem,
            this.zastąpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // usuńWybraneToolStripMenuItem
            // 
            this.usuńWybraneToolStripMenuItem.Name = "usuńWybraneToolStripMenuItem";
            this.usuńWybraneToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.usuńWybraneToolStripMenuItem.Text = "Usuń Wybrane";
            this.usuńWybraneToolStripMenuItem.Click += new System.EventHandler(this.usuńWybraneToolStripMenuItem_Click);
            // 
            // zastąpToolStripMenuItem
            // 
            this.zastąpToolStripMenuItem.Name = "zastąpToolStripMenuItem";
            this.zastąpToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zastąpToolStripMenuItem.Text = "Zastąp";
            this.zastąpToolStripMenuItem.Click += new System.EventHandler(this.zastąpToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTytul,
            this.columnHeaderRezyser,
            this.columnHeaderData,
            this.columnHeaderAktor});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 236);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTytul
            // 
            this.columnHeaderTytul.Text = "Tytuł";
            this.columnHeaderTytul.Width = 120;
            // 
            // columnHeaderRezyser
            // 
            this.columnHeaderRezyser.Text = "Reżyser";
            this.columnHeaderRezyser.Width = 120;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data Wydania";
            this.columnHeaderData.Width = 120;
            // 
            // columnHeaderAktor
            // 
            this.columnHeaderAktor.Text = "Aktor";
            this.columnHeaderAktor.Width = 120;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "wyjdź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(591, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Zastąp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AktorTxt);
            this.Controls.Add(this.RezyserTxt);
            this.Controls.Add(this.tytulTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tytulTxt;
        private System.Windows.Forms.TextBox RezyserTxt;
        private System.Windows.Forms.TextBox AktorTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuńWybraneToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTytul;
        private System.Windows.Forms.ColumnHeader columnHeaderRezyser;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderAktor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem zastąpToolStripMenuItem;
        private System.Windows.Forms.Button button4;
    }
}

