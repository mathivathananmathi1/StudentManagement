
using System.Collections.Generic;
using System.Windows;

namespace StudentManagement
{
    public partial class MainWindow : Window
    {

        List<string> students = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtStudentName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter student name");
                return;
            }

            students.Add(name);

            txtStudentName.Clear();

            DisplayStudents();
        }

        private void btnAddRange_Click(object sender, RoutedEventArgs e)
        {
            List<string> newStudents = new List<string>()
            {
                "Arun",
                "Bala",
                "Priya",
                "Kumar",
                "Divya"
            };

            students.AddRange(newStudents);

            DisplayStudents();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (studentGrid.SelectedItem == null)
            {
                MessageBox.Show("Select a student first");
                return;
            }

            string selectedStudent =
                studentGrid.SelectedItem.ToString();

            students.Remove(selectedStudent);

            DisplayStudents();
        }

        
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            students.Clear();

            DisplayStudents();
        }

        private void DisplayStudents()
        {
            studentGrid.ItemsSource = null;
            studentGrid.ItemsSource = students;

            txtCount.Text = "Total Students: " + students.Count;
        }
    }
}
