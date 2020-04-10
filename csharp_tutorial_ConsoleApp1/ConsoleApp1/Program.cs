using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder() { video = new Video("penny wise") };
            var textService = new TextService();
            var mailService = new MailService();
            videoEncoder.VideoEncoded += textService.onVideoEncoded;
            videoEncoder.VideoEncoded += mailService.onVideoEncoded;

            videoEncoder.VideoEncode();

            
            
        
        }
    }

    



}



