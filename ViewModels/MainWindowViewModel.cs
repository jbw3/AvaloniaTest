using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaMVVMTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int _index = 0;

        private string[] _greetings = new string[] { "Hello!", "Hi!" };

        private string _Greeting;

        public string Greeting
        {
            get => _Greeting;
            set => this.RaiseAndSetIfChanged(ref _Greeting, value);
        }

        public MainWindowViewModel()
        {
            Greeting = _greetings[0];
        }

        public void ChangeGreeting()
        {
            _index = (_index + 1) % _greetings.Length;
            Greeting = _greetings[_index];
        }
    }
}
