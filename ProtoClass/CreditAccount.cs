namespace ProtoClass;

public class CreditAccount : Account
{
    public CreditAccount(int number, string owner, int creditLimit) : base(number, owner)
    {
        CreditLimit = creditLimit;
    }

    public int CreditLimit { get; set; }

    public override CreditAccount Copy()
        => new CreditAccount(Number + 10, Owner, CreditLimit);

    public override string ToString()
    {
        return $"{ base.ToString()} {CreditLimit}";
    }
}