namespace WindowsFormsApp7
{
    partial class cbx_Shapes
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.txtBox_Height = new System.Windows.Forms.TextBox();
            this.btn_ColorDialog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Location = new System.Drawing.Point(268, 9);
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(100, 27);
            this.txtBox_Width.TabIndex = 2;
            this.txtBox_Width.Text = "100";
            this.txtBox_Width.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(410, 15);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(64, 20);
            this.lbl_Height.TabIndex = 5;
            this.lbl_Height.Text = "Height";
            // 
            // txtBox_Height
            // 
            this.txtBox_Height.Location = new System.Drawing.Point(486, 12);
            this.txtBox_Height.Name = "txtBox_Height";
            this.txtBox_Height.Size = new System.Drawing.Size(100, 27);
            this.txtBox_Height.TabIndex = 4;
            this.txtBox_Height.Text = "100";
            // 
            // btn_ColorDialog
            // 
            this.btn_ColorDialog.AutoSize = true;
            this.btn_ColorDialog.Location = new System.Drawing.Point(682, 12);
            this.btn_ColorDialog.Name = "btn_ColorDialog";
            this.btn_ColorDialog.Size = new System.Drawing.Size(81, 30);
            this.btn_ColorDialog.TabIndex = 6;
            this.btn_ColorDialog.Text = "Select";
            this.btn_ColorDialog.UseVisualStyleBackColor = true;
            this.btn_ColorDialog.Click += new System.EventHandler(this.btn_ColorDialog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(887, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fill";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(887, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outline";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbx_Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 866);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ColorDialog);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.txtBox_Height);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Width);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "cbx_Shapes";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cbx_Shapes_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx_Shapes_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox txtBox_Height;
        private System.Windows.Forms.Button btn_ColorDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

