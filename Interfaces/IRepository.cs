using Hometask.Models;

namespace Hometask.Interfaces;

public interface IRepository
{
    void AddUser(User user);
    void AddTask(Hometask.Models.Task task);
    void AddTag(Tag tag);

    User GetUserById(int userId);
    Hometask.Models.Task GetTaskById(int taskId);
    Tag GetTagById(int tagId);
    List<Hometask.Models.Task> GetTasksForUser(int userId);
    List<Hometask.Models.Task> GetTasksWithTag(int tagId);

    void UpdateUser(User user);
    void UpdateTask(Hometask.Models.Task task);
    void UpdateTag(Tag tag);

    void DeleteUser(User user);
    void DeleteTask(Hometask.Models.Task task);
    void DeleteTag(Tag tag);
}
