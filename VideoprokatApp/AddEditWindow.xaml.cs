using System.Windows;

namespace VideoprokatApp
{
    public partial class AddEditWindow : Window
    {
        public Exam10Entities1 Videoteka { get; set; }

        public AddEditWindow()
        {
            InitializeComponent();
            Videoteka = new Exam10Entities1();
            DataContext = Videoteka;
        }

        public AddEditWindow(Exam10Entities1 videoteka) : this()
        {
            Videoteka = videoteka;
            DataContext = Videoteka;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
