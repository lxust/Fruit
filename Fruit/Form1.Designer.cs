namespace Fruit
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.pcb3 = new System.Windows.Forms.PictureBox();
            this.pcb4 = new System.Windows.Forms.PictureBox();
            this.pcb5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(579, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pcb1
            // 
            this.pcb1.Location = new System.Drawing.Point(249, 114);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(128, 128);
            this.pcb1.TabIndex = 1;
            this.pcb1.TabStop = false;
            this.pcb1.Click += new System.EventHandler(this.pcb1_Click);
            // 
            // pcb2
            // 
            this.pcb2.Location = new System.Drawing.Point(12, 114);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(128, 128);
            this.pcb2.TabIndex = 2;
            this.pcb2.TabStop = false;
            this.pcb2.Click += new System.EventHandler(this.pcb2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Уровень: ";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(77, 58);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 15);
            this.lblLevel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(340, 58);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 15);
            this.lblMoney.TabIndex = 6;
            // 
            // pcb3
            // 
            this.pcb3.Location = new System.Drawing.Point(466, 114);
            this.pcb3.Name = "pcb3";
            this.pcb3.Size = new System.Drawing.Size(128, 128);
            this.pcb3.TabIndex = 7;
            this.pcb3.TabStop = false;
            this.pcb3.Click += new System.EventHandler(this.pcb3_Click);
            // 
            // pcb4
            // 
            this.pcb4.Location = new System.Drawing.Point(136, 271);
            this.pcb4.Name = "pcb4";
            this.pcb4.Size = new System.Drawing.Size(128, 128);
            this.pcb4.TabIndex = 8;
            this.pcb4.TabStop = false;
            this.pcb4.Click += new System.EventHandler(this.pcb4_Click);
            // 
            // pcb5
            // 
            this.pcb5.Location = new System.Drawing.Point(365, 271);
            this.pcb5.Name = "pcb5";
            this.pcb5.Size = new System.Drawing.Size(128, 128);
            this.pcb5.TabIndex = 9;
            this.pcb5.TabStop = false;
            this.pcb5.Click += new System.EventHandler(this.pcb5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 425);
            this.Controls.Add(this.pcb5);
            this.Controls.Add(this.pcb4);
            this.Controls.Add(this.pcb3);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private PictureBox pcb1;
        private PictureBox pcb2;
        private Label label1;
        private Label lblLevel;
        private Label label2;
        private Label lblMoney;
        private PictureBox pcb3;
        private PictureBox pcb4;
        private PictureBox pcb5;
    }
}