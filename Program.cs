using Hometask.Interfaces;
using Hometask.Models;

namespace Hometask;

public class Program
{
    static void Main(string[] args)
    {
        IRepository repository = new Repository();

        // Create
        //
        // ID MUST BE UNIQUE
        // 
        // TYPE WHATEVER YOU WANT IN THE STRINGS
        // ->

        User user1 = new User { Id = 10, Name = "Ali Valiev" };
        repository.AddUser(user1);

        Hometask.Models.Task task1 = new Hometask.Models.Task { Title = "Task 1", Description = "Description for Task 1", UserId = 6 };
        repository.AddTask(task1);

        Tag tag1 = new Tag { Name = "Important" };
        repository.AddTag(tag1);

        // Read
        User GetUser = repository.GetUserById(1);
        Console.WriteLine("User: " + GetUser.Name);

        Hometask.Models.Task GetTask = repository.GetTaskById(1);
        Console.WriteLine("Task: " + GetTask.Title);

        Tag GetTag = repository.GetTagById(1);
        Console.WriteLine("Tag: " + GetTag.Name);

        User user2 = new User { Id = 4, Name = "Ali " };
        repository.UpdateUser(user2);

        Hometask.Models.Task task2 = new Hometask.Models.Task { Id = 1, Title = "Task Updated", Description = "Description for Task Updated", UserId = 4 };
        repository.UpdateTask(task2);

        Tag tag2 = new Tag { Id = 1, Name = "Updated" };
        repository.UpdateTag(tag2);

        //// Delete
        //repository.DeleteUser(user1);
        //repository.DeleteTask(task1);
        //repository.DeleteTag(tag1);
    }
}