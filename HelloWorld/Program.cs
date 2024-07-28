using HelloWorld;
using System;

namespace EventHandling
{


    class Program
    {

        static void Main(string[] args) {

            Video video = new Video("Game of thrones SO1E01");
            VideoEncoder videoEncoder  =  new VideoEncoder();

            MessageService? messageService   = new MessageService();
            EmailService? emailService = new EmailService();

            videoEncoder.videoEncodedevent += messageService.SendService;
            videoEncoder.videoEncodedevent += emailService.SendService;

            videoEncoder.Encode(video);

                

        }



    };



}