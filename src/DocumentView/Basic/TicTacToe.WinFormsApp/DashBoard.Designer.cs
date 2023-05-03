namespace TicTacToe.WinFormsApp;

partial class DashBoard
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
        btnOpenGame = new Button();
        panel1 = new Panel();
        SuspendLayout();
        // 
        // btnOpenGame
        // 
        btnOpenGame.Location = new Point(12, 12);
        btnOpenGame.Name = "btnOpenGame";
        btnOpenGame.Size = new Size(127, 23);
        btnOpenGame.TabIndex = 0;
        btnOpenGame.Text = "Open Game";
        btnOpenGame.UseVisualStyleBackColor = true;
        btnOpenGame.Click += button1_Click;
        // 
        // panel1
        // 
        panel1.Location = new Point(12, 41);
        panel1.Name = "panel1";
        panel1.Size = new Size(300, 214);
        panel1.TabIndex = 3;
        // 
        // DashBoard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(324, 267);
        Controls.Add(panel1);
        Controls.Add(btnOpenGame);
        IsMdiContainer = true;
        Name = "DashBoard";
        Text = "DashBoard";
        ResumeLayout(false);
    }

    #endregion

    private Button btnOpenGame;
    private Panel panel1;
}