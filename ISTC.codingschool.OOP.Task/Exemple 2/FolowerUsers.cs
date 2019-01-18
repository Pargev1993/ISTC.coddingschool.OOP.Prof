using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exemple_2
{
    public class FolowerUsers
    {

        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
        public string name { get; set; }
        public object company { get; set; }
        public string blog { get; set; }
        public string location { get; set; }
        public object email { get; set; }
        public object hireable { get; set; }
        public string bio { get; set; }
        public int public_repos { get; set; }
        public int public_gists { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public void CallfolowUser()
        {


                Console.WriteLine("login: {0}", login);
                Console.WriteLine("id: {0}", id);
                Console.WriteLine("node_id: {0}", node_id);
                Console.WriteLine("avatar_url: {0}", avatar_url);
                Console.WriteLine("gravatar_id: {0}", gravatar_id);
                Console.WriteLine("url: {0}", url);
                Console.WriteLine("followers_url: {0}", followers_url);
                Console.WriteLine("following_url: {0}", following_url);
                Console.WriteLine("gists_url: {0}", gists_url);
                Console.WriteLine("starred_url: {0}", starred_url);
                Console.WriteLine("organizations_url: {0}", organizations_url);
                Console.WriteLine("repos_url: {0}", repos_url);
                Console.WriteLine("events_url: {0}", events_url);
                Console.WriteLine("received_events_url: {0}", received_events_url);
                Console.WriteLine("type: {0}", type);
                Console.WriteLine("site_admin: {0}", site_admin);
                Console.WriteLine("name: {0}", name);
                Console.WriteLine("company: {0}", company);
                Console.WriteLine("blog: {0}", blog);
                Console.WriteLine("location: {0}", location);
                Console.WriteLine("email: {0}", email);
                Console.WriteLine("hireable: {0}", hireable);
                Console.WriteLine("bio: {0}", bio);
                Console.WriteLine("public_repos: {0}", public_repos);
                Console.WriteLine("public_gists: {0}", public_gists);
                Console.WriteLine("followers: {0}", followers);
                Console.WriteLine("following: {0}", following);
                Console.WriteLine("created_at: {0}", created_at);
                Console.WriteLine("updated_at: {0}", updated_at);
        }
    }



}
