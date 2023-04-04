using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public TaskModel Get(int taskId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TaskModel> GetAllActive()
        {
            throw new NotImplementedException();
        }
        public void Add(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public void Update(int taskId, TaskModel task)
        {
            throw new NotImplementedException();
        }

        public void Delete(int taskId)
        {
            throw new NotImplementedException();
        }  


    }
}
