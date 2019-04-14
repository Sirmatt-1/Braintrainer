namespace Braintrainer
{
    partial class Braintrainer
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
            this.btnColourGame = new System.Windows.Forms.Button();
            this.btnColourInstructions = new System.Windows.Forms.Button();
            this.btnNumberGame = new System.Windows.Forms.Button();
            this.btnNumberInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Braintrainer";
            // 
            // btnColourGame
            // 
            this.btnColourGame.BackColor = System.Drawing.Color.White;
            this.btnColourGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColourGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColourGame.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnColourGame.Location = new System.Drawing.Point(12, 307);
            this.btnColourGame.Name = "btnColourGame";
            this.btnColourGame.Size = new System.Drawing.Size(353, 84);
            this.btnColourGame.TabIndex = 1;
            this.btnColourGame.Tag = "colour";
            this.btnColourGame.Text = "Colour game";
            this.btnColourGame.UseVisualStyleBackColor = false;
            this.btnColourGame.Click += new System.EventHandler(this.gameClick);
            // 
            // btnColourInstructions
            // 
            this.btnColourInstructions.BackColor = System.Drawing.Color.White;
            this.btnColourInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColourInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColourInstructions.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnColourInstructions.Location = new System.Drawing.Point(12, 397);
            this.btnColourInstructions.Name = "btnColourInstructions";
            this.btnColourInstructions.Size = new System.Drawing.Size(353, 41);
            this.btnColourInstructions.TabIndex = 2;
            this.btnColourInstructions.Tag = "colour";
            this.btnColourInstructions.Text = "Instructions";
            this.btnColourInstructions.UseVisualStyleBackColor = false;
            this.btnColourInstructions.Click += new System.EventHandler(this.instructionClick);
            // 
            // btnNumberGame
            // 
            this.btnNumberGame.BackColor = System.Drawing.Color.White;
            this.btnNumberGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberGame.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNumberGame.Location = new System.Drawing.Point(435, 307);
            this.btnNumberGame.Name = "btnNumberGame";
            this.btnNumberGame.Size = new System.Drawing.Size(353, 84);
            this.btnNumberGame.TabIndex = 3;
            this.btnNumberGame.Tag = "number";
            this.btnNumberGame.Text = "Number game";
            this.btnNumberGame.UseVisualStyleBackColor = false;
            this.btnNumberGame.Click += new System.EventHandler(this.gameClick);
            // 
            // btnNumberInstructions
            // 
            this.btnNumberInstructions.BackColor = System.Drawing.Color.White;
            this.btnNumberInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberInstructions.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNumberInstructions.Location = new System.Drawing.Point(435, 397);
            this.btnNumberInstructions.Name = "btnNumberInstructions";
            this.btnNumberInstructions.Size = new System.Drawing.Size(353, 41);
            this.btnNumberInstructions.TabIndex = 4;
            this.btnNumberInstructions.Tag = "number";
            this.btnNumberInstructions.Text = "Instructions";
            this.btnNumberInstructions.UseVisualStyleBackColor = false;
            this.btnNumberInstructions.Click += new System.EventHandler(this.instructionClick);
            // 
            // Braintrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNumberInstructions);
            this.Controls.Add(this.btnNumberGame);
            this.Controls.Add(this.btnColourInstructions);
            this.Controls.Add(this.btnColourGame);
            this.Controls.Add(this.label1);
            this.Name = "Braintrainer";
            this.Text = "Braintrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColourGame;
        private System.Windows.Forms.Button btnColourInstructions;
        private System.Windows.Forms.Button btnNumberGame;
        private System.Windows.Forms.Button btnNumberInstructions;
    }
}

