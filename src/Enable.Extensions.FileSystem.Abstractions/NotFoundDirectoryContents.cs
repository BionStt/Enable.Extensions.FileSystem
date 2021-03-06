using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Enable.Extensions.FileSystem
{
    /// <summary>
    /// Represents a non-existent directory.
    /// </summary>
    public class NotFoundDirectoryContents : IDirectoryContents
    {
        public NotFoundDirectoryContents(string path)
        {
            Name = path;
        }

        /// <inheritdoc />
        public bool Exists => false;

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public string Path => null;

        public IEnumerator<IFile> GetEnumerator() => Enumerable.Empty<IFile>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
