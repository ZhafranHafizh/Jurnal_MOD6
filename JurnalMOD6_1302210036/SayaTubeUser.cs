using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalMOD6_1302210036
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private String Username;

        public SayaTubeUser(String username)
        {
            Username = username;
            Random random = new Random();
            this.id = random.Next(9999, 99999);
            List<SayaTubeUser> uploadVideos = new List<SayaTubeUser>();

        }
        public int GetTotalVideoPlayCount()
        {
            int tot = 0;
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                tot = tot + uploadedVideos[i].getPlayCount();
            }
            return tot;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Contract.Requires(video != null);
            Contract.Requires(video.getPlayCount() < int.MaxValue);
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("user " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul " + uploadedVideos[i]);
            }
        }
    }
}
