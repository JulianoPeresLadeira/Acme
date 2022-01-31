namespace Acme.DataAccess.Converters
{
    public interface IConverter
    {
        K Convert<T, K>(T from);
    }
}
