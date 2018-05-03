using Prism.Commands;
using System;
using System.Timers;
using System.Windows;
using System.Windows.Input;

namespace SpeedofMath2
{
    class MainViewModel : ViewModelBase
    {
        #region Members
        public int ans { get; private set; }
        public int count { get; private set; }
        public Timer timer = new Timer(5000);

        private bool _startVisible;
        public bool startVisible
        {
            get { return _startVisible; }
            set { SetProperty(ref _startVisible, value); }
        }

        private bool _titleVisible;
        public bool titleVisible
        {
            get { return _titleVisible; }
            set { SetProperty(ref _titleVisible, value); }
        }

        private bool _button1Visible;
        public bool button1Visible
        {
            get { return _button1Visible; }
            set { SetProperty(ref _button1Visible, value); }
        }
        private bool _button2Visible;
        public bool button2Visible
        {
            get { return _button2Visible; }
            set { SetProperty(ref _button2Visible, value); }
        }
        private bool _button3Visible;
        public bool button3Visible
        {
            get { return _button3Visible; }
            set { SetProperty(ref _button3Visible, value); }
        }

        private bool _qTextVisible;
        public bool qTextVisible
        {
            get { return _qTextVisible; }
            set { SetProperty(ref _qTextVisible, value); }
        }

        private bool _exitButtonVisible;
        public bool exitButtonVisible
        {
            get { return _exitButtonVisible; }
            set { SetProperty(ref _exitButtonVisible, value); }
        }


        private int _number1;
        public int number1
        {
            get { return _number1; }
            set { SetProperty(ref _number1, value); }
        }
        private int _number2;
        public int number2
        {
            get { return _number2; }
            set { SetProperty(ref _number2, value); }
        }
        private string _streak;
        public string streak
        {
            get { return _streak; }
            set { SetProperty(ref _streak, value); }
        }

        private int _buttonText1;
        public int buttonText1
        {
            get { return _buttonText1; }
            set { SetProperty(ref _buttonText1, value); }
        }
        private int _buttonText2;
        public int buttonText2
        {
            get { return _buttonText2; }
            set { SetProperty(ref _buttonText2, value); }
        }
        private int _buttonText3;
        public int buttonText3
        {
            get { return _buttonText3; }
            set { SetProperty(ref _buttonText3, value); }
        }

        private string _qOutput;
        public string qOutput
        {
            get { return _qOutput; }
            set { SetProperty(ref _qOutput, value); }
        }

        private int _time = 5;
        public int time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        private int _oldTime = 5;
        public int oldTime
        {
            get { return _oldTime; }
            set { SetProperty(ref _oldTime, value); }
        }

        private bool _all = true;
        public bool all
        {
            get { return _all; }
            set { SetProperty(ref _all, value); }
        }

        private int _math;
        public int math
        {
            get { return _math; }
            set { SetProperty(ref _math, value); }
        }
        #endregion //Members

        #region Commands
        public ICommand StartCommand { get; private set; }
        public ICommand ButtonCommand1 { get; private set; }
        public ICommand ButtonCommand2 { get; private set; }
        public ICommand ButtonCommand3 { get; private set; }
        public ICommand ExitCommand { get; private set; }
        public ICommand RetryCommand { get; private set; }
        public ICommand AddOnly { get; private set; }
        public ICommand SubtractOnly { get; private set; }
        public ICommand MultiplyOnly { get; private set; }
        public ICommand DivideOnly { get; private set; }
        public ICommand All { get; private set; }
        #endregion //Commands

        #region Methods
        public MainViewModel()
        {
            init();
            StartCommand = new DelegateCommand(Start);
            ButtonCommand1 = new DelegateCommand(ButtonC1);
            ButtonCommand2 = new DelegateCommand(ButtonC2);
            ButtonCommand3 = new DelegateCommand(ButtonC3);
            ExitCommand = new DelegateCommand(Exit);
            RetryCommand = new DelegateCommand(Retry);
            AddOnly = new DelegateCommand(Add);
            SubtractOnly = new DelegateCommand(Subtract);
            MultiplyOnly = new DelegateCommand(Multiply);
            DivideOnly = new DelegateCommand(Divide);
            All = new DelegateCommand(AllMaths);
        }

        public void init()
        {
            startVisible = true;
            titleVisible = true;
            button1Visible = false;
            button2Visible = false;
            button3Visible = false;
            qTextVisible = false;
            exitButtonVisible = false;
            count = 0;
        }

        public void Start()
        {
            if (time <= 0)
            {
                init();
            }

            else
            {
                startVisible = false;
                titleVisible = false;
                button1Visible = true;
                button2Visible = true;
                button3Visible = true;
                qTextVisible = true;
                generateQuestion();
            }
        }

        public void Add()
        {
            math = 1;
            all = false;
        }

        public void Subtract()
        {
            math = 2;
            all = false;
        }

        public void Multiply()
        {
            math = 3;
            all = false;
        }

        public void Divide()
        {
            math = 4;
            all = false;
        }

        public void AllMaths()
        {
            all = true;
        }

        public void generateQuestion()
        {
            Random rand = new Random();
            number1 = rand.Next(1, 11);
            number2 = rand.Next(1, 11);

            int answer = 0, fake1, fake2;
            if (all)
            {
                math = rand.Next(1, 5);
            }
            switch (math)
            {
                case 1:
                    qOutput = number1 + " + " + number2 + " = ";
                    answer = number1 + number2;
                    break;
                case 2:
                    if (number2 > number1)
                    {
                        int placeholder = number1;
                        number1 = number2;
                        number2 = placeholder;
                    }

                    qOutput = number1 + " - " + number2 + " = ";
                    answer = number1 - number2;
                    break;
                case 3:
                    qOutput = number1 + " * " + number2 + " = ";
                    answer = number1 * number2;
                    break;
                case 4:
                    answer = number1;
                    number1 *= number2;

                    qOutput = number1 + " / " + number2 + " = ";
                    break;
            }

            do
            {
                if (math == 3)
                {
                    fake1 = (rand.Next(1, 21) - 10) + answer;
                    fake2 = (rand.Next(1, 21) - 10) + answer;
                }

                else
                {
                    fake1 = rand.Next(1, 21);
                    fake2 = rand.Next(1, 21);
                }
            }
            while (answer == fake1 || fake1 == fake2 || answer == fake2 || fake1 < 0 || fake2 < 0);

            ans = rand.Next(1, 4);
            switch (ans)
            {
                case 1:
                    buttonText1 = answer;
                    buttonText2 = fake1;
                    buttonText3 = fake2;
                    break;
                case 2:
                    buttonText1 = fake1;
                    buttonText2 = answer;
                    buttonText3 = fake2;
                    break;
                case 3:
                    buttonText1 = fake1;
                    buttonText2 = fake2;
                    buttonText3 = answer;
                    break;
            }

            if (time != oldTime)
            {
                timer = new Timer(time * 1000);
                oldTime = time;
            }

            timer.Start();
            timer.Enabled = true;
            timer.Elapsed += HandleTimer;
        }

        public void HandleTimer(object source, ElapsedEventArgs e)
        {
            timer.Stop();
            exitPage();
        }

        public void ButtonC1()
        {
            timer.Stop();
            if (ans == 1)
            {
                count++;
                generateQuestion();
            }

            else { exitPage(); }
        }

        public void ButtonC2()
        {
            timer.Stop();
            if (ans == 2)
            {
                count++;
                generateQuestion();
            }

            else { exitPage(); }
        }

        public void ButtonC3()
        {
            timer.Stop();
            if (ans == 3)
            {
                count++;
                generateQuestion();
            }

            else { exitPage(); }
        }

        public void exitPage()
        {
            streak = "Streak: " + count;
            exitButtonVisible = true;

            if (ans == 1)
            {
                button2Visible = false;
                button3Visible = false;
                ans = 4;
            }

            else if (ans == 2)
            {
                button1Visible = false;
                button3Visible = false;
                ans = 4;
            }

            else if (ans == 3)
            {
                button1Visible = false;
                button2Visible = false;
                ans = 4;
            }
        }

        public void Exit()
        {
            Application.Current.Shutdown();
        }

        public void Retry()
        {
            init();
        }
        #endregion //Methods
    }
}
