using System;
using System.IO;

namespace AVClub
{
    sealed class ReadOnlyFileAbstraction : TagLib.File.IFileAbstraction
    {
        public string Name { get; }
        public Stream ReadStream { get; }
        public Stream WriteStream => throw new NotSupportedException("Read-only abstraction.");

        public ReadOnlyFileAbstraction(string path)
        {
            Name = path;
            ReadStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }

        public void CloseStream(Stream stream)
        {
            stream?.Dispose();
        }
    }
}