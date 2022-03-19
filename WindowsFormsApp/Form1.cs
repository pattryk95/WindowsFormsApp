using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            studenciListBox.ValueMember = "FullName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imieTextBox.Text) || string.IsNullOrWhiteSpace(nazwiskoTextBox.Text))
            {
                MessageBox.Show("Pola nie mog¹ byæ puste");
                return;
            }
            Student nowyStudent = new Student();
            nowyStudent.Imie = imieTextBox.Text;
            nowyStudent.Nazwisko = nazwiskoTextBox.Text;

            studenciListBox.Items.Add(nowyStudent);

            imieTextBox.Text = "";
            nazwiskoTextBox.Text = "";
        }

    }
}