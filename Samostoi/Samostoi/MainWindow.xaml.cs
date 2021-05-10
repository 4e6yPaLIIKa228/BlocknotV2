using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using Microsoft.Win32;
using System.Windows.Controls.Primitives;




namespace Samostoi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public static RoutedCommand Some_Command = new RoutedCommand();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 2; i < 74; i++)
                cbFS.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48,52,65, 72 };
               cbFF.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            BtnTextMin.Visibility = Visibility.Hidden;
            BtnTextBlack.Visibility = Visibility.Hidden;
            BtnTextCyp.Visibility = Visibility.Hidden;
            BtnTextZap.Visibility = Visibility.Hidden;
            BtnTextBack.Visibility = Visibility.Hidden;
            BtnTextUp.Visibility = Visibility.Hidden;
            gg.Visibility = Visibility.Hidden;
            Texbx1.Visibility = Visibility.Hidden;
            _2312.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) //открытие документа
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                        doc.Load(fs, DataFormats.Rtf);
                    else if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".txt")
                        doc.Load(fs, DataFormats.Text);
                    else
                        doc.Load(fs, DataFormats.Xaml);
                }
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)//сохранение файла
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                        doc.Save(fs, DataFormats.Rtf);
                    else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                        doc.Save(fs, DataFormats.Text);
                    else
                        doc.Save(fs, DataFormats.Xaml);
                }
            }
            
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e) //Новый документ
        {
            if (new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd).Text.Length > 1) 
            {
                MessageBoxResult result = MessageBox.Show("Сохранить документ?", "Предупрежение", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                     SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                   if (sfd.ShowDialog() == true)
                   {
                            TextRange doc = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);
                            using (FileStream fs = File.Create(sfd.FileName))
                            {
                                if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                                    doc.Save(fs, DataFormats.Rtf);
                                else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                                    doc.Save(fs, DataFormats.Text);
                                else
                                    doc.Save(fs, DataFormats.Xaml);
                            }
                   }
                                    break;
                        case MessageBoxResult.No:
                        RichTxBox.Document.Blocks.Clear();
                        break;
                }

            }
            
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e) //Оtмена действий 
        {
            RichTxBox.Undo();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e) //Вырезать
        {
            RichTxBox.Cut();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)//Повторить
        {
            
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)//Крпировать
        {
            RichTxBox.Copy();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)//Всtавить
        {
            RichTxBox.Paste();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)//Выбрать все
        {
            RichTxBox.SelectAll();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)//Вырезать(картинка)
        {
            RichTxBox.Cut();
        }

        private void Image_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)//Увелечение шрифта(картинка)
        {
            RichTxBox.FontSize += 2;
        }

        private void Image_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)//Всавить(картинка)
        {
            RichTxBox.Paste();
        }  
        private void Image_MouseLeftButtonUp_4(object sender, MouseButtonEventArgs e)
        {
            if (new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd).Text.Length > 1)
            {
                MessageBoxResult result = MessageBox.Show("Сохранить документ?", "Предупрежение", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                        if (sfd.ShowDialog() == true)
                        {
                            TextRange doc = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);
                            using (FileStream fs = File.Create(sfd.FileName))
                            {
                                if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                                    doc.Save(fs, DataFormats.Rtf);
                                else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                                    doc.Save(fs, DataFormats.Text);
                                else
                                    doc.Save(fs, DataFormats.Xaml);
                            }
                        }
                        break;
                    case MessageBoxResult.No:
                        RichTxBox.Document.Blocks.Clear();
                        break;
                }
            }
        }
         private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.N)
            {
                if (new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd).Text.Length > 1)
                {
                    MessageBoxResult result = MessageBox.Show("Сохранить документ?", "Предупрежение", MessageBoxButton.YesNo);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                      SaveFileDialog sfd = new SaveFileDialog();
                       sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                       if (sfd.ShowDialog() == true)
                       {
                         TextRange doc = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);
                         using (FileStream fs = File.Create(sfd.FileName))
                            {
                                    if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                                        doc.Save(fs, DataFormats.Rtf);
                                    else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                                        doc.Save(fs, DataFormats.Text);
                                    else
                                        doc.Save(fs, DataFormats.Xaml);
                                }
                        }
                     break;
                     case MessageBoxResult.No:
                     RichTxBox.Document.Blocks.Clear();
                     break;
                    }
                }
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.O)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == true)
                {
                    TextRange doc = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                            doc.Load(fs, DataFormats.Rtf);
                        else if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".txt")
                            doc.Load(fs, DataFormats.Text);
                        else
                            doc.Load(fs, DataFormats.Xaml);
                    }
                }
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.S)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sfd.ShowDialog() == true)
                {
                    TextRange doc = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);
                    using (FileStream fs = File.Create(sfd.FileName))
                    {
                        if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                            doc.Save(fs, DataFormats.Rtf);
                        else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                            doc.Save(fs, DataFormats.Text);
                        else
                            doc.Save(fs, DataFormats.Xaml);
                    }
                }
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.Z)
            {
                RichTxBox.Undo();
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.X)
            {
                RichTxBox.Cut();
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.C)
            {
                RichTxBox.Copy();
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.V)
            {
                RichTxBox.Paste();
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.A)
            {
                RichTxBox.SelectAll();
            }
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.P)
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    FlowDocument printDoc = RichTxBox.Document;//документ, который печатаем
                    printDialog.PrintDocument(((IDocumentPaginatorSource)printDoc).DocumentPaginator, "A flow Document");
                    return;
                }
            }
        }

        private void Image_MouseLeftButtonUp_3(object sender, MouseButtonEventArgs e) //Не работает
        {
            // if ((DateTime.Now.ToString("HH:mm") == "15:00"))
            //{
            //
            //try
            // {

            // string Str = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd).Text;
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.mail.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("sasha-pushkarev-01@mail.ru", "25072010CFIF");
            string from = Texbx1.Text;
            string to = Texbx1_Copy.Text;
            string subject = "Проверка клавиатуры";
            string text = "В ходе проверки клавиатуры, я имею такие данные: ";
            MailMessage message = new MailMessage(from, to, subject, text);
           // Attachment sendfile = new Attachment(file);
           // message.Attachments.Add(sendfile);
            client.Send(message);


            //  }
            // catch { }
            // }
        }
        void ApplyPropertyValueToSelectedText(DependencyProperty formattingProperty, object value)
        {
            if (value == null)
                return;
            RichTxBox.Selection.ApplyPropertyValue(formattingProperty, value);
        }
        private void FontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ApplyPropertyValueToSelectedText(TextElement.FontSizeProperty, e.AddedItems[0]);
            }
            catch (Exception) { }
        }

        private void FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                FontFamily editValue = (FontFamily)e.AddedItems[0];
                ApplyPropertyValueToSelectedText(TextElement.FontFamilyProperty, editValue);
            }
            catch (Exception) { }
        }
        void UpdateItemCheckedState(ToggleButton button, DependencyProperty formattingProperty, object expectedValue)
        {
            object currentValue = RichTxBox.Selection.GetPropertyValue(formattingProperty);
            button.IsChecked = (currentValue == DependencyProperty.UnsetValue) ? false : currentValue != null && currentValue.Equals(expectedValue);
        }

        private void UpdateSelectedFontFamily()
        {
            object value = RichTxBox.Selection.GetPropertyValue(TextElement.FontFamilyProperty);
            FontFamily currentFontFamily = (FontFamily)((value == DependencyProperty.UnsetValue) ? null : value);
            if (currentFontFamily != null)
            {
                cbFF.SelectedItem = currentFontFamily;
            }
        }
        private void UpdateSelectedFontSize()
        {
            object value = RichTxBox.Selection.GetPropertyValue(TextElement.FontSizeProperty);
            cbFS.SelectedValue = (value == DependencyProperty.UnsetValue) ? null : value;
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument printDoc = RichTxBox.Document;//документ, который печатаем
                printDialog.PrintDocument(((IDocumentPaginatorSource)printDoc).DocumentPaginator, "Документ потока");
                return;
            }
        }


        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
           // SetWin f = new SetWin();
          //  f.Show();
        }

        private void BtnTextMin_Click(object sender, RoutedEventArgs e)
        {
            RichTxBox.FontSize -= 2;
        }

        private void BtnTextBlack_Click(object sender, RoutedEventArgs e)
        {
            RichTxBox.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
            
        }

        private void BtnTextCyp_Click(object sender, RoutedEventArgs e)//Наработки
        {
            //RichTxBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, FontStyles.Italic); 
            // <MenuItem Header="Повторить" Click="MenuItem_Click_6" >
                  //  < MenuItem.Icon >
                        //< Image Source = "img/repeat_8461.png" ></ Image >
 
                    // </ MenuItem.Icon >

                 //</ MenuItem >
             //var textRange = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd);

            // string Str = new TextRange(RichTxBox.Document.ContentStart, RichTxBox.Document.ContentEnd).Text;
          // Str.ToUpper();
          

          //  MessageBox.Show("22");
        }

        private void BtnTextZap_Click(object sender, RoutedEventArgs e)
        {
            RichTxBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Strikethrough);
        }

        private void BtnTextBack_Click(object sender, RoutedEventArgs e)
        {
            // RichTxBox.Undo();
            RichTxBox.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Normal);
            RichTxBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            BtnTextBlack.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            BtnTextBlack.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            BtnTextZap.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            BtnTextZap.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            BtnTextUp.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
        {
            BtnTextUp.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            BtnTextBack.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked_3(object sender, RoutedEventArgs e)
        {
            BtnTextBack.Visibility = Visibility.Hidden;
        }

        private void BtnTextUp_Click(object sender, RoutedEventArgs e)
        {
            RichTxBox.FontSize += 2;
        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            BtnTextMin.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked_4(object sender, RoutedEventArgs e)
        {
            BtnTextMin.Visibility = Visibility.Hidden;
        }
    }
}
