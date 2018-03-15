using System;

namespace Src
{
    public class TaskInterleavingConfiguration
    {
        public TaskInterleavingConfiguration(bool enable)
        {
            Id = Guid.NewGuid();
            Enable = enable;
        }

        public Guid Id { get; }
        public bool Enable { get; }
    }
}