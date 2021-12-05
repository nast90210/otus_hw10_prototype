namespace ProtoClass;

public class Account : ICloneable, IMyCloneable<Account>
{
    public Account(int number, string owner)
    {
        Number = number;
        Owner = owner;
    }

    public int Number { get; set; }
    public string Owner {get; set; }


    public object Clone()
        => Copy();

    public virtual Account Copy()
        => new Account(Number + 10, Owner);

    public override string ToString()
    {
        return $"{Owner} {Number}";
    } 
}