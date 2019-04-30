namespace KalmDownCSharp.Infrastructure
{
    using System;

    public interface IMediator
    {
        void Register(string token, Action<object> callback);

        void Unregister(string token, Action<object> callback);

        void NotifyColleagues(string token, object args);
    }
}
