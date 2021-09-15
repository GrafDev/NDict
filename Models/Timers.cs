using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Windows.Media;
using System.Windows.Threading;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NDict.ViewModels;
using NDict.Models;
using NDict.Views.Windows;
using NDict.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Data;

namespace NDict.Models
{
    static internal class Timers
    {
        static private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        static private Stopwatch stopwatch;
        static private int startTimer = 3;
        static private bool isMainTime;


        // static Test.WindowWords testWindow = new Test.WindowWords();



        static internal void Start()
        {
            stopwatch = new Stopwatch();
            isMainTime = false;
            App.MainVM.Text_Button_Play="";
            App.MainVM.Text_Button_Close = "Stop";
            App.MainVM.FlagButtonClose = false;
            SetContentAligmentPlayButton("Left");
            stopwatch.Start();
            Thread.Sleep(50);
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            int tempMilliSecond = 5;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, tempMilliSecond);
            dispatcherTimer.Start();

            void DispatcherTimer_Tick(object sender, EventArgs e)
            {
                TimeSpan _time = stopwatch.Elapsed;
                if (isMainTime)
                {
                    App.MainVM.Text_Button_Play = string.Format("{00:}: {01:00}:{02:00}", _time.Minutes, _time.Seconds, _time.Milliseconds / 10);//Таймер затраченого времени mainTime=true
                }

                else //Таймер обратного отсчета mainTime=false
                {
                    int _seconds = startTimer - _time.Seconds;
                    if (_seconds >= 0) //отсчет таймера
                    {
                        App.MainVM.Text_Button_Play = string.Format(" {0:0}", _seconds);
                    }
                    else
                    {
                        EndDownTimer();   
                    }
                }

            }
            void EndDownTimer()
            {
                isMainTime = true;
                stopwatch.Restart();
            }
        }

        static internal void Stop()
        {
            SetContentAligmentPlayButton("Center");
            App.MainVM.Text_Button_Close = "Close";
            App.MainVM.FlagButtonClose = true;
            stopwatch.Restart();
            stopwatch.Stop();
            dispatcherTimer.Stop();
        }
        static internal void ShowTime()
        {
            TimeSpan _time = stopwatch.Elapsed;
            var _tempText=string.Format("{00:}: {1:00}:{2:00}", _time.Minutes, _time.Seconds, _time.Milliseconds / 10);
            App.MainVM.labelFirstWordOfQuestion = _tempText;
            App.MainVM.labelSecondWordOfQuestion = "";            
            App.MainVM.Text_Button_Play=Players.CurrentUser.TypeGame==0?"Train":"Play";
        }

        static private void SetContentAligmentPlayButton(String _text)
        {
            foreach (Window window in App.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    if (_text == "Left")
                    {
                        (window as MainWindow).Button_Play.HorizontalContentAlignment = HorizontalAlignment.Left;
                    }
                    else
                    {
                        (window as MainWindow).Button_Play.HorizontalContentAlignment = HorizontalAlignment.Center;
                    }
                    
                }
            }
        }
        
    }
}
