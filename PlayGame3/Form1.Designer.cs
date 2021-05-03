
namespace PlayGame3
{
    partial class BackGround
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
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.Counter3 = new System.Windows.Forms.Label();
            this.Counter2 = new System.Windows.Forms.Label();
            this.Counter1 = new System.Windows.Forms.Label();
            this.CounterGo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.BackColor = System.Drawing.Color.Black;
            this.PlayGameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PlayGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PlayGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameButton.ForeColor = System.Drawing.Color.White;
            this.PlayGameButton.Location = new System.Drawing.Point(243, 138);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(305, 117);
            this.PlayGameButton.TabIndex = 0;
            this.PlayGameButton.Text = "Play Game ";
            this.PlayGameButton.UseVisualStyleBackColor = false;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // Counter3
            // 
            this.Counter3.AutoSize = true;
            this.Counter3.ForeColor = System.Drawing.Color.White;
            this.Counter3.Location = new System.Drawing.Point(363, 286);
            this.Counter3.Name = "Counter3";
            this.Counter3.Size = new System.Drawing.Size(24, 25);
            this.Counter3.TabIndex = 2;
            this.Counter3.Text = "3";
            this.Counter3.Visible = false;
            // 
            // Counter2
            // 
            this.Counter2.AutoSize = true;
            this.Counter2.ForeColor = System.Drawing.Color.White;
            this.Counter2.Location = new System.Drawing.Point(363, 311);
            this.Counter2.Name = "Counter2";
            this.Counter2.Size = new System.Drawing.Size(24, 25);
            this.Counter2.TabIndex = 3;
            this.Counter2.Text = "2";
            this.Counter2.Visible = false;
            // 
            // Counter1
            // 
            this.Counter1.AutoSize = true;
            this.Counter1.ForeColor = System.Drawing.Color.White;
            this.Counter1.Location = new System.Drawing.Point(363, 336);
            this.Counter1.Name = "Counter1";
            this.Counter1.Size = new System.Drawing.Size(24, 25);
            this.Counter1.TabIndex = 4;
            this.Counter1.Text = "1";
            this.Counter1.Visible = false;
            // 
            // CounterGo
            // 
            this.CounterGo.AutoSize = true;
            this.CounterGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterGo.ForeColor = System.Drawing.Color.White;
            this.CounterGo.Location = new System.Drawing.Point(363, 258);
            this.CounterGo.Name = "CounterGo";
            this.CounterGo.Size = new System.Drawing.Size(58, 31);
            this.CounterGo.TabIndex = 5;
            this.CounterGo.Text = "Go!";
            this.CounterGo.Visible = false;
            // 
            // BackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CounterGo);
            this.Controls.Add(this.Counter1);
            this.Controls.Add(this.Counter2);
            this.Controls.Add(this.Counter3);
            this.Controls.Add(this.PlayGameButton);
            this.Name = "BackGround";
            this.Text = "BackgroundColor";
            this.Load += new System.EventHandler(this.BackGround_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayGameButton;
        private System.Windows.Forms.Label Counter3;
        private System.Windows.Forms.Label Counter2;
        private System.Windows.Forms.Label Counter1;
        private System.Windows.Forms.Label CounterGo;
    }
}

