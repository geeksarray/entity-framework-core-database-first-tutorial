﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework_core_database_first_tutorial.New
{
    public partial class Region
    {
        public Region()
        {
            Territories = new HashSet<Territories>();
        }

        [Column("RegionID")]
        public int RegionId { get; set; }
        [Required]
        [StringLength(50)]
        public string RegionDescription { get; set; }

        [InverseProperty("Region")]
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
