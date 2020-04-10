using System;
using System.Threading;
namespace ConsoleApp1
{

    public class Video
    {
        public string title;
        public Video(string s = "default title")
        {
            title = s;
        }
    }



    public class VideoEventArgs {
        public Video video;    
    }



    public class VideoEncoder {
        // you should intialize the class member with intializer
        public Video video; 
        public void VideoEncode() {
            Console.WriteLine("video encoding : {0} ...",video.title);
            Thread.Sleep(3000);
            Console.WriteLine("finish the encoding ...");

            onVideoEncoded();
        }
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void onVideoEncoded() {
            if (VideoEncoded != null) {
                VideoEncoded(this, new VideoEventArgs() { video = this.video });            
            }
        }
    }






}



