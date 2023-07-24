using System.Windows.Input;

namespace DecoratorDemo
{
	internal interface ICommandHandler<in TCommand>
		where TCommand : ICommand
	{
		void Handle(TCommand command);
	}
}
