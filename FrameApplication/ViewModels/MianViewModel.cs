﻿using System.Diagnostics;

namespace FrameApplication.ViewModels
{
    public partial class MianViewModel
    {
        public string AppTitle { get; set; } = "FrameApplication";

        public void Execute()
        {
            Trace.WriteLine("Execute command");
        }
    }
}