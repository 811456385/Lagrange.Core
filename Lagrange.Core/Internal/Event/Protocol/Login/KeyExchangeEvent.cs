namespace Lagrange.Core.Internal.Event.Protocol.Login;

internal class KeyExchangeEvent : ProtocolEvent
{
    private KeyExchangeEvent() : base(true)
    {
    }

    private KeyExchangeEvent(int resultCode) : base(resultCode)
    {
    }

    public static KeyExchangeEvent Create()
    {
        return new KeyExchangeEvent(0);
    }
    
    
    public static KeyExchangeEvent Result()
    {
        return new KeyExchangeEvent();
    }
}