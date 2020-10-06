namespace SrDice
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.chkRuleOfSix = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.lblCurrentMode = new System.Windows.Forms.Label();
            this.nudNumberOfDice = new System.Windows.Forms.NumericUpDown();
            this.nudTargetNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter # of d6 to roll:";
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(16, 266);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(4);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(133, 28);
            this.btnRollDice.TabIndex = 4;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.BtnRollDice_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(176, 15);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(185, 294);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TabStop = false;
            this.txtOutput.Text = resources.GetString("txtOutput.Text");
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(16, 193);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(108, 17);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "Target Number:";
            // 
            // chkRuleOfSix
            // 
            this.chkRuleOfSix.AutoSize = true;
            this.chkRuleOfSix.Location = new System.Drawing.Point(35, 156);
            this.chkRuleOfSix.Margin = new System.Windows.Forms.Padding(4);
            this.chkRuleOfSix.Name = "chkRuleOfSix";
            this.chkRuleOfSix.Size = new System.Drawing.Size(97, 21);
            this.chkRuleOfSix.TabIndex = 2;
            this.chkRuleOfSix.Text = "Rule of Six";
            this.chkRuleOfSix.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "MODE: ";
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Location = new System.Drawing.Point(16, 21);
            this.btnChangeMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(133, 28);
            this.btnChangeMode.TabIndex = 0;
            this.btnChangeMode.Text = "Change Mode";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.BtnChangeMode_Click);
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.AutoSize = true;
            this.lblCurrentMode.Location = new System.Drawing.Point(100, 53);
            this.lblCurrentMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(35, 17);
            this.lblCurrentMode.TabIndex = 10;
            this.lblCurrentMode.Text = "SR3";
            // 
            // nudNumberOfDice
            // 
            this.nudNumberOfDice.Location = new System.Drawing.Point(16, 112);
            this.nudNumberOfDice.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudNumberOfDice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfDice.Name = "nudNumberOfDice";
            this.nudNumberOfDice.Size = new System.Drawing.Size(133, 22);
            this.nudNumberOfDice.TabIndex = 1;
            this.nudNumberOfDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTargetNumber
            // 
            this.nudTargetNumber.Location = new System.Drawing.Point(16, 213);
            this.nudTargetNumber.Name = "nudTargetNumber";
            this.nudTargetNumber.Size = new System.Drawing.Size(133, 22);
            this.nudTargetNumber.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRollDice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 325);
            this.Controls.Add(this.nudTargetNumber);
            this.Controls.Add(this.nudNumberOfDice);
            this.Controls.Add(this.lblCurrentMode);
            this.Controls.Add(this.btnChangeMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkRuleOfSix);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(397, 372);
            this.Name = "Form1";
            this.Text = "Shadowrun Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.CheckBox chkRuleOfSix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeMode;
        private System.Windows.Forms.Label lblCurrentMode;
        private System.Windows.Forms.NumericUpDown nudNumberOfDice;
        private System.Windows.Forms.NumericUpDown nudTargetNumber;
    }
}

