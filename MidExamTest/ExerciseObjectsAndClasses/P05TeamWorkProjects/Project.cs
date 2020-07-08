using System;
using System.Collections.Generic;
using System.Text;

namespace P05TeamWorkProjects
{
    class Project
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public string Member { get; set; }      

        public override string ToString()
        {
            return $"{this.TeamName} {this.Creator} {this.Member}";
        }
    }
}
