﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int ImageId { get; set; }
        public ImageModel Image { get; set; }
    }
}