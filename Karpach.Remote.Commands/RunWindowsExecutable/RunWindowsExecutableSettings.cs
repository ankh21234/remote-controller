﻿using Karpach.Remote.Commands.Base;

namespace Karpach.Remote.Commands.RunWindowsExecutable
{
    public class RunWindowsExecutableSettings: CommandSettingsBase
    {
        public string CommandName { get; set; }
        public string ExecutablePath { get; set; }
        public string Arguments { get; set; }
        public int? ExecutionDelay { get; set; }
    }
}