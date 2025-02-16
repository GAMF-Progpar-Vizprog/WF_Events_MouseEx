namespace MouseEx
{
  partial class frmMain
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
			bt = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// bt
			// 
			bt.Location = new System.Drawing.Point(186, 141);
			bt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			bt.Name = "bt";
			bt.Size = new System.Drawing.Size(47, 25);
			bt.TabIndex = 0;
			bt.UseVisualStyleBackColor = true;
			bt.MouseDown += bt_MouseDown;
			bt.MouseMove += bt_MouseMove;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(495, 378);
			Controls.Add(bt);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "frmMain";
			Text = "Demonstrating mouse event handling by moving a button";
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button bt;
  }
}

