namespace first_window_app
{
    public partial class Frmcalc : Form

     
    {
        public Frmcalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button btnClick=  (Button) sender;
            // this.label1.Text = "done you clicked";
            MessageBox.Show(textBox1.Text);

        }

        private void Frmcalc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
