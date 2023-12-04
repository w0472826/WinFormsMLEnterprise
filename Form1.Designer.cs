namespace WinFormsMLEnterprise
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
            btnGuess = new Button();
            txtGuess = new TextBox();
            txtConfidence = new TextBox();
            lblGuess = new Label();
            lblConfidence = new Label();
            lblFeedback = new Label();
            txtReview = new TextBox();
            lblOriginalWeight = new Label();
            lblReTrainedWeight = new Label();
            lblWeightDiffs = new Label();
            txtOriginalWeight = new TextBox();
            txtReTrainedWeight = new TextBox();
            txtWeightDiffs = new TextBox();
            comboBoxLabel = new ComboBox();
            btnRetrain = new Button();
            SuspendLayout();
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(88, 154);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(94, 29);
            btnGuess.TabIndex = 0;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(429, 156);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 27);
            txtGuess.TabIndex = 1;
            // 
            // txtConfidence
            // 
            txtConfidence.Location = new Point(429, 214);
            txtConfidence.Name = "txtConfidence";
            txtConfidence.Size = new Size(125, 27);
            txtConfidence.TabIndex = 2;
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Location = new Point(302, 158);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(50, 20);
            lblGuess.TabIndex = 3;
            lblGuess.Text = "Guess:";
            // 
            // lblConfidence
            // 
            lblConfidence.AutoSize = true;
            lblConfidence.Location = new Point(302, 214);
            lblConfidence.Name = "lblConfidence";
            lblConfidence.Size = new Size(87, 20);
            lblConfidence.TabIndex = 4;
            lblConfidence.Text = "Confidence:";
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(95, 69);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(75, 20);
            lblFeedback.TabIndex = 5;
            lblFeedback.Text = "Feedback:";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(227, 62);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(430, 27);
            txtReview.TabIndex = 6;
            // 
            // lblOriginalWeight
            // 
            lblOriginalWeight.AutoSize = true;
            lblOriginalWeight.Location = new Point(302, 274);
            lblOriginalWeight.Name = "lblOriginalWeight";
            lblOriginalWeight.Size = new Size(116, 20);
            lblOriginalWeight.TabIndex = 7;
            lblOriginalWeight.Text = "Original Weight:";
            // 
            // lblReTrainedWeight
            // 
            lblReTrainedWeight.AutoSize = true;
            lblReTrainedWeight.Location = new Point(302, 322);
            lblReTrainedWeight.Name = "lblReTrainedWeight";
            lblReTrainedWeight.Size = new Size(129, 20);
            lblReTrainedWeight.TabIndex = 8;
            lblReTrainedWeight.Text = "ReTrained Weight:";
            // 
            // lblWeightDiffs
            // 
            lblWeightDiffs.AutoSize = true;
            lblWeightDiffs.Location = new Point(302, 365);
            lblWeightDiffs.Name = "lblWeightDiffs";
            lblWeightDiffs.Size = new Size(91, 20);
            lblWeightDiffs.TabIndex = 9;
            lblWeightDiffs.Text = "Weight Diffs";
            // 
            // txtOriginalWeight
            // 
            txtOriginalWeight.Location = new Point(483, 271);
            txtOriginalWeight.Name = "txtOriginalWeight";
            txtOriginalWeight.Size = new Size(125, 27);
            txtOriginalWeight.TabIndex = 10;
            // 
            // txtReTrainedWeight
            // 
            txtReTrainedWeight.Location = new Point(483, 319);
            txtReTrainedWeight.Name = "txtReTrainedWeight";
            txtReTrainedWeight.Size = new Size(125, 27);
            txtReTrainedWeight.TabIndex = 11;
            // 
            // txtWeightDiffs
            // 
            txtWeightDiffs.Location = new Point(483, 365);
            txtWeightDiffs.Name = "txtWeightDiffs";
            txtWeightDiffs.Size = new Size(125, 27);
            txtWeightDiffs.TabIndex = 12;
            // 
            // comboBoxLabel
            // 
            comboBoxLabel.FormattingEnabled = true;
            comboBoxLabel.Items.AddRange(new object[] { "Col 0", "Col 1" });
            comboBoxLabel.Location = new Point(88, 214);
            comboBoxLabel.Name = "comboBoxLabel";
            comboBoxLabel.Size = new Size(151, 28);
            comboBoxLabel.TabIndex = 13;
            // 
            // btnRetrain
            // 
            btnRetrain.Location = new Point(88, 274);
            btnRetrain.Name = "btnRetrain";
            btnRetrain.Size = new Size(94, 29);
            btnRetrain.TabIndex = 14;
            btnRetrain.Text = "Retrain";
            btnRetrain.UseVisualStyleBackColor = true;
            btnRetrain.Click += btnRetrain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetrain);
            Controls.Add(comboBoxLabel);
            Controls.Add(txtWeightDiffs);
            Controls.Add(txtReTrainedWeight);
            Controls.Add(txtOriginalWeight);
            Controls.Add(lblWeightDiffs);
            Controls.Add(lblReTrainedWeight);
            Controls.Add(lblOriginalWeight);
            Controls.Add(txtReview);
            Controls.Add(lblFeedback);
            Controls.Add(lblConfidence);
            Controls.Add(lblGuess);
            Controls.Add(txtConfidence);
            Controls.Add(txtGuess);
            Controls.Add(btnGuess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuess;
        private TextBox txtGuess;
        private TextBox txtConfidence;
        private Label lblGuess;
        private Label lblConfidence;
        private Label lblFeedback;
        private TextBox txtReview;
        private Label lblOriginalWeight;
        private Label lblReTrainedWeight;
        private Label lblWeightDiffs;
        private TextBox txtOriginalWeight;
        private TextBox txtReTrainedWeight;
        private TextBox txtWeightDiffs;
        private ComboBox comboBoxLabel;
        private Button btnRetrain;
    }
}