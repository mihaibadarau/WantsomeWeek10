namespace Week10
{
    public class Student<T> where T : class
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
