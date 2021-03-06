namespace ProtoClass;

public class DepositAccount : Account
{
    public DepositAccount(int number, string owner, int deposit) : base(number, owner)
    {
        Deposit = deposit;
    }
    
    public int Deposit { get; set; }
    
    public override DepositAccount Copy()
        => new DepositAccount(Number  + 10, Owner, Deposit);

    public override string ToString()
    {
        return $"{ base.ToString()} {Deposit}";
    }
}