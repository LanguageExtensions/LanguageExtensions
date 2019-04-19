namespace LanguageExtensions.Functional
{
    internal class Some<T> : Result<T>
    {
        private T Content { get; }

        public Some(T content)
            => Content = content;

        public static implicit operator T(Some<T> value)
            => value.Content;
    }
}
