using Hometask.Interfaces;
using Microsoft.EntityFrameworkCore;
using SeedData;

namespace Hometask.Models;
public class Repository : IRepository
{
    private List<User> users;
    private List<Hometask.Models.Task> tasks;
    private List<Tag> tags;

    public Repository()
    {
        users = new List<User>();
        tasks = new List<Task>();
        tags = new List<Tag>();
    }

    public void AddTag(Tag tag)
    {
        using var context = new DataContext();
        context.Tags.Add(tag);
        context.SaveChanges();
    }

    public void AddTask(Hometask.Models.Task task)
    {
        using var context = new DataContext();
        context.Tasks.Add(task);
        context.SaveChanges();
    }

    public void AddUser(User user)
    {
        using var context = new DataContext();
        context.Users.Add(user);
        context.SaveChanges();
    }

    public void DeleteTag(Tag tag)
    {
        using var context = new DataContext();
        context.Tags.Remove(tag);
        context.SaveChanges();
    }

    public void DeleteTask(Hometask.Models.Task task)
    {
        using var context = new DataContext();
        context.Tasks.Remove(task);
        context.SaveChanges();
    }

    public void DeleteUser(User user)
    {
        using var context = new DataContext();
        context.Users.Remove(user);
        context.SaveChanges();
    }

    public Tag GetTagById(int tagId)
    {
        using var context = new DataContext();
        return context.Tags.Find(tagId);
    }

    public Hometask.Models.Task GetTaskById(int taskId)
    {
        using var context = new DataContext();
        return context.Tasks.Find(taskId);
    }

    public List<Hometask.Models.Task> GetTasksForUser(int userId)
    {
        using var context = new DataContext();
        return context.Tasks.Where(t => t.UserId == userId).ToList();
    }

    public List<Hometask.Models.Task> GetTasksWithTag(int tagId)
    {
        using var context = new DataContext();
        return context.Tasks
                      .Where(t => t.Tags.Any(tag => tag.Id == tagId))
                      .ToList();
    }

    public User GetUserById(int userId)
    {
        using var context = new DataContext();
        return context.Users.Find(userId);
    }

    public void UpdateTag(Tag tag)
    {
        using var context = new DataContext();
        context.Tags.Attach(tag);
        context.Entry(tag).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void UpdateTask(Hometask.Models.Task task)
    {
        using var context = new DataContext();
        context.Tasks.Attach(task);
        context.Entry(task).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void UpdateUser(User user)
    {
        using var context = new DataContext();
        context.Users.Attach(user);
        context.Entry(user).State = EntityState.Modified;
        context.SaveChanges();
    }
}