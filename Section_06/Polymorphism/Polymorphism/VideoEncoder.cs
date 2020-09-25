
using System.Collections;
using System.Collections.Generic;
using Microsoft.Build.Tasks;

namespace Polymorphism
{
    
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notficationChannel;

        public VideoEncoder()
        {
            _notficationChannel = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic     
            // ...

            foreach (var channel in _notficationChannel)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notficationChannel.Add(channel);
        }
    }
}