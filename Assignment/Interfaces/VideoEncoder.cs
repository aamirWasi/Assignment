using System.Collections.Generic;

namespace Interfaces
{
    public class VideoEncoder
    {
        private readonly List<INotificationChannel> _notificationChannel;
        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }
        public void Encode()
        {
            foreach (var channel in _notificationChannel)
            {
                channel.Send(new Message());
            }
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }
    }
}
