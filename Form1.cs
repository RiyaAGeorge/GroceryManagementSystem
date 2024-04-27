namespace GroceryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LoadingBar1_Click(object sender, EventArgs e)
        {
            LoadingTimer.Start();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            if (LoadingBar1.Value < 100)
            {
                LoadingBar1.Value += 1;
            }
            else
            {
                LoadingTimer.Stop();
                // Redirect to the RoleForm page
                var roleForm = new RoleForm();
                roleForm.Show();
                this.Hide(); // hide the current form
            }
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
