namespace RippleButton
{
    partial class Form1
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
            this.rippleBtn1 = new RippleButton.RippleBtn();
            this.SuspendLayout();
            // 
            // rippleBtn1
            // 
            this.rippleBtn1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rippleBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rippleBtn1.ForeColor = System.Drawing.Color.White;
            this.rippleBtn1.Location = new System.Drawing.Point(354, 204);
            this.rippleBtn1.Name = "rippleBtn1";
            this.rippleBtn1.Size = new System.Drawing.Size(179, 61);
            this.rippleBtn1.TabIndex = 0;
            this.rippleBtn1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 424);
            this.Controls.Add(this.rippleBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RippleBtn rippleBtn1;
    }
}

