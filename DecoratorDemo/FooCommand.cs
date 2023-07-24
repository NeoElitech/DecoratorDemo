using System;
using System.Windows.Input;

namespace DecoratorDemo
{
	internal class FooCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
		}
	}
}
