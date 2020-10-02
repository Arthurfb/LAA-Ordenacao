namespace LAA_M.E
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
            this.labelConjunto = new System.Windows.Forms.Label();
            this.textConjunto = new System.Windows.Forms.TextBox();
            this.radioInsertion = new System.Windows.Forms.RadioButton();
            this.radioBubble = new System.Windows.Forms.RadioButton();
            this.radioSelection = new System.Windows.Forms.RadioButton();
            this.radioOutro = new System.Windows.Forms.RadioButton();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.labelValores = new System.Windows.Forms.Label();
            this.labelTempo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelConjunto
            // 
            this.labelConjunto.AutoSize = true;
            this.labelConjunto.Location = new System.Drawing.Point(36, 49);
            this.labelConjunto.Name = "labelConjunto";
            this.labelConjunto.Size = new System.Drawing.Size(112, 13);
            this.labelConjunto.TabIndex = 0;
            this.labelConjunto.Text = "Conjunto de Números:";
            this.labelConjunto.Click += new System.EventHandler(this.label1_Click);
            // 
            // textConjunto
            // 
            this.textConjunto.Location = new System.Drawing.Point(155, 49);
            this.textConjunto.Name = "textConjunto";
            this.textConjunto.Size = new System.Drawing.Size(253, 20);
            this.textConjunto.TabIndex = 1;
            // 
            // radioInsertion
            // 
            this.radioInsertion.AutoSize = true;
            this.radioInsertion.Location = new System.Drawing.Point(6, 19);
            this.radioInsertion.Name = "radioInsertion";
            this.radioInsertion.Size = new System.Drawing.Size(65, 17);
            this.radioInsertion.TabIndex = 2;
            this.radioInsertion.TabStop = true;
            this.radioInsertion.Text = "Insertion";
            this.radioInsertion.UseVisualStyleBackColor = true;
            this.radioInsertion.CheckedChanged += new System.EventHandler(this.radioInsertion_CheckedChanged);
            // 
            // radioBubble
            // 
            this.radioBubble.AutoSize = true;
            this.radioBubble.Location = new System.Drawing.Point(6, 42);
            this.radioBubble.Name = "radioBubble";
            this.radioBubble.Size = new System.Drawing.Size(58, 17);
            this.radioBubble.TabIndex = 3;
            this.radioBubble.TabStop = true;
            this.radioBubble.Text = "Bubble";
            this.radioBubble.UseVisualStyleBackColor = true;
            // 
            // radioSelection
            // 
            this.radioSelection.AutoSize = true;
            this.radioSelection.Location = new System.Drawing.Point(6, 65);
            this.radioSelection.Name = "radioSelection";
            this.radioSelection.Size = new System.Drawing.Size(69, 17);
            this.radioSelection.TabIndex = 4;
            this.radioSelection.TabStop = true;
            this.radioSelection.Text = "Selection";
            this.radioSelection.UseVisualStyleBackColor = true;
            // 
            // radioOutro
            // 
            this.radioOutro.AutoSize = true;
            this.radioOutro.Location = new System.Drawing.Point(6, 88);
            this.radioOutro.Name = "radioOutro";
            this.radioOutro.Size = new System.Drawing.Size(72, 17);
            this.radioOutro.TabIndex = 5;
            this.radioOutro.TabStop = true;
            this.radioOutro.Text = "[um outro]";
            this.radioOutro.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(242, 165);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(125, 41);
            this.buttonOrdenar.TabIndex = 6;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // labelValores
            // 
            this.labelValores.AutoSize = true;
            this.labelValores.Location = new System.Drawing.Point(87, 241);
            this.labelValores.Name = "labelValores";
            this.labelValores.Size = new System.Drawing.Size(35, 13);
            this.labelValores.TabIndex = 7;
            this.labelValores.Text = "label1";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(238, 241);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(35, 13);
            this.labelTempo.TabIndex = 8;
            this.labelTempo.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBubble);
            this.groupBox1.Controls.Add(this.radioSelection);
            this.groupBox1.Controls.Add(this.radioOutro);
            this.groupBox1.Controls.Add(this.radioInsertion);
            this.groupBox1.Location = new System.Drawing.Point(90, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 114);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método de Ordenação";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.labelValores);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.textConjunto);
            this.Controls.Add(this.labelConjunto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConjunto;
        private System.Windows.Forms.TextBox textConjunto;
        private System.Windows.Forms.RadioButton radioInsertion;
        private System.Windows.Forms.RadioButton radioBubble;
        private System.Windows.Forms.RadioButton radioSelection;
        private System.Windows.Forms.RadioButton radioOutro;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Label labelValores;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

