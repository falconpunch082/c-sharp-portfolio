using System;
using System.Security.Cryptography.X509Certificates;

namespace DuplicateCode
{

    // Task class
    class Task
    {
        // Declaring variables with read-write perms
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsImportant { get; set; }

        // Task constructor
        public Task(string name, DateTime dueDate, bool isImportant = false) // Default isImporant is false
        {
            Name = name;
            DueDate = dueDate;
            IsImportant = isImportant;
        }
    }

    // Category class
    class Category
    {
        // Declaring variables
        public string Name { get; set; }
        private List<Task> tasks; // Each category has a list of Task objects
        public int TaskCount => tasks.Count; // Lambda expression for one-line code of assigning the number of tasks in a category into TaskCount

        // Category constructor
        public Category(string name)
        {
            Name = name;
            tasks = new List<Task>();
        }

        // Adding tasks
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        // Deleting tasks
        public void DeleteTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        // Getting tasks
        public Task GetTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                return tasks[index];
            }
            return null;
        }

        // Moving tasks within the list of Tasks
        public void MoveTask(int fromIndex, int toIndex)
        {
            if (fromIndex >= 0 && fromIndex < tasks.Count && toIndex >= 0 && toIndex < tasks.Count)
            {
                var task = tasks[fromIndex];
                tasks.RemoveAt(fromIndex);
                tasks.Insert(toIndex, task);
            }
        }

        // Printing list of Task objects
        public void PrintTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                var task = tasks[i];
                Console.Write("{0,10}|", i);
                if (task.IsImportant)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("{0,-30}|{1,-30}|{2,-30}|", task.Name, task.DueDate.ToString("yyyy-MM-dd"), task.IsImportant ? "Important" : "Normal");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }

    // CategoryManager class
    class CategoryManager
    {
        public static void AddCategory(List<Category> categories)
        {
            try
            {
                Console.Write("Enter new category name: ");
                string categoryName = Console.ReadLine();
                categories.Add(new Category(categoryName)); // Adds new Category object into the categories list
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding category: {ex.Message}");
            }
        }

        public static void DeleteCategory(List<Category> categories)
        {
            try
            {
                Console.Write("Enter category name to delete: ");
                string categoryName = Console.ReadLine();
                var category = categories.FirstOrDefault(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)); // Tries to determine if the category exists
                if (category != null) // If category exists
                {
                    categories.Remove(category);
                }
                else
                {
                    Console.WriteLine("Category not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting category: {ex.Message}");
            }
        }

        public static void AddTask(List<Category> categories)
        {
            try
            {
                Console.Write("Enter category name to add task: ");
                string categoryName = Console.ReadLine();
                var category = categories.FirstOrDefault(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)); // Tries to determine if the category exists
                if (category != null)
                {
                    // Gathering data required to create a task
                    Console.Write("Enter task name: ");
                    string taskName = Console.ReadLine();
                    Console.Write("Enter task due date (dd/mm/yyyy): ");
                    DateTime dueDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Is the task important? (yes/no): ");
                    bool isImportant = Console.ReadLine().ToLower() == "yes";

                    // Adds task with provided info
                    category.AddTask(new Task(taskName, dueDate, isImportant));
                }
                else
                {
                    Console.WriteLine("Category not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding task: {ex.Message}");
            }
        }

        public static void DeleteTask(List<Category> categories)
        {
            try
            {
                Console.Write("Enter category name to delete task: ");
                string categoryName = Console.ReadLine();
                var category = categories.FirstOrDefault(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)); // Tries to determine if the category exists
                if (category != null)
                {
                    Console.Write("Enter task index to delete: "); // Provided on UI
                    int taskIndex = Convert.ToInt32(Console.ReadLine());
                    category.DeleteTask(taskIndex);
                }
                else
                {
                    Console.WriteLine("Category not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting task: {ex.Message}");
            }
        }

        public static void MoveTaskWithinCategory(List<Category> categories)
        {
            try
            {
                Console.Write("Enter category name to move task within: ");
                string categoryName = Console.ReadLine();
                var category = categories.FirstOrDefault(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)); // Tries to determine if the category exists
                if (category != null)
                {
                    // Gathering transfer details
                    Console.Write("Enter task index to move: ");
                    int fromIndex = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter new index for the task: ");
                    int toIndex = Convert.ToInt32(Console.ReadLine());

                    //Moves task with provided details
                    category.MoveTask(fromIndex, toIndex);
                }
                else
                {
                    Console.WriteLine("Category not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error moving task within category: {ex.Message}");
            }
        }

        public static void MoveTaskToAnotherCategory(List<Category> categories)
        {
            try
            {
                Console.Write("Enter source category name to move task from: ");
                string sourceCategoryName = Console.ReadLine();
                var sourceCategory = categories.FirstOrDefault(c => c.Name.Equals(sourceCategoryName, StringComparison.OrdinalIgnoreCase)); // Tries to determine if the category exists
                if (sourceCategory != null)
                {
                    Console.Write("Enter task index to move: ");
                    int taskIndex = Convert.ToInt32(Console.ReadLine());
                    if (taskIndex >= 0 && taskIndex < sourceCategory.TaskCount) // Tries to check if the tasks exists
                    {
                        Console.Write("Enter destination category name to move task to: ");
                        string destCategoryName = Console.ReadLine();
                        var destCategory = categories.FirstOrDefault(c => c.Name.Equals(destCategoryName, StringComparison.OrdinalIgnoreCase)); // Tries to determine if the category exists
                        if (destCategory != null)
                        {
                            var task = sourceCategory.GetTask(taskIndex); // First get the Task object to move
                            sourceCategory.DeleteTask(taskIndex); // Then delete said Task from the source category
                            destCategory.AddTask(task); // Finally add Task into the destination category
                        }
                        else
                        {
                            Console.WriteLine("Destination category not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid task index.");
                    }
                }
                else
                {
                    Console.WriteLine("Source category not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error moving task between categories: {ex.Message}");
            }
        }

        public static void HighlightTask(List<Category> categories)
        {
            try
            {
                Console.Write("Enter category name to highlight task: ");
                string categoryName = Console.ReadLine();
                var category = categories.FirstOrDefault(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)); // Tries to determine if the category exists
                if (category != null)
                {
                    Console.Write("Enter task index to highlight: ");
                    int taskIndex = Convert.ToInt32(Console.ReadLine());
                    if (taskIndex >= 0 && taskIndex < category.TaskCount)
                    {
                        var task = category.GetTask(taskIndex);
                        task.IsImportant = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid task index.");
                    }
                }
                else
                {
                    Console.WriteLine("Category not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error highlighting task: {ex.Message}");
            }
        }
    }

    // MenuOption enumeration
    public enum MenuOption
    {
        AddCat = 1,
        DeleteCat = 2,
        AddTask = 3,
        DeleteTask = 4,
        MoveWithin = 5,
        MoveTo = 6,
        Highlight = 7,
        Exit = 8
    }

    // Actual program
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of categories
            List<Category> categories = new List<Category>();

            // While the user hasn't quit yet...
            while (true)
            {
                // Create UI
                Console.Clear();
                Console.WriteLine(new string(' ', 12) + "CATEGORIES");
                Console.WriteLine(new string(' ', 10) + new string('-', 94));
                Console.WriteLine("{0,10}|{1,-30}|{2,-30}|{3,-30}|", "Item #", "Task", "Due Date", "Importance");
                Console.WriteLine(new string(' ', 10) + new string('-', 94));

                // Printing out list of categories and tasks within
                foreach (var category in categories)
                {
                    Console.WriteLine("{0,-10} {1}", "Category:", category.Name);
                    for (int i = 0; i < category.TaskCount; i++)
                    {
                        var task = category.GetTask(i);
                        Console.Write("{0,10}|", i);
                        if (task.IsImportant)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write("{0,-30}|{1,-30}|{2,-30}|", task.Name, task.DueDate.ToString("yyyy-MM-dd"), task.IsImportant ? "Important" : "Normal");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    Console.WriteLine(new string(' ', 10) + new string('-', 94));
                }

                // Printing out menu options
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add new category");
                Console.WriteLine("2. Delete existing category");
                Console.WriteLine("3. Add new task");
                Console.WriteLine("4. Delete existing task");
                Console.WriteLine("5. Move task within category");
                Console.WriteLine("6. Move task to another category");
                Console.WriteLine("7. Highlight task");
                Console.WriteLine("8. Exit");

                // User input
                MenuOption choice = (MenuOption)Convert.ToInt32(Console.ReadLine());

                // Switch statement for each menu option - each case has a try-catch for seamless error-handling
                switch (choice)
                {
                    case MenuOption.AddCat:
                        CategoryManager.AddCategory(categories);
                        break;
                    case MenuOption.DeleteCat:
                        CategoryManager.DeleteCategory(categories);
                        break;
                    case MenuOption.AddTask:
                        CategoryManager.AddTask(categories);
                        break;
                    case MenuOption.DeleteTask:
                        CategoryManager.DeleteTask(categories);
                        break;
                    case MenuOption.MoveWithin:
                        CategoryManager.MoveTaskWithinCategory(categories);
                        break;
                    case MenuOption.MoveTo:
                        CategoryManager.MoveTaskToAnotherCategory(categories);
                        break;
                    case MenuOption.Highlight:
                        CategoryManager.HighlightTask(categories);
                        break;
                    case MenuOption.Exit:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    } 
}

