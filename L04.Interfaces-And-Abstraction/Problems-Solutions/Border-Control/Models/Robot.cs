using Border_Control.Contracts;

namespace Border_Control.Models
{
    public class Robot : IRegisterable
    {
        private readonly string model;
        private readonly string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }

        public string NameOrModel => this.model;

        public string Id => this.id;
    }
}
