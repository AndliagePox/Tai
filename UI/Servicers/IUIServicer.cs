﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Controls.Window;

namespace UI.Servicers
{
    public interface IUIServicer
    {
        Task<bool> ShowConfirmDialogAsync(string title_, string message_);
        void InitWindow(DefaultWindow window_);
    }
}
