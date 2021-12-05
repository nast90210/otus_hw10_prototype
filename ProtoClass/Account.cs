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
    {
        throw new NotImplementedException();
    }

    public virtual Account Copy()
        => new Account(Number, Owner);

    public override string ToString()
    {
        return $"{Owner} {Number}";
    } 
}