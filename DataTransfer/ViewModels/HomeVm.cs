﻿using DataTransfer.Models;
using System.Collections.Generic;

namespace DataTransfer.ViewModels
{
    public class HomeVm
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
    }
}
