﻿using System;
using System.Collections.Generic;
using System.Text;
using WAG.Data.Models;

namespace WAG.Data.Models
{
    public class ArtisticWork : BaseModel<int>
    {
        public int Year { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public decimal Price { get; set; }

        public bool Availability { get; set; }

        public bool HasFrame { get; set; }

        public int PictureId { get; set; }

        public virtual Picture Picture { get; set; }

        public int ArtisticWorkCategoryId { get; set; }

        public virtual ArtisticWorkCategory ArtisticWorkCategory { get; set; }

        public int ArtisticWorkTechniqueId { get; set; }

        public virtual ArtisticWorkTechnique ArtisticWorkTechnique { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public bool IsDeleted { get; set; }
    }
}