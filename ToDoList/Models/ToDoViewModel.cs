namespace ToDoList.Models
{
    public class ToDoViewModel
    {
        public Filters Filters { get; set; } = null;
        public List<Status> Statuses { get; set; } = null;
        public List<Category> Categories { get; set; } = null;
        public Dictionary<string, string> DueFilters { get; set; } = null;
        public List<ToDo> Tasks { get; set; } = null;
        public ToDo CurrentTask { get; set; } = null; //used for Add
    }
}
