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

namespace Millioner;


public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
        QuestionData q = new QuestionData();
        q.AddQuestionsToList();
        this.questionBox.Text = q.questionList[0];
        this.buttonA.Content += q.answerList[0];
        this.buttonB.Content += q.answerList[1];
        this.buttonC.Content += q.answerList[2];
        this.buttonD.Content += q.answerList[3];
               
    }

    public void ButtonStart_Click(object sender, RoutedEventArgs e)
    {
        this.Loqopic.Visibility = Visibility.Hidden;
        this.buttonStart.Visibility = Visibility.Hidden;
    }
}
