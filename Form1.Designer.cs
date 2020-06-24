namespace MyDiceRoller
{
    partial class DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRoller));
            this.buttonRoll = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.NumbDices = new System.Windows.Forms.TextBox();
            this.NumbSides = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonRoll.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRoll.Location = new System.Drawing.Point(12, 267);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(258, 52);
            this.buttonRoll.TabIndex = 0;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = false;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Tahoma", 64F, System.Drawing.FontStyle.Bold);
            this.labelResult.Location = new System.Drawing.Point(12, 9);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(258, 92);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "0";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumbDices
            // 
            this.NumbDices.Font = new System.Drawing.Font("Tahoma", 8F);
            this.NumbDices.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NumbDices.Location = new System.Drawing.Point(12, 224);
            this.NumbDices.Name = "NumbDices";
            this.NumbDices.Size = new System.Drawing.Size(110, 20);
            this.NumbDices.TabIndex = 2;
            this.NumbDices.Text = "write number of dice";
            this.NumbDices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumbDices.Enter += new System.EventHandler(this.EnterOrLeaveNumbDices);
            this.NumbDices.Leave += new System.EventHandler(this.EnterOrLeaveNumbDices);
            // 
            // NumbSides
            // 
            this.NumbSides.Font = new System.Drawing.Font("Tahoma", 8F);
            this.NumbSides.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NumbSides.Location = new System.Drawing.Point(160, 224);
            this.NumbSides.Name = "NumbSides";
            this.NumbSides.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumbSides.Size = new System.Drawing.Size(110, 20);
            this.NumbSides.TabIndex = 2;
            this.NumbSides.Text = "write number of sides";
            this.NumbSides.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumbSides.Enter += new System.EventHandler(this.EnterOrLeaveNumbSides);
            this.NumbSides.Leave += new System.EventHandler(this.EnterOrLeaveNumbSides);
            // 
            // labelD
            // 
            this.labelD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelD.Location = new System.Drawing.Point(125, 227);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(32, 19);
            this.labelD.TabIndex = 1;
            this.labelD.Text = "d";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoEllipsis = true;
            this.labelNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumbers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNumbers.Location = new System.Drawing.Point(12, 113);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(258, 90);
            this.labelNumbers.TabIndex = 3;
            this.labelNumbers.Text = "your rolls are here";
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(282, 335);
            this.Controls.Add(this.labelNumbers);
            this.Controls.Add(this.NumbSides);
            this.Controls.Add(this.NumbDices);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRoll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiceRoller";
            this.Text = "MaxTRU\'s DiceRoller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox NumbDices;
        private System.Windows.Forms.TextBox NumbSides;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelNumbers;
    }
}

