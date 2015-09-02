using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Skybrud.Social.Instagram;

namespace CC.WEB.ViewModels
{

    public class AboutViewModel
    {
        public List<InstaImage> InstaFeed { get; set; }

        public void Load()
        {
            var instagram = InstagramService.CreateFromAccessToken("1439051577.0410587.8bc939b7a78c4edb80aa033f7c128238");
            var feed = instagram.Users.GetRecentMedia(1439051577);

            if (feed != null && feed.Body != null && feed.Body.Data != null) {
                InstaFeed = feed.Body.Data.Select(a => new InstaImage {Link = a.Link, Url = a.Images.Thumbnail.Url, Likes = a.LikeCount}).Take(6).ToList();
            }
        }
    }

    public class InstaImage
    {
        public string Link { get; set; }
        public string Url { get; set; }
        public int Likes { get; set; }
    }

}