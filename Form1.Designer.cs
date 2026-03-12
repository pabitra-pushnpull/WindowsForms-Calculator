namespace Calculator
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
            btnSeven = new Button();
            btnEight = new Button();
            btnSubtract = new Button();
            btnNine = new Button();
            btnAdd = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnEqual = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnzero = new Button();
            btnFullStop = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnBackspace = new Button();
            btnClear = new Button();
            txtBox_Result = new TextBox();
            SuspendLayout();
            // 
            // btnSeven
            // 
            btnSeven.Cursor = Cursors.Hand;
            btnSeven.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeven.ForeColor = SystemColors.ActiveCaptionText;
            btnSeven.Location = new Point(12, 210);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(92, 63);
            btnSeven.TabIndex = 0;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnOne_Click;
            // 
            // btnEight
            // 
            btnEight.Cursor = Cursors.Hand;
            btnEight.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEight.ForeColor = SystemColors.ActiveCaptionText;
            btnEight.Location = new Point(110, 210);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(92, 63);
            btnEight.TabIndex = 1;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnOne_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Cursor = Cursors.Hand;
            btnSubtract.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtract.ForeColor = SystemColors.ActiveCaptionText;
            btnSubtract.Location = new Point(306, 210);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(92, 63);
            btnSubtract.TabIndex = 3;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnNine
            // 
            btnNine.Cursor = Cursors.Hand;
            btnNine.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNine.ForeColor = SystemColors.ActiveCaptionText;
            btnNine.Location = new Point(208, 210);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(92, 63);
            btnNine.TabIndex = 2;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnOne_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(306, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 63);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSix
            // 
            btnSix.Cursor = Cursors.Hand;
            btnSix.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSix.ForeColor = SystemColors.ActiveCaptionText;
            btnSix.Location = new Point(208, 279);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(92, 63);
            btnSix.TabIndex = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnOne_Click;
            // 
            // btnFive
            // 
            btnFive.Cursor = Cursors.Hand;
            btnFive.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFive.ForeColor = SystemColors.ActiveCaptionText;
            btnFive.Location = new Point(110, 279);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(92, 63);
            btnFive.TabIndex = 5;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnOne_Click;
            // 
            // btnFour
            // 
            btnFour.Cursor = Cursors.Hand;
            btnFour.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFour.ForeColor = SystemColors.ActiveCaptionText;
            btnFour.Location = new Point(12, 279);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(92, 63);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnOne_Click;
            // 
            // btnEqual
            // 
            btnEqual.Cursor = Cursors.Hand;
            btnEqual.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = SystemColors.ActiveCaptionText;
            btnEqual.Location = new Point(308, 348);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(92, 139);
            btnEqual.TabIndex = 11;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnThree
            // 
            btnThree.Cursor = Cursors.Hand;
            btnThree.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThree.ForeColor = SystemColors.ActiveCaptionText;
            btnThree.Location = new Point(208, 348);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(92, 63);
            btnThree.TabIndex = 10;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Cursor = Cursors.Hand;
            btnTwo.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTwo.ForeColor = SystemColors.ActiveCaptionText;
            btnTwo.Location = new Point(110, 348);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(92, 63);
            btnTwo.TabIndex = 9;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnOne_Click;
            // 
            // btnOne
            // 
            btnOne.Cursor = Cursors.Hand;
            btnOne.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOne.ForeColor = SystemColors.ActiveCaptionText;
            btnOne.Location = new Point(12, 348);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(92, 63);
            btnOne.TabIndex = 8;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnzero
            // 
            btnzero.Cursor = Cursors.Hand;
            btnzero.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnzero.ForeColor = SystemColors.ActiveCaptionText;
            btnzero.Location = new Point(12, 417);
            btnzero.Name = "btnzero";
            btnzero.Size = new Size(190, 70);
            btnzero.TabIndex = 12;
            btnzero.Tag = "";
            btnzero.Text = "0";
            btnzero.UseVisualStyleBackColor = true;
            btnzero.Click += btnOne_Click;
            // 
            // btnFullStop
            // 
            btnFullStop.Cursor = Cursors.Hand;
            btnFullStop.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFullStop.ForeColor = SystemColors.ActiveCaptionText;
            btnFullStop.Location = new Point(208, 417);
            btnFullStop.Name = "btnFullStop";
            btnFullStop.Size = new Size(92, 70);
            btnFullStop.TabIndex = 13;
            btnFullStop.Text = ".";
            btnFullStop.UseVisualStyleBackColor = true;
            btnFullStop.Click += btnFullStop_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Cursor = Cursors.Hand;
            btnMultiply.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = SystemColors.ActiveCaptionText;
            btnMultiply.Location = new Point(306, 141);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(92, 63);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Cursor = Cursors.Hand;
            btnDivide.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = SystemColors.ActiveCaptionText;
            btnDivide.Location = new Point(208, 141);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(92, 63);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Cursor = Cursors.Hand;
            btnBackspace.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackspace.ForeColor = SystemColors.ActiveCaptionText;
            btnBackspace.ImageKey = "(none)";
            btnBackspace.Location = new Point(110, 141);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(92, 63);
            btnBackspace.TabIndex = 15;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(12, 141);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 63);
            btnClear.TabIndex = 14;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClearAll_Click;
            // 
            // txtBox_Result
            // 
            txtBox_Result.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox_Result.Location = new Point(12, 36);
            txtBox_Result.Name = "txtBox_Result";
            txtBox_Result.ReadOnly = true;
            txtBox_Result.Size = new Size(388, 76);
            txtBox_Result.TabIndex = 18;
            txtBox_Result.Text = "0";
            txtBox_Result.TextAlign = HorizontalAlignment.Right;
            txtBox_Result.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 499);
            Controls.Add(txtBox_Result);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnBackspace);
            Controls.Add(btnClear);
            Controls.Add(btnFullStop);
            Controls.Add(btnzero);
            Controls.Add(btnEqual);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnAdd);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnSubtract);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSeven;
        private Button btnEight;
        private Button btnSubtract;
        private Button btnNine;
        private Button btnAdd;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnEqual;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnzero;
        private Button btnFullStop;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnBackspace;
        private Button btnClear;
        private TextBox txtBox_Result;
    }
}
