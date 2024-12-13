namespace HelloWorld
{
    public class VideoEventArgs : EventArgs
    {
        private int _length { get; set; }
        public VideoEventArgs(int length)
        {
            _length = length;
        }
    }

    internal class VideoEncoder
    {
        public event EventHandler<VideoEventArgs>? videoEncodedevent;

        //public delegate void VideoEncoderDelegate(object video,VideoEventArgs e);
        //public event VideoEncoderDelegate? videoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding of video Started.. ");
            //Video Encoding Logic
            Thread.Sleep(3000);

            //After Video Encoding We can ping Suscribers
            OnVideoEncoded(video);

        }
        //EVENT HANDLING PASSER FUNCTION    
        protected virtual void OnVideoEncoded(Video video)
        {
            EventHandler<VideoEventArgs>? handler = videoEncodedevent;

            if (handler != null)
            {
                handler.Invoke(this, new VideoEventArgs(25));
            }

        }
    }
}
