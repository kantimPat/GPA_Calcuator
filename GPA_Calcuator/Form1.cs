namespace GPA_Calcuator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private GPA_calaulator GpaCalaulator = new();

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = this.TB_name.Text;
            string gpa = this.TB_gpa.Text;

            double dGPA = 0;
            double.TryParse(gpa, out dGPA);

            if (dGPA == 0)
                return;


            Student newStudent = new Student(studentName, dGPA);
            GpaCalaulator.setStudent(newStudent);
        
        
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
