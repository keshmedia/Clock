using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Clock
{
 public partial class MainWindow : Window
    {
   public MainWindow()
        {
 InitializeComponent();

 Storyboard seconds = (Storyboard)second.FindResource("sbseconds");
 seconds.Begin();
 seconds.Seek(new TimeSpan(0, 0, 0, 
 DateTime.Now.Second, 0));

 Storyboard minutes = (Storyboard)minute.FindResource("sbminutes");
 minutes.Begin();
 minutes.Seek(new TimeSpan(0, 0, DateTime.Now.Minute, 
DateTime.Now.Second, 0));

 Storyboard hours = (Storyboard)hour.FindResource("sbhours");
 hours.Begin();
 hours.Seek(new TimeSpan(0, DateTime.Now.Hour, 
DateTime.Now.Minute, DateTime.Now.Second, 0));
 }
 private void Window_MouseDown(object sender, 
MouseButtonEventArgs e)
 {
 {
  try
  {
      DragMove();
  }
  catch
  {
      MessageBox.Show("Paddy O'Riordan");
  } }}  }}  // THE C# CODE /////
