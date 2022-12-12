namespace Services.EnumServices;

public static class EnumServices<T> 
{
    public static T ToEnum(string value)
    {
        return (T) Enum.Parse(typeof(T), value);
    }
    
    public static string EnumToString(T e)
    {
        return Enum.GetName(e.GetType(), e);
    }
}