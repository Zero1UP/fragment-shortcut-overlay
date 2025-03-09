namespace fragment_shortcut_overlay
{
    partial class frm_Main
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
            components = new System.ComponentModel.Container();
            tmr_ReadPad = new System.Windows.Forms.Timer(components);
            lbl_Circle = new System.Windows.Forms.Label();
            lbl_Triangle = new System.Windows.Forms.Label();
            lbl_Square = new System.Windows.Forms.Label();
            lbl_Cross = new System.Windows.Forms.Label();
            tmr_AdjustWindow = new System.Windows.Forms.Timer(components);
            pnl_Buttons = new System.Windows.Forms.Panel();
            pct_TriggerButton = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pnl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pct_TriggerButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tmr_ReadPad
            // 
            tmr_ReadPad.Enabled = true;
            tmr_ReadPad.Tick += tmr_ReadPad_Tick;
            // 
            // lbl_Circle
            // 
            lbl_Circle.AutoSize = true;
            lbl_Circle.BackColor = System.Drawing.Color.White;
            lbl_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Circle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            lbl_Circle.Location = new System.Drawing.Point(41, 45);
            lbl_Circle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Circle.Name = "lbl_Circle";
            lbl_Circle.Size = new System.Drawing.Size(52, 17);
            lbl_Circle.TabIndex = 0;
            lbl_Circle.Text = "label1";
            // 
            // lbl_Triangle
            // 
            lbl_Triangle.AutoSize = true;
            lbl_Triangle.BackColor = System.Drawing.Color.White;
            lbl_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Triangle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            lbl_Triangle.Location = new System.Drawing.Point(41, 80);
            lbl_Triangle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Triangle.Name = "lbl_Triangle";
            lbl_Triangle.Size = new System.Drawing.Size(52, 17);
            lbl_Triangle.TabIndex = 0;
            lbl_Triangle.Text = "label1";
            // 
            // lbl_Square
            // 
            lbl_Square.AutoSize = true;
            lbl_Square.BackColor = System.Drawing.Color.White;
            lbl_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Square.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            lbl_Square.Location = new System.Drawing.Point(41, 114);
            lbl_Square.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Square.Name = "lbl_Square";
            lbl_Square.Size = new System.Drawing.Size(52, 17);
            lbl_Square.TabIndex = 0;
            lbl_Square.Text = "label1";
            // 
            // lbl_Cross
            // 
            lbl_Cross.AutoSize = true;
            lbl_Cross.BackColor = System.Drawing.Color.White;
            lbl_Cross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Cross.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            lbl_Cross.Location = new System.Drawing.Point(41, 149);
            lbl_Cross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Cross.Name = "lbl_Cross";
            lbl_Cross.Size = new System.Drawing.Size(52, 17);
            lbl_Cross.TabIndex = 0;
            lbl_Cross.Text = "label1";
            // 
            // tmr_AdjustWindow
            // 
            tmr_AdjustWindow.Enabled = true;
            tmr_AdjustWindow.Interval = 1;
            tmr_AdjustWindow.Tick += tmr_AdjustWindow_Tick;
            // 
            // pnl_Buttons
            // 
            pnl_Buttons.Controls.Add(pct_TriggerButton);
            pnl_Buttons.Controls.Add(pictureBox2);
            pnl_Buttons.Controls.Add(pictureBox4);
            pnl_Buttons.Controls.Add(lbl_Circle);
            pnl_Buttons.Controls.Add(pictureBox3);
            pnl_Buttons.Controls.Add(lbl_Triangle);
            pnl_Buttons.Controls.Add(lbl_Square);
            pnl_Buttons.Controls.Add(pictureBox1);
            pnl_Buttons.Controls.Add(lbl_Cross);
            pnl_Buttons.Location = new System.Drawing.Point(0, 2);
            pnl_Buttons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnl_Buttons.Name = "pnl_Buttons";
            pnl_Buttons.Size = new System.Drawing.Size(205, 175);
            pnl_Buttons.TabIndex = 2;
            pnl_Buttons.Visible = false;
            // 
            // pct_TriggerButton
            // 
            pct_TriggerButton.Location = new System.Drawing.Point(7, 6);
            pct_TriggerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pct_TriggerButton.Name = "pct_TriggerButton";
            pct_TriggerButton.Size = new System.Drawing.Size(40, 24);
            pct_TriggerButton.TabIndex = 3;
            pct_TriggerButton.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.circle;
            pictureBox2.Location = new System.Drawing.Point(6, 37);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(28, 28);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.square;
            pictureBox4.Location = new System.Drawing.Point(6, 106);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(28, 28);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.triangle;
            pictureBox3.Location = new System.Drawing.Point(6, 72);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(28, 28);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x;
            pictureBox1.Location = new System.Drawing.Point(6, 141);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(28, 28);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(212, 178);
            Controls.Add(pnl_Buttons);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frm_Main";
            Load += frm_Main_Load;
            pnl_Buttons.ResumeLayout(false);
            pnl_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pct_TriggerButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_ReadPad;
        private System.Windows.Forms.Label lbl_Circle;
        private System.Windows.Forms.Label lbl_Triangle;
        private System.Windows.Forms.Label lbl_Square;
        private System.Windows.Forms.Label lbl_Cross;
        private System.Windows.Forms.Timer tmr_AdjustWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.PictureBox pct_TriggerButton;
    }
}

