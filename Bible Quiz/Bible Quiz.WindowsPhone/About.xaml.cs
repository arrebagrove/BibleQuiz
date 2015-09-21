using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Bible_Quiz
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();

            aboutTheGame.Text = " Old Testament Bible Quiz-VERSION 1"+"\n"+
                                  "An easy-to-use app for testing your ability to answer some of the Old Testament Bible questions."+"\n"+ 
                                  "The score is accumulated as you progress. After answering the last question, you are taken to"+"\n"+
                                  "the results page to see your final score. While on this page, you can either choose Play Again "+"\n"+
                                  "or Quit."+
                                  "This app is self-contained and does not require an internet connection. It is an excellent app"+"\n"+ 
                                  "for kids, individual students and even adults."+"\n"+

                                  "James Ngondo - Copyright 2015"+"\n"+
                                  "jamesngondo2013@outlook.com" + "\n" +
                                 " Facebook: Jay Ngondo";

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
