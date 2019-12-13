using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;
using GitTeamStats.Models;

namespace GitTeamStats
{
    /// <summary>
    /// Used to globally access the currrent repo
    /// </summary>
    public class RepoController
    {
        public static RepoController instance = new RepoController();

        public Repository repo;
        public string filePath;
        public string folder;
        public List<Contributor> contributors;

        private RepoController()
        {

        }

        public void SetPath(string s)
        {
            instance.filePath = s;
            string[] pathParts = s.Split('\\');
            folder = pathParts[pathParts.Length - 1];
        }

        public void GetContributors()
        {
            if (repo == null)
            {
                contributors = new List<Contributor>();
                return;
            }

            contributors = Contributor.GetAll(repo);
        }
    }
}
