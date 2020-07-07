using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BackgroundColor = Color.PowderBlue;
            InitializeComponent();
            BindingContext = new MainPageViewModel();

            var xamagonImage = new Image { Source = "xamagonImage.png" };

            var noteEditor = new Editor
            {
                Placeholder = "Enter Note",
                BackgroundColor = Color.White,
                Margin = new Thickness(10)

            };

            noteEditor.SetBinding(Editor.TextProperty, "NoteText");

            var saveButton = new Button
            {
                Text = "Save",
                TextColor = Color.White,
                BackgroundColor = Color.Green,
                Margin = new Thickness(10)
            };

            saveButton.SetBinding(Button.CommandProperty, "SaveNoteCommand");

            var deleteButton = new Button
            {
                Text = "Delete",
                TextColor = Color.Red,
                BackgroundColor = Color.Black,
                Margin = new Thickness(10)

            };
            deleteButton.SetBinding(Button.CommandProperty, "DeleteNoteCommand");
            var collectionView = new CollectionView
            {
                ItemTemplate = new NotesTemplate()
            };
            collectionView.SetBinding(CollectionView.ItemsSourceProperty, "NotesCollection");
            var grid = new Grid
            {
                Margin=new Thickness(20,40),
                ColumnDefinitions=
                { 
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                },
                RowDefinitions=
                { 
                    new RowDefinition{Height=new GridLength(1.0,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(2.5,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1.0,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(2.0,GridUnitType.Star)},
                }
            };
            grid.Children.Add(xamagonImage, 0, 0);
            Grid.SetColumnSpan(xamagonImage, 2);
            
            grid.Children.Add(noteEditor, 0, 1);
            Grid.SetColumnSpan(noteEditor, 2);
            
            grid.Children.Add(saveButton, 0, 3);
            Grid.SetColumnSpan(saveButton, 2);

            grid.Children.Add(deleteButton, 0, 4);
            Grid.SetColumnSpan(deleteButton, 2);

            
        }
    }
}
