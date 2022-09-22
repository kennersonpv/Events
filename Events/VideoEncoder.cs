using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
        }
    }
}