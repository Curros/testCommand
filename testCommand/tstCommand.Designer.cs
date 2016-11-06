namespace testCommand
{
    partial class tstCommand
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.radioMultiply = new System.Windows.Forms.RadioButton();
            this.radioSub = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDiv);
            this.groupBox1.Controls.Add(this.radioMultiply);
            this.groupBox1.Controls.Add(this.radioSub);
            this.groupBox1.Controls.Add(this.radioAdd);
            this.groupBox1.Location = new System.Drawing.Point(107, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(6, 88);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(70, 17);
            this.radioDiv.TabIndex = 3;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "/ Division";
            this.radioDiv.UseVisualStyleBackColor = true;
            this.radioDiv.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // radioMultiply
            // 
            this.radioMultiply.AutoSize = true;
            this.radioMultiply.Location = new System.Drawing.Point(6, 66);
            this.radioMultiply.Name = "radioMultiply";
            this.radioMultiply.Size = new System.Drawing.Size(96, 17);
            this.radioMultiply.TabIndex = 2;
            this.radioMultiply.TabStop = true;
            this.radioMultiply.Text = "* Multiplicación";
            this.radioMultiply.UseVisualStyleBackColor = true;
            this.radioMultiply.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // radioSub
            // 
            this.radioSub.AutoSize = true;
            this.radioSub.Location = new System.Drawing.Point(7, 43);
            this.radioSub.Name = "radioSub";
            this.radioSub.Size = new System.Drawing.Size(59, 17);
            this.radioSub.TabIndex = 1;
            this.radioSub.TabStop = true;
            this.radioSub.Text = "- Resta";
            this.radioSub.UseVisualStyleBackColor = true;
            this.radioSub.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(7, 20);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(61, 17);
            this.radioAdd.TabIndex = 0;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "+ Suma";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x = 20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "y = 10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Location = new System.Drawing.Point(225, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 54);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(7, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 0;
            // 
            // tstCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 132);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "tstCommand";
            this.Text = "tstCommand";
            this.Load += new System.EventHandler(this.tstCommand_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.RadioButton radioMultiply;
        private System.Windows.Forms.RadioButton radioSub;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResult;
    }
}

