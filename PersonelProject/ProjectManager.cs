namespace PersonelProject
{
    internal partial class Program
    {
        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add(); 
            }
        }


    }
}
