namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            firstCustomControl1.BringToFront();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            firstCustomControl1.BringToFront();
        }

        private void EatInBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EatInBtn.Height;
            SidePanel.Top = EatInBtn.Top;
            mySecondCustomControl1.BringToFront();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            var exitMessageBox = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (exitMessageBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}