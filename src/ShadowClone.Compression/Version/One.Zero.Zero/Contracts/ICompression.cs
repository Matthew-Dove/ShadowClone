namespace ShadowClone.Compression.Version.One.Zero.Zero.Contracts
{
    public interface ICompression
    {
        string Id { get; } // Use a file hash as well/instead?

        string Version { get; } // Optional?

        string Format { get; } // e.g. GZIP : This should go on the compress return model.

        byte[] Compress(byte[] file, string fileExtension); // Change to models.

        byte[] Extract(byte[] compressedFile, string fileExtension); // Change to models.
    }
}
