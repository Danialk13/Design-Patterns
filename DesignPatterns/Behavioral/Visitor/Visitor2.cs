using DesignPatterns.Tools;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface IAccountVisitor
    {
        void Visit(SavingsAccount account);
        void Visit(CheckingAccount account);
        void Visit(InvestmentAccount account);
    }

    public abstract class BankAccount
    {
        public abstract void Accept(IAccountVisitor visitor);
    }

    public class SavingsAccount : BankAccount
    {
        public override void Accept(IAccountVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class CheckingAccount : BankAccount
    {
        public override void Accept(IAccountVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class InvestmentAccount : BankAccount
    {
        public override void Accept(IAccountVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class TaxVisitor : IAccountVisitor
    {
        public void Visit(SavingsAccount account)
        {
            LocalConsole.WriteLine("Calculating tax for Savings Account.");
        }

        public void Visit(CheckingAccount account)
        {
            LocalConsole.WriteLine("Calculating tax for Checking Account.");
        }

        public void Visit(InvestmentAccount account)
        {
            LocalConsole.WriteLine("Calculating tax for Investment Account.");
        }
    }
}
