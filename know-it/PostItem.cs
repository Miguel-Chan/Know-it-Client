using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace know_it
{
    class PostItem
    {
        public string content;
        public string editor;
        public string imageURL;
        public Dictionary<string, string> comments;
        public string videoURL;
        public int thumbs;
        public string title;
        public bool hasImage { get { return imageURL == ""; } }
        public bool hasVideo { get { return videoURL == ""; } }
        public PostItem(string con, string ti, string edi, string img, string vid, int thu, Dictionary<string, string> com)
        {
            content = con;
            title = ti;
            editor = edi;
            imageURL = img;
            videoURL = vid;
            thumbs = thu;
            comments = com;
        }
    }
}
