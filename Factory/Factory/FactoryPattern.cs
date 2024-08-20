namespace Factory.Factory;

public static class FactoryPattern<K, T> where T : class, K, new() {
    public static K GetInstance()
    {
        K obj = new T();
        return obj;
    }
}