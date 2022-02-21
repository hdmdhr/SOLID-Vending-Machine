public interface ICanGreet
{
    void SayHello();
    void SayBye();
}

public interface ICanTellTime
{
    void TellTime();
}

public interface IVendingMachine
{
    void DisplayMenu();
    void Start();
}

public interface IFriendlyVendingMachine : ICanGreet, ICanTellTime, IVendingMachine { }