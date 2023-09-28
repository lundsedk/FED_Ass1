using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;

// Lundse: Jeg har prøvet at gå ud fra:
// https://dev.to/hnicolus/bye-old-ways-hello-mvvm-community-toolkit-4nb

namespace FED_Ass1
{

    public class Account // Either a creditor or debtor
    {
        public string Name;
        public int Balance; // Positive if user is owed money from Account (ie. Account is debtor)
    }

    public class User
    {
        public string Name;
        public List<Account> Accounts;
    }


    namespace FED_Ass1.ViewModel {

        // why not [ObservableObject] decorator ???
        public partial class AccountsViewModel : ObservableObject
        {
            [ObservableProperty]
            private List<Account> _accounts;
                // <ListView ItemSource="{Binding _accounts}">

            [RelayCommand]
            public void Test()
                //should generate the testCommand (<Button ... Command="{Binding testCommand}"/>)
            {

            }

        }



    }





    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            return builder.Build();
        }
    }
}