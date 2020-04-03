using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace VideoShop.Pocos
{
    [Table("Video")]
    public class VideoPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Column("Video_Title")]
        public string VideoName { get; set; }

        [Column("Release_Date")]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Borrower_ID")]
            public virtual BorrowerPoco Borrower { get; set; }


    }
}
