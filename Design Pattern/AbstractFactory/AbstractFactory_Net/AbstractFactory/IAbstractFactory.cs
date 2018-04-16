namespace AbstractFactory_Net
{
    interface IAbstractFactory
    {
        dynamic Make(Product product);
    }
}
