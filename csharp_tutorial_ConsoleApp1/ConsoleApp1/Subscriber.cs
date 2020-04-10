using System;

namespace ConsoleApp1
{
    public class MailService
    {
        public void onVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("send a mail : {0}", e.video.title);
        }
    }



    public class TextService
    {
        public void onVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("send a text : {0}", e.video.title);
        }
    }
}



