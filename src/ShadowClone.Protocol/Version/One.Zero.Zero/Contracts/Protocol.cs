namespace ShadowClone.Protocol.Version.One.Zero.Zero.Contracts
{
    public interface IProtocol
    {
        byte[] Send(byte[] data, string target);
        byte[] Retrieve(string target);
    }
}
