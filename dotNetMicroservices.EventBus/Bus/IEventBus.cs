using dotNetMicroservices.EventBus.Commands;
using dotNetMicroservices.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dotNetMicroservices.EventBus.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
