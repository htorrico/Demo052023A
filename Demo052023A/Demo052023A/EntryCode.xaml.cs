using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo052023A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCode : ContentPage
    {
        public EntryCode()
        {
            InitializeComponent();

            StackLayout stack=new StackLayout();
            Entry entry=new Entry();
            entry.Placeholder = "Entry por código";
            stack.Children.Add(entry);

            for (int i = 0; i < 5; i++)
            {

                Button button = new Button();
                button.Text = "Demo";
                stack.Children.Add(button);
            }
            
            
            this.Content = stack;




        }
    }
}