﻿using Renci.SshClient.Common;

namespace Renci.SshClient.Messages.Connection
{
    internal abstract class ChannelOpenInfo : SshData
    {
        public abstract string ChannelType { get; }

        protected override void LoadData()
        {
        }

        protected override void SaveData()
        {
        }
    }
}