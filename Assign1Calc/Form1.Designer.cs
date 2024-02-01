
namespace Assign1Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnPercent = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnDot = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnNegate = new Button();
            btnClear = new Button();
            btnResult = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDel = new Button();
            label1 = new Label();
            txtResult = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(16, 14);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(468, 42);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.HighlightText;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(18, 205);
            btn7.Name = "btn7";
            btn7.Size = new Size(79, 69);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.HighlightText;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(18, 294);
            btn4.Name = "btn4";
            btn4.Size = new Size(79, 69);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.HighlightText;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(18, 384);
            btn1.Name = "btn1";
            btn1.Size = new Size(79, 69);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.HighlightText;
            btnPercent.FlatStyle = FlatStyle.Popup;
            btnPercent.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnPercent.ForeColor = SystemColors.ActiveCaptionText;
            btnPercent.Location = new Point(306, 468);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(79, 69);
            btnPercent.TabIndex = 8;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.HighlightText;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(114, 205);
            btn8.Name = "btn8";
            btn8.Size = new Size(79, 69);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.HighlightText;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(114, 294);
            btn5.Name = "btn5";
            btn5.Size = new Size(79, 69);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.HighlightText;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(114, 384);
            btn2.Name = "btn2";
            btn2.Size = new Size(79, 69);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.HighlightText;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ActiveCaptionText;
            btn0.Location = new Point(18, 468);
            btn0.Name = "btn0";
            btn0.Size = new Size(175, 69);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HighlightText;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(401, 205);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 158);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.HighlightText;
            btnSub.FlatStyle = FlatStyle.Popup;
            btnSub.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnSub.ForeColor = SystemColors.ActiveCaptionText;
            btnSub.Location = new Point(306, 384);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(79, 69);
            btnSub.TabIndex = 19;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = SystemColors.HighlightText;
            btnMult.FlatStyle = FlatStyle.Flat;
            btnMult.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnMult.ForeColor = SystemColors.ActiveCaptionText;
            btnMult.Location = new Point(306, 294);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(79, 69);
            btnMult.TabIndex = 18;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.HighlightText;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnDiv.ForeColor = SystemColors.ActiveCaptionText;
            btnDiv.Location = new Point(306, 205);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(79, 69);
            btnDiv.TabIndex = 17;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.HighlightText;
            btnDot.FlatStyle = FlatStyle.Popup;
            btnDot.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnDot.ForeColor = SystemColors.ActiveCaptionText;
            btnDot.Location = new Point(210, 468);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(79, 69);
            btnDot.TabIndex = 16;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.HighlightText;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(210, 384);
            btn3.Name = "btn3";
            btn3.Size = new Size(79, 69);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.HighlightText;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(210, 294);
            btn6.Name = "btn6";
            btn6.Size = new Size(79, 69);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.HighlightText;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(210, 205);
            btn9.Name = "btn9";
            btn9.Size = new Size(79, 69);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnNegate
            // 
            btnNegate.BackColor = SystemColors.HighlightText;
            btnNegate.FlatStyle = FlatStyle.Flat;
            btnNegate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnNegate.ForeColor = SystemColors.ActiveCaptionText;
            btnNegate.Location = new Point(210, 119);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(79, 69);
            btnNegate.TabIndex = 24;
            btnNegate.Text = "+/-";
            btnNegate.UseVisualStyleBackColor = false;
            btnNegate.Click += btnNegate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HighlightText;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(114, 119);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(79, 69);
            btnClear.TabIndex = 21;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = SystemColors.HighlightText;
            btnResult.FlatStyle = FlatStyle.Popup;
            btnResult.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnResult.ForeColor = SystemColors.ActiveCaptionText;
            btnResult.Location = new Point(401, 384);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(79, 153);
            btnResult.TabIndex = 25;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.HighlightText;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnDel.ForeColor = SystemColors.ActiveCaptionText;
            btnDel.Location = new Point(306, 119);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(174, 69);
            btnDel.TabIndex = 26;
            btnDel.Text = "←";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += button1_Click;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(18, 119);
            label1.Name = "label1";
            label1.Size = new Size(79, 69);
            label1.TabIndex = 27;
            label1.Click += label1_Click_1;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = SystemColors.WindowFrame;
            txtResult.Location = new Point(16, 52);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(468, 34);
            txtResult.TabIndex = 28;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(18, 547);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 29;
            label2.Text = "CPE262";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(498, 576);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Controls.Add(btnDel);
            Controls.Add(btnResult);
            Controls.Add(btnNegate);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btnPercent);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Standard Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btnPercent;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn0;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnDot;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnNegate;
        private Button btnClear;
        private Button btnResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDel;
        private Label label1;
        private TextBox txtResult;
        private Label label2;
    }
}
