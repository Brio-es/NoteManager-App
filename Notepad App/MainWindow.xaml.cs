using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notepad_App
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public class Note
    {
        public string Note_Tittle;
        public string Note_Content;
        public override string ToString()
        {
            return this.Note_Tittle;
        }

    }
    public partial class MainWindow : Window
    {
        string T_Tittle, T_content;
       
        List<Note> list_of_Notes = new List<Note>();

        public MainWindow()
        {
            InitializeComponent();
                       
        }

        public void create_note(string atittle, string acontent) 
        {
            string bttitle;
            bttitle = atittle;

            Note Notes = new Note();
            Notes.Note_Tittle = bttitle;
            Notes.Note_Content = acontent;
            list_of_Notes.Add(Notes);
            List_Notes_inspace.Items.Add(Notes);
        }

        private void List_Notesxa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Add");
            create_note(Tittle_inspace.Text, Note_Content_inspace.Text);
            
        }
        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Delete");
        }

        private void Tittle_inspace_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Note_Content_inspace_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine(Note_Content_inspace.SelectedText);
        }
    }
}
