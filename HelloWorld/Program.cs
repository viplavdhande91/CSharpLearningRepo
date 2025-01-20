using HelloWorld;

namespace EventHandling
{

    class Program
    {

        static void Main(string[] args)
        {

            Video video = new Video("Game of thrones SO1E01");
            VideoEncoder videoEncoder = new VideoEncoder();

            MessageService? messageService = new MessageService();
            EmailService? emailService = new EmailService();

            videoEncoder.VideoEncodedevent += messageService.SendService;
            videoEncoder.VideoEncodedevent += emailService.SendService;

            videoEncoder.Encode(video);

        }

    };

}