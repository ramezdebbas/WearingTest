using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace MatchingTemplate
{
    public struct Question
    {
        public string QuestionText;
        public Uri Option1Image;
        public Uri Option2Image;
        public Uri Option3Image;
        public Uri Option4Image;
        public int CorrectOption;
    }

    class QuestionsDataTable
    {
        public static List<Question> Questions;

        public static void InitQuestions()
        {
            // Question 1
            Question Question1 = new Question();
            Question1.QuestionText = "Which one of the following is men sweater?";
            Question1.Option1Image = new Uri("ms-appx:///Assets/01.png");
            Question1.Option2Image = new Uri("ms-appx:///Assets/07.png");
            Question1.Option3Image = new Uri("ms-appx:///Assets/14.png");
            Question1.Option4Image = new Uri("ms-appx:///Assets/17.png");
            Question1.CorrectOption = 1;

            // Question 2
            Question Question2 = new Question();
            Question2.QuestionText = "Which one of the following is women sweater?";
            Question2.Option1Image = new Uri("ms-appx:///Assets/08.png");
            Question2.Option2Image = new Uri("ms-appx:///Assets/02.png");
            Question2.Option3Image = new Uri("ms-appx:///Assets/15.png");
            Question2.Option4Image = new Uri("ms-appx:///Assets/22.png");
            Question2.CorrectOption = 2;

            // Question 3
            Question Question3 = new Question();
            Question3.QuestionText = "Which one of the following is men cardigan?";
            Question3.Option1Image = new Uri("ms-appx:///Assets/09.png");
            Question3.Option2Image = new Uri("ms-appx:///Assets/15.png");
            Question3.Option3Image = new Uri("ms-appx:///Assets/03.png");
            Question3.Option4Image = new Uri("ms-appx:///Assets/23.png");
            Question3.CorrectOption = 3;

            // Question 4
            Question Question4 = new Question();
            Question4.QuestionText = "Which one of the following is women cardigan?";
            Question4.Option1Image = new Uri("ms-appx:///Assets/10.png");
            Question4.Option2Image = new Uri("ms-appx:///Assets/16.png");
            Question4.Option3Image = new Uri("ms-appx:///Assets/24.png");
            Question4.Option4Image = new Uri("ms-appx:///Assets/04.png");
            Question4.CorrectOption = 4;

            // Question 5
            Question Question5 = new Question();
            Question5.QuestionText = "Which one of the following is women jumper dress?";
            Question5.Option1Image = new Uri("ms-appx:///Assets/05.png");
            Question5.Option2Image = new Uri("ms-appx:///Assets/11.png");
            Question5.Option3Image = new Uri("ms-appx:///Assets/17.png");
            Question5.Option4Image = new Uri("ms-appx:///Assets/25.png");
            Question5.CorrectOption = 1;

            // Question 6
            Question Question6 = new Question();
            Question6.QuestionText = "Which one of the following is kids jumper dress?";
            Question6.Option1Image = new Uri("ms-appx:///Assets/12.png");
            Question6.Option2Image = new Uri("ms-appx:///Assets/06.png");
            Question6.Option3Image = new Uri("ms-appx:///Assets/18.png");
            Question6.Option4Image = new Uri("ms-appx:///Assets/26.png");
            Question6.CorrectOption = 2;

            // Question 7
            Question Question7 = new Question();
            Question7.QuestionText = "Which one of the following is women tank top?";
            Question7.Option1Image = new Uri("ms-appx:///Assets/13.png");
            Question7.Option2Image = new Uri("ms-appx:///Assets/19.png");
            Question7.Option3Image = new Uri("ms-appx:///Assets/07.png");
            Question7.Option4Image = new Uri("ms-appx:///Assets/27.png");
            Question7.CorrectOption = 3;

            // Question 8
            Question Question8 = new Question();
            Question8.QuestionText = "Which one of the following is men tank top?";
            Question8.Option1Image = new Uri("ms-appx:///Assets/14.png");
            Question8.Option2Image = new Uri("ms-appx:///Assets/20.png");
            Question8.Option3Image = new Uri("ms-appx:///Assets/28.png");
            Question8.Option4Image = new Uri("ms-appx:///Assets/08.png");
            Question8.CorrectOption = 4;

            // Question 9
            Question Question9 = new Question();
            Question9.QuestionText = "Which one of the following is sweatshirt for men?";
            Question9.Option1Image = new Uri("ms-appx:///Assets/09.png");
            Question9.Option2Image = new Uri("ms-appx:///Assets/15.png");
            Question9.Option3Image = new Uri("ms-appx:///Assets/21.png");
            Question9.Option4Image = new Uri("ms-appx:///Assets/29.png");
            Question9.CorrectOption = 1;

            // Question 10
            Question Question10 = new Question();
            Question10.QuestionText = "Which one of the following is sweatshirt for women?";
            Question10.Option1Image = new Uri("ms-appx:///Assets/11.png");
            Question10.Option2Image = new Uri("ms-appx:///Assets/10.png");
            Question10.Option3Image = new Uri("ms-appx:///Assets/22.png");
            Question10.Option4Image = new Uri("ms-appx:///Assets/30.png");
            Question10.CorrectOption = 2;

            // Question 11
            Question Question11 = new Question();
            Question11.QuestionText = "Which one of the following is blouse?";
            Question11.Option1Image = new Uri("ms-appx:///Assets/12.png");
            Question11.Option2Image = new Uri("ms-appx:///Assets/23.png");
            Question11.Option3Image = new Uri("ms-appx:///Assets/11.png");
            Question11.Option4Image = new Uri("ms-appx:///Assets/01.png");
            Question11.CorrectOption = 3;

            // Question 12
            Question Question12 = new Question();
            Question12.QuestionText = "Which one of the following is capris guys?";
            Question12.Option1Image = new Uri("ms-appx:///Assets/13.png");
            Question12.Option2Image = new Uri("ms-appx:///Assets/24.png");
            Question12.Option3Image = new Uri("ms-appx:///Assets/02.png");
            Question12.Option4Image = new Uri("ms-appx:///Assets/12.png");
            Question12.CorrectOption = 4;

            // Question 13
            Question Question13 = new Question();
            Question13.QuestionText = "Which one of the following is capris for girls?";
            Question13.Option1Image = new Uri("ms-appx:///Assets/13.png");
            Question13.Option2Image = new Uri("ms-appx:///Assets/14.png");
            Question13.Option3Image = new Uri("ms-appx:///Assets/25.png");
            Question13.Option4Image = new Uri("ms-appx:///Assets/03.png");
            Question13.CorrectOption = 1;

            // Question 14
            Question Question14 = new Question();
            Question14.QuestionText = "Which one of the following is jeans for men?";
            Question14.Option1Image = new Uri("ms-appx:///Assets/15.png");
            Question14.Option2Image = new Uri("ms-appx:///Assets/14.png");
            Question14.Option3Image = new Uri("ms-appx:///Assets/26.png");
            Question14.Option4Image = new Uri("ms-appx:///Assets/04.png");
            Question14.CorrectOption = 2;

            // Question 15
            Question Question15 = new Question();
            Question15.QuestionText = "Which one of the following is jeans for women?";
            Question15.Option1Image = new Uri("ms-appx:///Assets/16.png");
            Question15.Option2Image = new Uri("ms-appx:///Assets/27.png");
            Question15.Option3Image = new Uri("ms-appx:///Assets/15.png");
            Question15.Option4Image = new Uri("ms-appx:///Assets/05.png");
            Question15.CorrectOption = 3;

            // Question 16
            Question Question16 = new Question();
            Question16.QuestionText = "Which one of the following is jackets for men?";
            Question16.Option1Image = new Uri("ms-appx:///Assets/17.png");
            Question16.Option2Image = new Uri("ms-appx:///Assets/28.png");
            Question16.Option3Image = new Uri("ms-appx:///Assets/06.png");
            Question16.Option4Image = new Uri("ms-appx:///Assets/16.png");
            Question16.CorrectOption = 4;

            // Question 17
            Question Question17 = new Question();
            Question17.QuestionText = "Which one of the following is jackets for women?";
            Question17.Option1Image = new Uri("ms-appx:///Assets/17.png");
            Question17.Option2Image = new Uri("ms-appx:///Assets/18.png");
            Question17.Option3Image = new Uri("ms-appx:///Assets/29.png");
            Question17.Option4Image = new Uri("ms-appx:///Assets/07.png");
            Question17.CorrectOption = 1;

            // Question 18
            Question Question18 = new Question();
            Question18.QuestionText = "Which one of the following is shirt for men?";
            Question18.Option1Image = new Uri("ms-appx:///Assets/19.png");
            Question18.Option2Image = new Uri("ms-appx:///Assets/18.png");
            Question18.Option3Image = new Uri("ms-appx:///Assets/30.png");
            Question18.Option4Image = new Uri("ms-appx:///Assets/08.png");
            Question18.CorrectOption = 2;

            // Question 19
            Question Question19 = new Question();
            Question19.QuestionText = "Which one of the following is shirt for women?";
            Question19.Option1Image = new Uri("ms-appx:///Assets/20.png");
            Question19.Option2Image = new Uri("ms-appx:///Assets/01.png");
            Question19.Option3Image = new Uri("ms-appx:///Assets/19.png");
            Question19.Option4Image = new Uri("ms-appx:///Assets/09.png");
            Question19.CorrectOption = 3;

            // Question 20
            Question Question20 = new Question();
            Question20.QuestionText = "Which one of the following is t-shirt for women?";
            Question20.Option1Image = new Uri("ms-appx:///Assets/21.png");
            Question20.Option2Image = new Uri("ms-appx:///Assets/02.png");
            Question20.Option3Image = new Uri("ms-appx:///Assets/11.png");
            Question20.Option4Image = new Uri("ms-appx:///Assets/20.png");
            Question20.CorrectOption = 4;

            Questions = new List<Question>() { Question1, Question2, Question3, Question4, Question5,
                                               Question6, Question7, Question8, Question9, Question10,
                                               Question11, Question12, Question13, Question14, Question15,
                                               Question16, Question17, Question18, Question19, Question20};
        }
    }
}