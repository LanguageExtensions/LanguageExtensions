using System;

namespace LanguageExtensions.Functional
{
    internal class Error<T> : Result<T>
    {
        private Exception Content { get; }

        public Error(Exception content)
            => Content = content;

        public static implicit operator Exception(Error<T> obj)
            => obj.Content;
    }
}
