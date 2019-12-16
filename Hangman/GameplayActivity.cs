using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Hangman
{
    [Activity(Label = "GameplayActivity")]
    public class GameplayActivity : Activity
    {protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Sets screen to gameplay view
            SetContentView(Resource.Layout.Gameplay);

            //Views and variables
            string Word;
            TextView WordDisplay;
            ImageView HangmanPicture;
            WordDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);
            HangmanPicture = FindViewById<ImageView>(Resource.Id.imgHangman);
            Random WordPicker = new Random();
            int Result = WordPicker.Next(1, 11);
            int Lives = 6;

            var ButtonA = FindViewById<Button>(Resource.Id.btnA);
            var ButtonB = FindViewById<Button>(Resource.Id.btnB);
            var ButtonC = FindViewById<Button>(Resource.Id.btnC);
            var ButtonD = FindViewById<Button>(Resource.Id.btnD);
            var ButtonE = FindViewById<Button>(Resource.Id.btnE);
            var ButtonF = FindViewById<Button>(Resource.Id.btnF);
            var ButtonG = FindViewById<Button>(Resource.Id.btnG);
            var ButtonH = FindViewById<Button>(Resource.Id.btnH);
            var ButtonI = FindViewById<Button>(Resource.Id.btnI);
            var ButtonJ = FindViewById<Button>(Resource.Id.btnJ);
            var ButtonK = FindViewById<Button>(Resource.Id.btnK);
            var ButtonL = FindViewById<Button>(Resource.Id.btnL);
            var ButtonM = FindViewById<Button>(Resource.Id.btnM);
            var ButtonN = FindViewById<Button>(Resource.Id.btnN);
            var ButtonO = FindViewById<Button>(Resource.Id.btnO);
            var ButtonP = FindViewById<Button>(Resource.Id.btnP);
            var ButtonQ = FindViewById<Button>(Resource.Id.btnQ);
            var ButtonR = FindViewById<Button>(Resource.Id.btnR);
            var ButtonS = FindViewById<Button>(Resource.Id.btnS);
            var ButtonT = FindViewById<Button>(Resource.Id.btnT);
            var ButtonU = FindViewById<Button>(Resource.Id.btnU);
            var ButtonV = FindViewById<Button>(Resource.Id.btnV);
            var ButtonW = FindViewById<Button>(Resource.Id.btnW);
            var ButtonX = FindViewById<Button>(Resource.Id.btnX);
            var ButtonY = FindViewById<Button>(Resource.Id.btnY);
            var ButtonZ = FindViewById<Button>(Resource.Id.btnZ);

            //Randomly selects one of ten possible words to be guessed
            void WhichWord()
            {
                switch(Result)
                {
                    case 1:
                        Word = "VANITY";
                        break;
                    case 2:
                        Word = "MEANINGLESSNESS";
                        break;
                    case 3:
                        Word = "EMPTINESS";
                        break;
                    case 4:
                        Word = "SUFFERING";
                        break;
                    case 5:
                        Word = "WILL";
                        break;
                    case 6:
                        Word = "GERMANS";
                        break;
                    case 7:
                        Word = "KANT";
                        break;
                    case 8:
                        Word = "NOISE";
                        break;
                    case 9:
                        Word = "WOMEN";
                        break;
                    case 10:
                        Word = "REPRESENTATION";
                        break;
                    default:
                        Word = "bug";
                        break;
                }
            }

            WhichWord();

            //Creates and displays a line of placeholder characters for the word to be guessed
            WordDisplay.Text = new string('X', Word.Length);

            void BtnClick(object sender, EventArgs e)
            {
                Button thisButton = sender as Button;

                //Checks if word contains clicked letter
                if (Word.Contains(thisButton.Text) == false)
                {
                    //Removes a life
                    Lives = --Lives;

                    //Updates hangman image
                    if (Lives == 5) HangmanPicture.SetImageResource(Resource.Drawable.Hangman1);
                    else if (Lives == 4) HangmanPicture.SetImageResource(Resource.Drawable.Hangman2);
                    else if (Lives == 3) HangmanPicture.SetImageResource(Resource.Drawable.Hangman3);
                    else if (Lives == 2) HangmanPicture.SetImageResource(Resource.Drawable.Hangman4);
                    else if (Lives == 1) HangmanPicture.SetImageResource(Resource.Drawable.Hangman5);
                    else if (Lives == 0)
                    {
                        HangmanPicture.SetImageResource(Resource.Drawable.Hangman6);
                        System.Threading.Thread.Sleep(1000);
                        Intent activity = new Intent(this, typeof(LoseActivity));
                        StartActivity(activity);
                    }
                }
 
                //Updates displayed word when a letter is guessed correctly
                else
                {
                    var WordDisplayArray = WordDisplay.Text.ToCharArray();
                    var WordArray = Word.ToCharArray();
                    for (int i = 0; i < Word.Length; i++)
                    {
                        if (WordArray[i].ToString() == thisButton.Text)
                        {
                            WordDisplayArray[i] = Convert.ToChar(thisButton.Text);
                        }
                    }

                    var newDisplayText = new string(WordDisplayArray);

                    WordDisplay.Text = newDisplayText;
                    if (WordDisplay.Text == Word)
                    {
                        Intent activity = new Intent(this, typeof(WinActivity));
                        StartActivity(activity);
                    }
                }
            }

            ButtonA.Click += BtnClick;
            ButtonB.Click += BtnClick;
            ButtonC.Click += BtnClick;
            ButtonD.Click += BtnClick;
            ButtonE.Click += BtnClick;
            ButtonF.Click += BtnClick;
            ButtonG.Click += BtnClick;
            ButtonH.Click += BtnClick;
            ButtonI.Click += BtnClick;
            ButtonJ.Click += BtnClick;
            ButtonK.Click += BtnClick;
            ButtonL.Click += BtnClick;
            ButtonM.Click += BtnClick;
            ButtonN.Click += BtnClick;
            ButtonO.Click += BtnClick;
            ButtonP.Click += BtnClick;
            ButtonQ.Click += BtnClick;
            ButtonR.Click += BtnClick;
            ButtonS.Click += BtnClick;
            ButtonT.Click += BtnClick;
            ButtonU.Click += BtnClick;
            ButtonV.Click += BtnClick;
            ButtonW.Click += BtnClick;
            ButtonX.Click += BtnClick;
            ButtonY.Click += BtnClick;
            ButtonZ.Click += BtnClick;
        }
    }
}