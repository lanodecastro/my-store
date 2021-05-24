namespace MyStore.Core.Commands
{
    public interface ICommandHandler<TCommand>
    {
        void Execute(TCommand command);
    }
}
