
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Serv.Models
{
    public enum OperationStatus
    {
        NotStarted = 0,
        InProcess,
        Fealed,
        Done
    }

    public enum TaskType
    {
        File = 1,
        Email
    } 

    public class Tasks
    {

        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// For API executor params like as JSON object:
        /// [{ "Recipiend":"elyor@outlook.com", "Subject":"test","Body":"test email"}]
        /// [{ "Root":"C:\tmp","File":"foo.txt"}]
        /// </summary>
        [Required]
        public string JSONParams { get; set; }

        public string MachineId { get; set; }

        public OperationStatus Status { get; set; }

        public TaskType? Type { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SchedulerTime { get; set; }

    }
}
