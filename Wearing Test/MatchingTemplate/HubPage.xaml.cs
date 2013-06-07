using MatchingTemplate.EnableLiveTile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace MatchingTemplate
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class HubPage : MatchingTemplate.Common.LayoutAwarePage
    {
        int QuestionNo = 0;
        int CorrectOption = 1;
        List<Question> Questions;

        int tCorrect, tWrong, tTime;
     
        bool CloseStoryBoardVisibility;
        DispatcherTimer tmrClosePopup;
        DispatcherTimer tmrTime;

        public HubPage()
        {
            this.InitializeComponent();
            QuestionsDataTable.InitQuestions();
            Questions = QuestionsDataTable.Questions;
            tWrong = 0;
            tCorrect = 0;
            tTime = 0;
            CloseStoryBoardVisibility = false;
            iPlayButton.IsEnabled = false;

            tmrClosePopup = new DispatcherTimer();
            tmrTime = new DispatcherTimer();
            
            tmrClosePopup.Interval = TimeSpan.FromSeconds(2);
            tmrTime.Interval = TimeSpan.FromSeconds(1);

            tmrClosePopup.Tick += tmrClosePopup_Tick;
            tmrTime.Tick += tmrTime_Tick;
        }

        void tmrTime_Tick(object sender, object e)
        {
            tTime++;
            iTimerDetail.Text = TimeString(tTime);
        }

        string TimeString(long seconds)
        {
            int hh = Convert.ToInt32(seconds / 3600);
            int mm = Convert.ToInt32((seconds / 60) % 60);
            int ss = Convert.ToInt32(seconds % 60);
            return ((hh == 0) ? "" : hh.ToString("00") + ":") + mm.ToString("00") + ":" + ss.ToString("00");
        }

        void tmrClosePopup_Tick(object sender, object e)
        {
            tmrClosePopup.Stop();
            Correct_Tapped(null, null);
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            CreateLiveTile.ShowliveTile(true, "Wearing Test");
            InitNextQuestion();
            tmrTime.Start();
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void Flag1_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e) { InitAnswerDialog(1); }

        private void Flag2_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e) { InitAnswerDialog(2); }

        private void Flag3_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e) { InitAnswerDialog(3); }

        private void Flag4_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e) { InitAnswerDialog(4); }

        private void Correct_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            tmrClosePopup.Stop();
            CloseStoryBoardVisibility = false;
            CorrectStoryBoardClose.Begin();
            InitNextQuestion();
        }

        void InitAnswerDialog(int Option)
        {
            if (CloseStoryBoardVisibility)
            {
                Correct_Tapped(null, null);
                return;
            }

            CloseStoryBoardVisibility = true;

            if (Option == CorrectOption)
            {
                iCorrectImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                iWrongImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                iAnswerStatus.Text = "Correct";
                tCorrect++;
            }
            else
            {
                iCorrectImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                iWrongImage.Visibility = Windows.UI.Xaml.Visibility.Visible;
                iAnswerStatus.Text = "Wrong";
                tWrong ++;
            }
            CorrectStoryBoard.Begin();
            tmrClosePopup.Start();
        }

        void InitNextQuestion()
        {
            if (QuestionNo >= 20)
            {
                InitCompleteDialog();
                return;
            }
            QuestionNo++;
            Question Current = Questions[QuestionNo - 1];
            iQuestion.Text = Current.QuestionText;
            CorrectOption = Current.CorrectOption;
            (iChoice1.ImageSource as BitmapImage).UriSource = Current.Option1Image;
            (iChoice2.ImageSource as BitmapImage).UriSource = Current.Option2Image;
            (iChoice3.ImageSource as BitmapImage).UriSource = Current.Option3Image;
            (iChoice4.ImageSource as BitmapImage).UriSource = Current.Option4Image;
        }

        void InitCompleteDialog()
        {
            tmrTime.Stop();
            this.Frame.Navigate(typeof(ResultPage),
                new int[] {tCorrect, tWrong, tTime});
        }

        void OnPlayClick(object sender, RoutedEventArgs e)
        {
            tmrTime.Start();
            iPauseButton.IsEnabled = true;
            iPlayButton.IsEnabled = false;
            iQuestionBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            iPauseBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        void OnPauseClick(object sender, RoutedEventArgs e)
        {
            tmrTime.Stop();
            iPauseButton.IsEnabled = false;
            iPlayButton.IsEnabled = true;
            iQuestionBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            iPauseBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        void OnStopClick(object sender, RoutedEventArgs e)
        {
            tmrTime.Stop();
            iTimerDetail.Text = TimeString(0);
            tTime = 0;
            tmrTime.Start();
            QuestionNo = 0;
            InitNextQuestion();
        }
    }
}
