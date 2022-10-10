
namespace JoppesDjurfamilj
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
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.Lek = new System.Windows.Forms.Button();
            this.Mata = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(386, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Joppes djurfamilj";
            // 
            // lista
            // 
            this.lista.AccessibleDescription = "list_click";
            this.lista.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lista.Location = new System.Drawing.Point(67, 170);
            this.lista.Margin = new System.Windows.Forms.Padding(4);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(188, 58);
            this.lista.TabIndex = 2;
            this.lista.Text = "Skriv ut lista på djur";
            this.lista.UseVisualStyleBackColor = true;
            this.lista.Click += new System.EventHandler(this.list_click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "interact_click";
            this.button3.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(67, 250);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Välj djur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.play_click);
            // 
            // output
            // 
            this.output.AccessibleDescription = "output";
            this.output.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(386, 170);
            this.output.Margin = new System.Windows.Forms.Padding(4);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(360, 171);
            this.output.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "joppe_click";
            this.button4.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(67, 411);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 58);
            this.button4.TabIndex = 5;
            this.button4.Text = "Om Joppe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.om_joppe_click);
            // 
            // button5
            // 
            this.button5.AccessibleDescription = "boll_click";
            this.button5.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(67, 330);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 58);
            this.button5.TabIndex = 6;
            this.button5.Text = "Joppes boll";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.boll_click);
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "quit_click";
            this.button6.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(67, 497);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 58);
            this.button6.TabIndex = 7;
            this.button6.Text = "Avsluta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.quit_click);
            // 
            // input
            // 
            this.input.AccessibleDescription = "input";
            this.input.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.input.Location = new System.Drawing.Point(386, 411);
            this.input.Margin = new System.Windows.Forms.Padding(4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(360, 26);
            this.input.TabIndex = 8;
            // 
            // Lek
            // 
            this.Lek.AccessibleDescription = "lek_click";
            this.Lek.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lek.Location = new System.Drawing.Point(386, 497);
            this.Lek.Margin = new System.Windows.Forms.Padding(4);
            this.Lek.Name = "Lek";
            this.Lek.Size = new System.Drawing.Size(132, 56);
            this.Lek.TabIndex = 9;
            this.Lek.Text = "Lek";
            this.Lek.UseVisualStyleBackColor = true;
            this.Lek.Click += new System.EventHandler(this.ok_click);
            // 
            // Mata
            // 
            this.Mata.AccessibleDescription = "mata_click";
            this.Mata.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mata.Location = new System.Drawing.Point(614, 497);
            this.Mata.Margin = new System.Windows.Forms.Padding(4);
            this.Mata.Name = "Mata";
            this.Mata.Size = new System.Drawing.Size(132, 56);
            this.Mata.TabIndex = 10;
            this.Mata.Text = "Mata";
            this.Mata.UseVisualStyleBackColor = true;
            this.Mata.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(419, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ange djur som Joppe ska umgås med";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vad ska Joppe göra med sitt djur?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 840);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mata);
            this.Controls.Add(this.Lek);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lista;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button Lek;
        private System.Windows.Forms.Button Mata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

