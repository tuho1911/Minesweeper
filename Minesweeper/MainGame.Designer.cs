namespace Minesweeper
{
    partial class MainGame
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
            this.btn_LogoRestart = new System.Windows.Forms.Button();
            this.lb_BombShow = new System.Windows.Forms.Label();
            this.lb_TimeCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmr_TimeCount = new System.Windows.Forms.Timer(this.components);
            this.lbl_Notify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LogoRestart
            // 
            this.btn_LogoRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogoRestart.Location = new System.Drawing.Point(36, 140);
            this.btn_LogoRestart.Name = "btn_LogoRestart";
            this.btn_LogoRestart.Size = new System.Drawing.Size(50, 49);
            this.btn_LogoRestart.TabIndex = 8;
            this.btn_LogoRestart.UseVisualStyleBackColor = false;
            this.btn_LogoRestart.Click += new System.EventHandler(this.btn_LogoRestart_Click);
            // 
            // lb_BombShow
            // 
            this.lb_BombShow.BackColor = System.Drawing.Color.Black;
            this.lb_BombShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BombShow.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BombShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_BombShow.Location = new System.Drawing.Point(12, 74);
            this.lb_BombShow.Name = "lb_BombShow";
            this.lb_BombShow.Size = new System.Drawing.Size(108, 51);
            this.lb_BombShow.TabIndex = 7;
            this.lb_BombShow.Text = "Mines";
            this.lb_BombShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TimeCount
            // 
            this.lb_TimeCount.BackColor = System.Drawing.Color.Black;
            this.lb_TimeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TimeCount.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_TimeCount.Location = new System.Drawing.Point(12, 9);
            this.lb_TimeCount.Name = "lb_TimeCount";
            this.lb_TimeCount.Size = new System.Drawing.Size(108, 51);
            this.lb_TimeCount.TabIndex = 6;
            this.lb_TimeCount.Text = "Time: ";
            this.lb_TimeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(210, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 271);
            this.panel1.TabIndex = 5;
            // 
            // tmr_TimeCount
            // 
            this.tmr_TimeCount.Enabled = true;
            this.tmr_TimeCount.Interval = 1000;
            // 
            // lbl_Notify
            // 
            this.lbl_Notify.AutoSize = true;
            this.lbl_Notify.Location = new System.Drawing.Point(12, 212);
            this.lbl_Notify.Name = "lbl_Notify";
            this.lbl_Notify.Size = new System.Drawing.Size(0, 20);
            this.lbl_Notify.TabIndex = 10;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1014, 758);
            this.Controls.Add(this.lbl_Notify);
            this.Controls.Add(this.btn_LogoRestart);
            this.Controls.Add(this.lb_BombShow);
            this.Controls.Add(this.lb_TimeCount);
            this.Controls.Add(this.panel1);
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogoRestart;
        private System.Windows.Forms.Label lb_BombShow;
        private System.Windows.Forms.Label lb_TimeCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmr_TimeCount;
        private System.Windows.Forms.Label lbl_Notify;
    }
}

