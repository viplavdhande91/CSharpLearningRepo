using HelloWorld;
using System;

namespace EventHandling
{


    class Maths
    {

        static void Main(string[] args) {

            Video video = new Video("Game of thrones SO1E01");

            VideoEncoder videoEncoder  =  new VideoEncoder();

            MessageService? messageService   = new MessageService();
            EmailService? emailService = new EmailService();


            videoEncoder.videoEncoded += messageService.SendService;

            videoEncoder.videoEncoded += emailService.SendService;

            videoEncoder.Encode(video);

                

        }



    };



}