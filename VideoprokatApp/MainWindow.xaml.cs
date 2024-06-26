using System;
using System.Data.Entity;
using System.Windows;

namespace VideoprokatApp
{
    public partial class MainWindow : Window
    {
        private Exam10Entities1 _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new Exam10Entities1();
            _context.Videoteka.Include(v => v.ID_Film).Load();
            VideotekaDataGrid.ItemsSource = _context.Videoteka.Local;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var window = new AddEditWindow();
                if (window.ShowDialog() == true)
                {
                    _context.Videoteka.Add(window.Videoteka);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var selected = (Videoteka)VideotekaDataGrid.SelectedItem;
            if (selected != null)
            {
                try
                {
                    var window = new AddEditWindow(selected);
                    if (window.ShowDialog() == true)
                    {
                        _context.Entry(selected).State = EntityState.Modified;
                        _context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при редактировании записи: {ex.Message}");
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selected = (Videoteka)VideotekaDataGrid.SelectedItem;
            if (selected != null)
            {
                try
                {
                    _context.Videoteka.Remove(selected);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении записи: {ex.Message}");
                }
            }
        }
    }
}
