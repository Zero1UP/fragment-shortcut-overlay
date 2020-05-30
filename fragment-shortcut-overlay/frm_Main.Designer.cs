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
            this.components = new System.ComponentModel.Container();
            this.tmr_ReadPad = new System.Windows.Forms.Timer(this.components);
            this.tmr_PCSX2Check = new System.Windows.Forms.Timer(this.components);
            this.lbl_Circle = new System.Windows.Forms.Label();
            this.lbl_Triangle = new System.Windows.Forms.Label();
            this.lbl_Square = new System.Windows.Forms.Label();
            this.lbl_Cross = new System.Windows.Forms.Label();
            this.tmr_AdjustWindow = new System.Windows.Forms.Timer(this.components);
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.pct_TriggerButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_TriggerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_ReadPad
            // 
            this.tmr_ReadPad.Enabled = true;
            this.tmr_ReadPad.Tick += new System.EventHandler(this.tmr_ReadPad_Tick);
            // 
            // tmr_PCSX2Check
            // 
            this.tmr_PCSX2Check.Enabled = true;
            this.tmr_PCSX2Check.Interval = 1000;
            this.tmr_PCSX2Check.Tick += new System.EventHandler(this.tmr_PCSX2Check_Tick);
            // 
            // lbl_Circle
            // 
            this.lbl_Circle.AutoSize = true;
            this.lbl_Circle.BackColor = System.Drawing.Color.White;
            this.lbl_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Circle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Circle.Location = new System.Drawing.Point(35, 39);
            this.lbl_Circle.Name = "lbl_Circle";
            this.lbl_Circle.Size = new System.Drawing.Size(52, 17);
            this.lbl_Circle.TabIndex = 0;
            this.lbl_Circle.Text = "label1";
            // 
            // lbl_Triangle
            // 
            this.lbl_Triangle.AutoSize = true;
            this.lbl_Triangle.BackColor = System.Drawing.Color.White;
            this.lbl_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Triangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Triangle.Location = new System.Drawing.Point(35, 69);
            this.lbl_Triangle.Name = "lbl_Triangle";
            this.lbl_Triangle.Size = new System.Drawing.Size(52, 17);
            this.lbl_Triangle.TabIndex = 0;
            this.lbl_Triangle.Text = "label1";
            // 
            // lbl_Square
            // 
            this.lbl_Square.AutoSize = true;
            this.lbl_Square.BackColor = System.Drawing.Color.White;
            this.lbl_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Square.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Square.Location = new System.Drawing.Point(35, 99);
            this.lbl_Square.Name = "lbl_Square";
            this.lbl_Square.Size = new System.Drawing.Size(52, 17);
            this.lbl_Square.TabIndex = 0;
            this.lbl_Square.Text = "label1";
            // 
            // lbl_Cross
            // 
            this.lbl_Cross.AutoSize = true;
            this.lbl_Cross.BackColor = System.Drawing.Color.White;
            this.lbl_Cross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Cross.Location = new System.Drawing.Point(35, 129);
            this.lbl_Cross.Name = "lbl_Cross";
            this.lbl_Cross.Size = new System.Drawing.Size(52, 17);
            this.lbl_Cross.TabIndex = 0;
            this.lbl_Cross.Text = "label1";
            // 
            // tmr_AdjustWindow
            // 
            this.tmr_AdjustWindow.Enabled = true;
            this.tmr_AdjustWindow.Interval = 1;
            this.tmr_AdjustWindow.Tick += new System.EventHandler(this.tmr_AdjustWindow_Tick);
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.pct_TriggerButton);
            this.pnl_Buttons.Controls.Add(this.pictureBox2);
            this.pnl_Buttons.Controls.Add(this.pictureBox4);
            this.pnl_Buttons.Controls.Add(this.lbl_Circle);
            this.pnl_Buttons.Controls.Add(this.pictureBox3);
            this.pnl_Buttons.Controls.Add(this.lbl_Triangle);
            this.pnl_Buttons.Controls.Add(this.lbl_Square);
            this.pnl_Buttons.Controls.Add(this.pictureBox1);
            this.pnl_Buttons.Controls.Add(this.lbl_Cross);
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 2);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(176, 152);
            this.pnl_Buttons.TabIndex = 2;
            this.pnl_Buttons.Visible = false;
            // 
            // pct_TriggerButton
            // 
            this.pct_TriggerButton.Location = new System.Drawing.Point(6, 5);
            this.pct_TriggerButton.Name = "pct_TriggerButton";
            this.pct_TriggerButton.Size = new System.Drawing.Size(34, 21);
            this.pct_TriggerButton.TabIndex = 3;
            this.pct_TriggerButton.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::fragment_shortcut_overlay.Properties.Resources.circle;
            this.pictureBox2.Location = new System.Drawing.Point(5, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::fragment_shortcut_overlay.Properties.Resources.square;
            this.pictureBox4.Location = new System.Drawing.Point(5, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::fragment_shortcut_overlay.Properties.Resources.triangle;
            this.pictureBox3.Location = new System.Drawing.Point(5, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fragment_shortcut_overlay.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(5, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 154);
            this.Controls.Add(this.pnl_Buttons);
            this.Name = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_TriggerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_ReadPad;
        private System.Windows.Forms.Timer tmr_PCSX2Check;
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

