using DesignPatterns.Tools;

namespace DesignPatterns.Behavioral.Observe
{
    public class BankTransaction
    {
        public decimal Amount { get; }
        public DateTime Timestamp { get; }

        public BankTransaction(decimal amount)
        {
            Amount = amount;
            Timestamp = DateTime.Now;
        }
    }

    public interface IObserver2
    {
        void Update(BankTransaction transaction);
    }

    public class BankAccount
    {
        private List<IObserver2> observers = new List<IObserver2>();
        private List<BankTransaction> transactions = new List<BankTransaction>();

        public void AddObserver(IObserver2 observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver2 observer)
        {
            observers.Remove(observer);
        }

        public void AddTransaction(decimal amount)
        {
            BankTransaction transaction = new BankTransaction(amount);
            transactions.Add(transaction);
            NotifyObservers(transaction);
        }

        private void NotifyObservers(BankTransaction transaction)
        {
            foreach (var observer in observers)
            {
                observer.Update(transaction);
            }
        }
    }
    public class TransactionLogger : IObserver2
    {
        private string loggerName;

        public TransactionLogger(string name)
        {
            loggerName = name;
        }

        public void Update(BankTransaction transaction)
        {
            LocalConsole.WriteLine($"Logger {loggerName} - New transaction: {transaction.Amount} at {transaction.Timestamp}");
        }
    }

}
