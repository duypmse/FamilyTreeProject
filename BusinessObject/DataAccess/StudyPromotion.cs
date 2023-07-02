﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.DataAccess
{
    public partial class StudyPromotion
    {
        public int Id { get; set; }
        public int? FamilyId { get; set; }
        public string PromotionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }

        public virtual Family Family { get; set; }
    }
}
