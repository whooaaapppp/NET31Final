using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VideoShop.Pocos
{
    
    [Table("Borrower")]
    public class BorrowerPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Column("Borrower_Name")]
        public string BorrowerName { get; set; }

        [Column("Date_of_Birth")]
        public DateTime DOB { get; set; }

        public virtual ICollection<VideoPoco> Videos { get; set; }
    }
}
