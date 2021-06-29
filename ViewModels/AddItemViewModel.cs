using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using Todo.Models;

namespace Todo.ViewModels
{
    public class AddItemViewModel:ViewModelBase
    {
        private string _description = string.Empty;
        
        public ReactiveCommand<Unit,TodoItem> Ok { get; set; }
        public ReactiveCommand<Unit,Unit> Cancel { get; set; }

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }


        public AddItemViewModel()
        {
            var okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));

            Ok = ReactiveCommand.Create(
                () => new TodoItem {Description = Description},
                okEnabled);
            
            
            Cancel = ReactiveCommand.Create(() =>
            {
                    
            });
        }
    }
}