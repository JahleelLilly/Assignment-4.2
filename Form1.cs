namespace Assignment_4._2
{
    public partial class AccountLogin : Form
    {
        List<Student> StudentList = new List<Student>();


        public AccountLogin()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

            FinalForm accountLogin = new FinalForm();
            accountLogin.ShowDialog();


        }

        private void AddStudentbutton_Click(object sender, EventArgs e)
        {
            Add_Student_Form add_Student_Form = new Add_Student_Form();
            add_Student_Form.ShowDialog();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
