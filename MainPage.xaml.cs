namespace MauiAppWindowTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        
        /// <summary>
        /// Second Window
        /// </summary>
        Window MyWin = null;
        
        /// <summary>
        /// A boolean to check if the window is showing
        /// </summary>
        bool MyWinCreated = false;

        public MainPage()
        {
            InitializeComponent();

            // Setting up the New window:
            
            // It will Show the Test Page
            MyWin = new Window(new TestPage());
            MyWin.MaximumWidth = 800;

            // Programming the Created and Destroying events to set the value of MyWinCreated boolean
            MyWin.Created += (s, e) => { MyWinCreated = true; };
            MyWin.Destroying += (s, e) => { MyWinCreated = false; };          
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            
            // Close MyWindow if it is Created and Open WyWindow if it is closed.
            if (MyWinCreated)
                Application.Current.CloseWindow(MyWin);
            else
                Application.Current.OpenWindow(MyWin);
            
        }
    }
}