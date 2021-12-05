namespace ProtoClass;

public interface IMyCloneable<out T>
{
    T Copy();
}