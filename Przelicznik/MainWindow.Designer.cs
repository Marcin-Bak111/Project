
namespace Przelicznik
{
    partial class MainWindow
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
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.StartUnitGroupBox = new System.Windows.Forms.GroupBox();
            this.ComboBoxStartUnit = new System.Windows.Forms.ComboBox();
            this.TargetUnitGroupBox = new System.Windows.Forms.GroupBox();
            this.ComboBoxTargetUnit = new System.Windows.Forms.ComboBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NumericUpDownResult = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();
            this.TypeGroupBox.SuspendLayout();
            this.StartUnitGroupBox.SuspendLayout();
            this.TargetUnitGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownResult)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.ComboBoxType);
            this.TypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Size = new System.Drawing.Size(776, 68);
            this.TypeGroupBox.TabIndex = 0;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Rodzaj";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Location = new System.Drawing.Point(6, 22);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(764, 23);
            this.ComboBoxType.TabIndex = 0;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // StartUnitGroupBox
            // 
            this.StartUnitGroupBox.Controls.Add(this.ComboBoxStartUnit);
            this.StartUnitGroupBox.Location = new System.Drawing.Point(12, 86);
            this.StartUnitGroupBox.Name = "StartUnitGroupBox";
            this.StartUnitGroupBox.Size = new System.Drawing.Size(776, 67);
            this.StartUnitGroupBox.TabIndex = 1;
            this.StartUnitGroupBox.TabStop = false;
            this.StartUnitGroupBox.Text = "Jednostka źródłowa";
            // 
            // ComboBoxStartUnit
            // 
            this.ComboBoxStartUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStartUnit.FormattingEnabled = true;
            this.ComboBoxStartUnit.Location = new System.Drawing.Point(6, 22);
            this.ComboBoxStartUnit.Name = "ComboBoxStartUnit";
            this.ComboBoxStartUnit.Size = new System.Drawing.Size(764, 23);
            this.ComboBoxStartUnit.TabIndex = 0;
            // 
            // TargetUnitGroupBox
            // 
            this.TargetUnitGroupBox.Controls.Add(this.ComboBoxTargetUnit);
            this.TargetUnitGroupBox.Location = new System.Drawing.Point(12, 159);
            this.TargetUnitGroupBox.Name = "TargetUnitGroupBox";
            this.TargetUnitGroupBox.Size = new System.Drawing.Size(776, 80);
            this.TargetUnitGroupBox.TabIndex = 2;
            this.TargetUnitGroupBox.TabStop = false;
            this.TargetUnitGroupBox.Text = "Jednostka docelowa";
            // 
            // ComboBoxTargetUnit
            // 
            this.ComboBoxTargetUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTargetUnit.FormattingEnabled = true;
            this.ComboBoxTargetUnit.Location = new System.Drawing.Point(6, 32);
            this.ComboBoxTargetUnit.Name = "ComboBoxTargetUnit";
            this.ComboBoxTargetUnit.Size = new System.Drawing.Size(764, 23);
            this.ComboBoxTargetUnit.TabIndex = 0;
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.CalculateButton);
            this.ResultGroupBox.Controls.Add(this.NumericUpDownResult);
            this.ResultGroupBox.Location = new System.Drawing.Point(12, 245);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(776, 100);
            this.ResultGroupBox.TabIndex = 3;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Wynik";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(615, 17);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(143, 72);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Oblicz";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NumericUpDownResult
            // 
            this.NumericUpDownResult.Location = new System.Drawing.Point(6, 44);
            this.NumericUpDownResult.Name = "NumericUpDownResult";
            this.NumericUpDownResult.Size = new System.Drawing.Size(570, 23);
            this.NumericUpDownResult.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(278, 411);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 43);
            this.labelResult.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 536);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.TargetUnitGroupBox);
            this.Controls.Add(this.StartUnitGroupBox);
            this.Controls.Add(this.TypeGroupBox);
            this.Name = "MainWindow";
            this.TypeGroupBox.ResumeLayout(false);
            this.StartUnitGroupBox.ResumeLayout(false);
            this.TargetUnitGroupBox.ResumeLayout(false);
            this.ResultGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.GroupBox StartUnitGroupBox;
        private System.Windows.Forms.ComboBox ComboBoxStartUnit;
        private System.Windows.Forms.GroupBox TargetUnitGroupBox;
        private System.Windows.Forms.ComboBox ComboBoxTargetUnit;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.NumericUpDown NumericUpDownResult;
        private System.Windows.Forms.Label labelResult;
    }
}

