using ValidationAttribute;

namespace FormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new() { Name = txtName.Text, Surname = txtSurname.Text };

            bool result = ValidationTool.Validate(user);
            MessageBox.Show(result ? "Validasyon baþarýlý!" : "Validasyon baþarýsýz! Zorunlu alanlarý doldurun.");

        }
    }
}
