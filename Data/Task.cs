using System;

namespace NETConfWebAPI.Data
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public State State { get; set; }

        public Task()
        {
            this.State = State.TODO;
        }
    }
}