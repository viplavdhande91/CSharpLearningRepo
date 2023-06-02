using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class VideoEventArgs : EventArgs
    {
    }

    internal class VideoEncoder
    {
           public event EventHandler<VideoEventArgs>? videoEncoded;

          //public delegate void VideoEncoderDelegate(object video,VideoEventArgs e);

          // public event VideoEncoderDelegate? videoEncoded;




        public void Encode(Video video)
        {

            Console.WriteLine("Encoding of video Started.. ");
            //Video Encoding Logic
            Thread.Sleep(3000);



            //After Video Encoding We have ping Suscribers

            OnVideoEncoded(video);


        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (videoEncoded != null)
            {
                videoEncoded.Invoke(this, new VideoEventArgs());

            }
        }
    }
}
