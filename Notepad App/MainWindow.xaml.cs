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

    }
    public partial class MainWindow : Window
    {
       
        List<Note> list_of_Notes = new List<Note>();
        
        
        
        



        public MainWindow()
        {
            InitializeComponent();

            create_note("Book review", "This book is amazing");
            create_note("Diary", "Today was a great day");
            Console.WriteLine(list_of_Notes[0].Note_Content);
            

        }
        
        public void create_note(string atittle, string acontent) 
        {
            string bttitle;
            bttitle = atittle;

            Note Notes = new Note();
            Notes.Note_Tittle = bttitle;
            Notes.Note_Content = acontent;
            list_of_Notes.Add(Notes);
                
        }







    }
}
