using System;

namespace Src
{
    public class MovementTask
    {
        public MovementTask(MovementTaskStatus status)
        {
            Id = Guid.NewGuid();
            Status = status;
        }
        
        public Guid Id { get; }
        public MovementTaskStatus Status { get; }
    }

    public enum MovementTaskStatus
    {
        ToDo = 1,
        InProgress = 2,
        StandBy = 3,
        Done = 4
    }
}