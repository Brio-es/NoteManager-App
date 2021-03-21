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
        string c_Tittle, c_content;
        int current_index;

        List<Note> list_of_Notes = new List<Note>();

        public MainWindow()
        {
            InitializeComponent();
            create_note("new note", "this is the content of the new note");

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

        public void change_t_c_content()
        {
            if (current_index != -1)
            {
                c_Tittle = list_of_Notes[current_index].Note_Tittle;
                c_content = list_of_Notes[current_index].Note_Content;


                Console.WriteLine(c_Tittle);
                Console.WriteLine(c_content);


                clearall();

                Tittle_inspace.Text = c_Tittle;
                Note_Content_inspace.Text = c_content;

            }



        }

        public void clearall()
        {
            Tittle_inspace.Clear();
            Note_Content_inspace.Clear();
        }

        private void List_Notes_inspace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(List_Notes_inspace.SelectedIndex);
            current_index = List_Notes_inspace.SelectedIndex;
            change_t_c_content();

        }

        public void Update_Note() 
        {
            if (current_index != -1) 
            {
                list_of_Notes.RemoveAt(current_index);
                List_Notes_inspace.Items.RemoveAt(current_index);
                create_note(Tittle_inspace.Text, Note_Content_inspace.Text);


            }
                


        }


        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Add");
            create_note(Tittle_inspace.Text, Note_Content_inspace.Text);
            clearall();
            
        }
        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Delete");
            list_of_Notes.RemoveAt(current_index);
            List_Notes_inspace.Items.RemoveAt(current_index);
            clearall();


        }

        
        private void Save_button_Click(object sender, RoutedEventArgs e)
        {
            Update_Note();
        }

        private void Note_Content_inspace_TextChanged(object sender, TextChangedEventArgs e)
        {
               
        }
        private void Tittle_inspace_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
