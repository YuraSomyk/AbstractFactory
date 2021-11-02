using static System.Guid;

namespace AbstractFactory.DependencyInjection {

    public class DefaultOperation : Operation.Transient.ITransientOperation,
        Operation.Scoped.IScopedOperation, 
        Operation.Singleton.ISingletonOperation {

        public string OperationId { get; } = NewGuid().ToString()[^4..];
    }
}