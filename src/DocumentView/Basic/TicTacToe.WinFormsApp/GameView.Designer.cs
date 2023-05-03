namespace TicTacToe.WinFormsApp;

partial class GameView
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
        tableLayoutPanel1 = new TableLayoutPanel();
        label1 = new Label();
        label4 = new Label();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button10 = new Button();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel1.Controls.Add(button2, 0, 0);
        tableLayoutPanel1.Controls.Add(button3, 1, 0);
        tableLayoutPanel1.Controls.Add(button4, 2, 0);
        tableLayoutPanel1.Controls.Add(button5, 0, 1);
        tableLayoutPanel1.Controls.Add(button6, 1, 1);
        tableLayoutPanel1.Controls.Add(button7, 2, 1);
        tableLayoutPanel1.Controls.Add(button8, 0, 2);
        tableLayoutPanel1.Controls.Add(button10, 2, 2);
        tableLayoutPanel1.Location = new Point(12, 76);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.Size = new Size(236, 144);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.BorderStyle = BorderStyle.Fixed3D;
        label1.Location = new Point(39, 9);
        label1.Name = "label1";
        label1.Size = new Size(169, 27);
        label1.TabIndex = 2;
        label1.Text = "label1";
        label1.Click += label1_Click;
        // 
        // label4
        // 
        label4.BorderStyle = BorderStyle.Fixed3D;
        label4.Location = new Point(12, 46);
        label4.Name = "label4";
        label4.Size = new Size(236, 24);
        label4.TabIndex = 6;
        label4.Text = "label4";
        // 
        // button2
        // 
        button2.Location = new Point(3, 3);
        button2.Name = "button2";
        button2.Size = new Size(72, 23);
        button2.TabIndex = 0;
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(81, 3);
        button3.Name = "button3";
        button3.Size = new Size(72, 23);
        button3.TabIndex = 1;
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(159, 3);
        button4.Name = "button4";
        button4.Size = new Size(74, 23);
        button4.TabIndex = 2;
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(3, 51);
        button5.Name = "button5";
        button5.Size = new Size(72, 23);
        button5.TabIndex = 3;
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new Point(81, 51);
        button6.Name = "button6";
        button6.Size = new Size(72, 23);
        button6.TabIndex = 4;
        button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new Point(159, 51);
        button7.Name = "button7";
        button7.Size = new Size(74, 23);
        button7.TabIndex = 5;
        button7.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        button8.Location = new Point(3, 99);
        button8.Name = "button8";
        button8.Size = new Size(72, 23);
        button8.TabIndex = 6;
        button8.UseVisualStyleBackColor = true;
        // 
        // button10
        // 
        button10.Location = new Point(159, 99);
        button10.Name = "button10";
        button10.Size = new Size(74, 23);
        button10.TabIndex = 8;
        button10.Text = "button10";
        button10.UseVisualStyleBackColor = true;
        // 
        // GameView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(260, 232);
        Controls.Add(label4);
        Controls.Add(label1);
        Controls.Add(tableLayoutPanel1);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "GameView";
        StartPosition = FormStartPosition.CenterParent;
        Text = "GameView";
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private Label label4;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button10;
}