using FED_Ass1.ViewModel;

namespace FED_Ass1.View
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

		private MainViewModel vm = new MainViewModel();
		//Next, we assign the BindingContext to that instance in the constructor:
		public MainPage()
		{
			InitializeComponent();
			BindingContext = vm;
            

        }


        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            Console.WriteLine("Hello from OnCounterClicked!");
        }

        private void OnTestClicked(object sender, EventArgs e)
        {
            //TestBtn.Text = "clicked";
            Console.WriteLine("Hello from OnTestClicked!");

        }
    }
}