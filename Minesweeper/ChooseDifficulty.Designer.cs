namespace Minesweeper
{
    partial class ChooseDifficulty
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
            this.rdb_Easy = new System.Windows.Forms.RadioButton();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.rdb_Medium = new System.Windows.Forms.RadioButton();
            this.rdb_Hard = new System.Windows.Forms.RadioButton();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Easy
            // 
            this.rdb_Easy.AutoSize = true;
            this.rdb_Easy.BackColor = System.Drawing.Color.DarkGray;
            this.rdb_Easy.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdb_Easy.Location = new System.Drawing.Point(106, 114);
            this.rdb_Easy.Name = "rdb_Easy";
            this.rdb_Easy.Size = new System.Drawing.Size(88, 33);
            this.rdb_Easy.TabIndex = 0;
            this.rdb_Easy.TabStop = true;
            this.rdb_Easy.Text = "Easy";
            this.rdb_Easy.UseVisualStyleBackColor = false;
            // 
            // btn_Continue
            // 
            this.btn_Continue.BackColor = System.Drawing.Color.Gray;
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.Location = new System.Drawing.Point(206, 198);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(184, 60);
            this.btn_Continue.TabIndex = 3;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = false;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // rdb_Medium
            // 
            this.rdb_Medium.AutoSize = true;
            this.rdb_Medium.BackColor = System.Drawing.Color.DarkGray;
            this.rdb_Medium.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdb_Medium.Location = new System.Drawing.Point(248, 114);
            this.rdb_Medium.Name = "rdb_Medium";
            this.rdb_Medium.Size = new System.Drawing.Size(133, 33);
            this.rdb_Medium.TabIndex = 5;
            this.rdb_Medium.TabStop = true;
            this.rdb_Medium.Text = "Medium";
            this.rdb_Medium.UseVisualStyleBackColor = false;
            // 
            // rdb_Hard
            // 
            this.rdb_Hard.AutoSize = true;
            this.rdb_Hard.BackColor = System.Drawing.Color.DarkGray;
            this.rdb_Hard.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdb_Hard.Location = new System.Drawing.Point(406, 114);
            this.rdb_Hard.Name = "rdb_Hard";
            this.rdb_Hard.Size = new System.Drawing.Size(96, 33);
            this.rdb_Hard.TabIndex = 6;
            this.rdb_Hard.TabStop = true;
            this.rdb_Hard.Text = "Hard";
            this.rdb_Hard.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Gray;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(206, 289);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(184, 60);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ChooseDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(650, 431);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.rdb_Hard);
            this.Controls.Add(this.rdb_Medium);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.rdb_Easy);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChooseDifficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseDifficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Easy;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.RadioButton rdb_Medium;
        private System.Windows.Forms.RadioButton rdb_Hard;
        private System.Windows.Forms.Button btn_Exit;
    }
}