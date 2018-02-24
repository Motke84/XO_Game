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
            this.gameLabel = new System.Windows.Forms.Label();
            this.btn_startGame = new System.Windows.Forms.Button();
            this.txt_player1 = new System.Windows.Forms.TextBox();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_player2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameBoardDispaly1 = new WindowsFormsApplication5.UserControls.GameBoardDispaly();
            this.gamePanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.gameLabel);
            this.gamePanel.Location = new System.Drawing.Point(45, 65);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(409, 414);
            this.gamePanel.TabIndex = 0;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(37, 35);
            this.gameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(74, 20);
            this.gameLabel.TabIndex = 7;
            this.gameLabel.Text = "Message";
            // 
            // btn_startGame
            // 
            this.btn_startGame.Location = new System.Drawing.Point(51, 218);
            this.btn_startGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(112, 35);
            this.btn_startGame.TabIndex = 1;
            this.btn_startGame.Text = "Strat";
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Click);
            // 
            // txt_player1
            // 
            this.txt_player1.Location = new System.Drawing.Point(51, 78);
            this.txt_player1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_player1.Name = "txt_player1";
            this.txt_player1.Size = new System.Drawing.Size(148, 26);
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
            this.playerPanel.Location = new System.Drawing.Point(506, 65);
            this.playerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(230, 334);
            this.playerPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please Insert Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2";
            // 
            // txt_player2
            // 
            this.txt_player2.Location = new System.Drawing.Point(51, 157);
            this.txt_player2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_player2.Name = "txt_player2";
            this.txt_player2.Size = new System.Drawing.Size(148, 26);
            this.txt_player2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1";
            // 
            // gameBoardDispaly1
            // 
            this.gameBoardDispaly1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameBoardDispaly1.Location = new System.Drawing.Point(86, 143);
            this.gameBoardDispaly1.Name = "gameBoardDispaly1";
            this.gameBoardDispaly1.Size = new System.Drawing.Size(302, 301);
            this.gameBoardDispaly1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 513);
            this.Controls.Add(this.gameBoardDispaly1);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.gamePanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button btn_startGame;
        private System.Windows.Forms.TextBox txt_player1;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gameLabel;
        private UserControls.GameBoardDispaly gameBoardDispaly1;
    }
}

