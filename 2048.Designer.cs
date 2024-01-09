using System.Windows.Forms;

namespace _2048
{
    partial class game2048
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            best = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            score = new Label();
            label2 = new Label();
            panel1 = new Panel();
            oyun16 = new Label();
            oyun15 = new Label();
            oyun14 = new Label();
            oyun13 = new Label();
            oyun12 = new Label();
            oyun11 = new Label();
            oyun10 = new Label();
            oyun9 = new Label();
            oyun8 = new Label();
            oyun7 = new Label();
            oyun6 = new Label();
            oyun5 = new Label();
            oyun4 = new Label();
            oyun3 = new Label();
            oyun2 = new Label();
            oyun1 = new Label();
            btnbasla = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.LightCoral;
            label1.Location = new System.Drawing.Point(12, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 90);
            label1.TabIndex = 0;
            label1.Text = "2048";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            groupBox1.Controls.Add(best);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(402, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(100, 61);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // best
            // 
            best.AutoSize = true;
            best.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            best.ForeColor = System.Drawing.SystemColors.Control;
            best.Location = new System.Drawing.Point(32, 30);
            best.Name = "best";
            best.Size = new System.Drawing.Size(36, 28);
            best.TabIndex = 3;
            best.Text = "00";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.RosyBrown;
            label3.Location = new System.Drawing.Point(0, 1);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 28);
            label3.TabIndex = 1;
            label3.Text = "   BEST";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.DarkSalmon;
            groupBox2.Controls.Add(score);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new System.Drawing.Point(289, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(100, 61);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            score.ForeColor = System.Drawing.SystemColors.Control;
            score.Location = new System.Drawing.Point(31, 29);
            score.Name = "score";
            score.Size = new System.Drawing.Size(36, 28);
            score.TabIndex = 2;
            score.Text = "00";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.RosyBrown;
            label2.Location = new System.Drawing.Point(1, 1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 28);
            label2.TabIndex = 0;
            label2.Text = "  SCORE";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.IndianRed;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(oyun16);
            panel1.Controls.Add(oyun15);
            panel1.Controls.Add(oyun14);
            panel1.Controls.Add(oyun13);
            panel1.Controls.Add(oyun12);
            panel1.Controls.Add(oyun11);
            panel1.Controls.Add(oyun10);
            panel1.Controls.Add(oyun9);
            panel1.Controls.Add(oyun8);
            panel1.Controls.Add(oyun7);
            panel1.Controls.Add(oyun6);
            panel1.Controls.Add(oyun5);
            panel1.Controls.Add(oyun4);
            panel1.Controls.Add(oyun3);
            panel1.Controls.Add(oyun2);
            panel1.Controls.Add(oyun1);
            panel1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.Location = new System.Drawing.Point(7, 160);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(512, 512);
            panel1.TabIndex = 2;
            
            // 
            // oyun16
            // 
            oyun16.BackColor = System.Drawing.Color.RosyBrown;
            oyun16.Location = new System.Drawing.Point(389, 389);
            oyun16.Name = "oyun16";
            oyun16.Size = new System.Drawing.Size(115, 115);
            oyun16.TabIndex = 15;
            oyun16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun15
            // 
            oyun15.BackColor = System.Drawing.Color.RosyBrown;
            oyun15.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            oyun15.Location = new System.Drawing.Point(262, 389);
            oyun15.Name = "oyun15";
            oyun15.Size = new System.Drawing.Size(115, 115);
            oyun15.TabIndex = 14;
            oyun15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun14
            // 
            oyun14.BackColor = System.Drawing.Color.RosyBrown;
            oyun14.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            oyun14.Location = new System.Drawing.Point(135, 389);
            oyun14.Name = "oyun14";
            oyun14.Size = new System.Drawing.Size(115, 115);
            oyun14.TabIndex = 13;
            oyun14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun13
            // 
            oyun13.BackColor = System.Drawing.Color.RosyBrown;
            oyun13.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            oyun13.Location = new System.Drawing.Point(8, 389);
            oyun13.Name = "oyun13";
            oyun13.Size = new System.Drawing.Size(115, 115);
            oyun13.TabIndex = 12;
            oyun13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun12
            // 
            oyun12.BackColor = System.Drawing.Color.RosyBrown;
            oyun12.Location = new System.Drawing.Point(389, 262);
            oyun12.Name = "oyun12";
            oyun12.Size = new System.Drawing.Size(115, 115);
            oyun12.TabIndex = 11;
            oyun12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun11
            // 
            oyun11.BackColor = System.Drawing.Color.RosyBrown;
            oyun11.Location = new System.Drawing.Point(262, 262);
            oyun11.Name = "oyun11";
            oyun11.Size = new System.Drawing.Size(115, 115);
            oyun11.TabIndex = 10;
            oyun11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun10
            // 
            oyun10.BackColor = System.Drawing.Color.RosyBrown;
            oyun10.Location = new System.Drawing.Point(135, 262);
            oyun10.Name = "oyun10";
            oyun10.Size = new System.Drawing.Size(115, 115);
            oyun10.TabIndex = 9;
            oyun10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun9
            // 
            oyun9.BackColor = System.Drawing.Color.RosyBrown;
            oyun9.Location = new System.Drawing.Point(8, 262);
            oyun9.Name = "oyun9";
            oyun9.Size = new System.Drawing.Size(115, 115);
            oyun9.TabIndex = 8;
            oyun9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun8
            // 
            oyun8.BackColor = System.Drawing.Color.RosyBrown;
            oyun8.Location = new System.Drawing.Point(389, 135);
            oyun8.Name = "oyun8";
            oyun8.Size = new System.Drawing.Size(115, 115);
            oyun8.TabIndex = 7;
            oyun8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun7
            // 
            oyun7.BackColor = System.Drawing.Color.RosyBrown;
            oyun7.Location = new System.Drawing.Point(262, 135);
            oyun7.Name = "oyun7";
            oyun7.Size = new System.Drawing.Size(115, 115);
            oyun7.TabIndex = 6;
            oyun7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun6
            // 
            oyun6.BackColor = System.Drawing.Color.RosyBrown;
            oyun6.Location = new System.Drawing.Point(135, 135);
            oyun6.Name = "oyun6";
            oyun6.Size = new System.Drawing.Size(115, 115);
            oyun6.TabIndex = 5;
            oyun6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun5
            // 
            oyun5.BackColor = System.Drawing.Color.RosyBrown;
            oyun5.Location = new System.Drawing.Point(8, 135);
            oyun5.Name = "oyun5";
            oyun5.Size = new System.Drawing.Size(115, 115);
            oyun5.TabIndex = 4;
            oyun5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun4
            // 
            oyun4.BackColor = System.Drawing.Color.RosyBrown;
            oyun4.Location = new System.Drawing.Point(389, 8);
            oyun4.Name = "oyun4";
            oyun4.Size = new System.Drawing.Size(115, 115);
            oyun4.TabIndex = 3;
            oyun4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun3
            // 
            oyun3.BackColor = System.Drawing.Color.RosyBrown;
            oyun3.Location = new System.Drawing.Point(262, 8);
            oyun3.Name = "oyun3";
            oyun3.Size = new System.Drawing.Size(115, 115);
            oyun3.TabIndex = 2;
            oyun3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun2
            // 
            oyun2.BackColor = System.Drawing.Color.RosyBrown;
            oyun2.Location = new System.Drawing.Point(135, 8);
            oyun2.Name = "oyun2";
            oyun2.Size = new System.Drawing.Size(115, 115);
            oyun2.TabIndex = 1;
            oyun2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyun1
            // 
            oyun1.AllowDrop = true;
            oyun1.AutoEllipsis = true;
            oyun1.BackColor = System.Drawing.Color.RosyBrown;
            oyun1.Location = new System.Drawing.Point(8, 8);
            oyun1.Name = "oyun1";
            oyun1.Size = new System.Drawing.Size(115, 115);
            oyun1.TabIndex = 0;
            oyun1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnbasla
            // 
            btnbasla.BackColor = System.Drawing.Color.Salmon;
            btnbasla.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnbasla.ForeColor = System.Drawing.SystemColors.Control;
            btnbasla.Location = new System.Drawing.Point(306, 101);
            btnbasla.Name = "btnbasla";
            btnbasla.Size = new System.Drawing.Size(181, 44);
            btnbasla.TabIndex = 3;
            btnbasla.Text = "NEW GAME";
            btnbasla.UseVisualStyleBackColor = false;
            btnbasla.Click += btnbasla_Click;
            // 
            // game2048
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(531, 693);
            Controls.Add(btnbasla);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "game2048";
            Text = "2048";
            KeyDown += game2048_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label best;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Label oyun16;
        private Label oyun15;
        private Label oyun14;
        private Label oyun13;
        private Label oyun12;
        private Label oyun11;
        private Label oyun10;
        private Label oyun9;
        private Label oyun8;
        private Label oyun7;
        private Label oyun6;
        private Label oyun5;
        private Label oyun4;
        private Label oyun3;
        private Label oyun2;
        private Label oyun1;
        private Button btnbasla;
    }
}
