using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Models
{
    [Index(nameof(Task))]
    public class todoTask
    {

        public Guid Id { get; set; }

        [MaxLength(1000)]
        public string Name { get; set; } = null!;

       public DateTime Task { get; set; }


        public override string ToString()
        {
            return $"{this.Task.ToString("dd/MM hh:mm")} - {Name}";
        }
    }
}
