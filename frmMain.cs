using System.Drawing;
using System.Windows.Forms;

namespace WF_Events_MouseEx
{
	public partial class frmMain : Form
  {
    private Point MPosition;
    public frmMain()
    {
      InitializeComponent();
    }
   
    private void bt_MouseDown(object sender, MouseEventArgs e)
    {
			// Query the initial mouse position if the user pressed the left button.
			if (e.Button == MouseButtons.Left)
        MPosition = System.Windows.Forms.Control.MousePosition;

    }

    private void bt_MouseMove(object sender, MouseEventArgs e)
    {
      // Move the button if the left mouse button is still pressed.
      if (e.Button == MouseButtons.Left)
      {
        // Query the new mouse position.
        Point NewPosition = System.Windows.Forms.Control.MousePosition;
        // Calculate movement.
        int dx = NewPosition.X - MPosition.X;
        int dy= NewPosition.Y - MPosition.Y;
        // Move button.
        bt.Left += dx;
        bt.Top += dy;
        // The current position will be the new initial position.
        MPosition = NewPosition;
      }
    }
  }
}
