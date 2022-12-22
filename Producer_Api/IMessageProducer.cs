using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producer_Api
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message);
    }
}
