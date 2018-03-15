using System.Collections.Generic;

namespace Src
{
    public static class Repository
    {
        static Repository()
        {
            _movementTasks = new List<MovementTask>();
            _taskConfigurations = new List<TaskInterleavingConfiguration>();
        }
        
        private static readonly List<MovementTask> _movementTasks;
        public static IReadOnlyCollection<MovementTask> MovementTasks => _movementTasks;
        private static readonly List<TaskInterleavingConfiguration> _taskConfigurations;
        public static IReadOnlyCollection<TaskInterleavingConfiguration> TaskInterleavingConfigurations => _taskConfigurations;

        public static void AddMovementTasks(params MovementTask[] movementTasks)
        {
            _movementTasks.Clear();
            _movementTasks.AddRange(movementTasks);
        }
        
        public static void AddTaskInterleavingConfigurations(params TaskInterleavingConfiguration[] configurations)
        {
            _taskConfigurations.Clear();
            _taskConfigurations.AddRange(configurations);
        }
    }
}