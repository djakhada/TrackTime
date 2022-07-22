using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackTime.Models
{
    public class Process
    {
        public int Id { get; set; }
        public int PassiveTime { get; set; }
        public int ActiveTime { get; set; }
        public List<ProcessAlias> Aliases { get; } = new();
    }

    public class ProcessAlias
    {
        //Empty constructor is necessary for EF
        public ProcessAlias() { }
        public ProcessAlias(Process process, string alias)
        {
            Process = process;
            Alias = alias;
        }
        public int Id { get; set; }
        [Required]
        public Process Process { get; set; }
        [Required]
        public string Alias { get; set; }
    }
}
