namespace WindowsFormsApplication5
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameSqure9 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure8 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure7 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure6 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure5 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure4 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure3 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure2 = new WindowsFormsApplication5.UserControls.GameCell();
            this.gameSqure1 = new WindowsFormsApplication5.UserControls.GameCell();
            this.btn_startGame = new System.Windows.Forms.Button();
            this.txt_player1 = new System.Windows.Forms.TextBox();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_player2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gamePanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.label4);
            this.gamePanel.Controls.Add(this.gameSqure9);
            this.gamePanel.Controls.Add(this.gameSqure8);
            this.gamePanel.Controls.Add(this.gameSqure7);
            this.gamePanel.Controls.Add(this.gameSqure6);
            this.gamePanel.Controls.Add(this.gameSqure5);
            this.gamePanel.Controls.Add(this.gameSqure4);
            this.gamePanel.Controls.Add(this.gameSqure3);
            this.gamePanel.Controls.Add(this.gameSqure2);
            this.gamePanel.Controls.Add(this.gameSqure1);
            this.gamePanel.Location = new System.Drawing.Point(30, 42);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(277, 281);
            this.gamePanel.TabIndex = 0;
            // 
            // gameSqure9
            // 
            this.gameSqure9.Location = new System.Drawing.Point(186, 204);
            this.gameSqure9.Name = "gameSqure9";
            this.gameSqure9.Size = new System.Drawing.Size(63, 64);
            this.gameSqure9.SqureId = 9;
            this.gameSqure9.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure9.TabIndex = 8;
            // 
            // gameSqure8
            // 
            this.gameSqure8.Location = new System.Drawing.Point(101, 204);
            this.gameSqure8.Name = "gameSqure8";
            this.gameSqure8.Size = new System.Drawing.Size(63, 64);
            this.gameSqure8.SqureId = 8;
            this.gameSqure8.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure8.TabIndex = 7;
            // 
            // gameSqure7
            // 
            this.gameSqure7.Location = new System.Drawing.Point(18, 204);
            this.gameSqure7.Name = "gameSqure7";
            this.gameSqure7.Size = new System.Drawing.Size(63, 64);
            this.gameSqure7.SqureId = 7;
            this.gameSqure7.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure7.TabIndex = 6;
            // 
            // gameSqure6
            // 
            this.gameSqure6.Location = new System.Drawing.Point(186, 118);
            this.gameSqure6.Name = "gameSqure6";
            this.gameSqure6.Size = new System.Drawing.Size(63, 64);
            this.gameSqure6.SqureId = 6;
            this.gameSqure6.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure6.TabIndex = 5;
            // 
            // gameSqure5
            // 
            this.gameSqure5.Location = new System.Drawing.Point(101, 118);
            this.gameSqure5.Name = "gameSqure5";
            this.gameSqure5.Size = new System.Drawing.Size(63, 64);
            this.gameSqure5.SqureId = 5;
            this.gameSqure5.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure5.TabIndex = 4;
            // 
            // gameSqure4
            // 
            this.gameSqure4.Location = new System.Drawing.Point(18, 118);
            this.gameSqure4.Name = "gameSqure4";
            this.gameSqure4.Size = new System.Drawing.Size(63, 64);
            this.gameSqure4.SqureId = 4;
            this.gameSqure4.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure4.TabIndex = 3;
            // 
            // gameSqure3
            // 
            this.gameSqure3.Location = new System.Drawing.Point(186, 35);
            this.gameSqure3.Name = "gameSqure3";
            this.gameSqure3.Size = new System.Drawing.Size(63, 64);
            this.gameSqure3.SqureId = 3;
            this.gameSqure3.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure3.TabIndex = 2;
            // 
            // gameSqure2
            // 
            this.gameSqure2.Location = new System.Drawing.Point(101, 35);
            this.gameSqure2.Name = "gameSqure2";
            this.gameSqure2.Size = new System.Drawing.Size(63, 64);
            this.gameSqure2.SqureId = 2;
            this.gameSqure2.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure2.TabIndex = 1;
            // 
            // gameSqure1
            // 
            this.gameSqure1.Location = new System.Drawing.Point(18, 35);
            this.gameSqure1.Name = "gameSqure1";
            this.gameSqure1.Size = new System.Drawing.Size(63, 64);
            this.gameSqure1.SqureId = 1;
            this.gameSqure1.SqureStatus = WindowsFormsApplication5.Utils.Enums.CellState.Empty;
            this.gameSqure1.TabIndex = 0;
            // 
            // btn_startGame
            // 
            this.btn_startGame.Location = new System.Drawing.Point(34, 142);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(75, 23);
            this.btn_startGame.TabIndex = 1;
            this.btn_startGame.Text = "Strat";
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Click);
            // 
            // txt_player1
            // 
            this.txt_player1.Location = new System.Drawing.Point(34, 51);
            this.txt_player1.Name = "txt_player1";
            this.txt_player1.Size = new System.Drawing.Size(100, 20);
            this.txt_player1.TabIndex = 2;
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.label3);
            this.playerPanel.Controls.Add(this.label2);
            this.playerPanel.Controls.Add(this.btn_startGame);
            this.playerPanel.Controls.Add(this.txt_player2);
            this.playerPanel.Controls.Add(this.label1);
            this.playerPanel.Controls.Add(this.txt_player1);
            this.playerPanel.Location = new System.Drawing.Point(337, 42);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(153, 217);
            this.playerPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please Insert Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2";
            // 
            // txt_player2
            // 
            this.txt_player2.Location = new System.Drawing.Point(34, 102);
            this.txt_player2.Name = "txt_player2";
            this.txt_player2.Size = new System.Drawing.Size(100, 20);
            this.txt_player2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Click On thes quares";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 405);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private UserControls.GameCell gameSqure1;
        private UserControls.GameCell gameSqure9;
        private UserControls.GameCell gameSqure8;
        private UserControls.GameCell gameSqure7;
        private UserControls.GameCell gameSqure6;
        private UserControls.GameCell gameSqure5;
        private UserControls.GameCell gameSqure4;
        private UserControls.GameCell gameSqure3;
        private UserControls.GameCell gameSqure2;
        private System.Windows.Forms.Button btn_startGame;
        private System.Windows.Forms.TextBox txt_player1;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}

