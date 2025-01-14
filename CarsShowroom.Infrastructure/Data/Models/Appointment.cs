using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Appointment for test drive or inspection")]
    public class Appointment
    {
        [Key]
        [Comment("Appointment identifier")]
        public int Id  { get; set; }

        [Required]
        [Comment("Date of appointment")]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [ForeignKey(nameof(Vehicle))]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;
    }
}
