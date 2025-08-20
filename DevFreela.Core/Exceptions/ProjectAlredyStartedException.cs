namespace DevFreela.Core.Exceptions
{
    public class ProjectAlredyStartedException : Exception
    {
        public ProjectAlredyStartedException() : base("This project has already been started.")
        {
        }
    }
}
