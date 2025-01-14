﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Tangram.Core;
using Tangram.Utility;

namespace Tangram.IE
{
    [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisibleAttribute(true)]
    public class StateForScript
    {
        private IntPtr controller;
        private IntPtr handle;
        private string title;
        public StateForScript(IntPtr controller, IntPtr handle, string title)
        {
            this.controller = controller;
            this.handle = handle;
            this.title = title;
        }

        public void send(string formName, string eventName, string data)
        {
            //EventManager.StateEventManager.Send(controller, formName, eventName, data);
        }
        public void on(string eventName, string callBack)
        {
          LocalEventManager.StateEventManager.On(this.title, eventName);
        }
    }


}