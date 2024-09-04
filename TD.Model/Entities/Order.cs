using Infrastructure.Model;

namespace TD.Model.Entities
{
    public class Order:IEntity

    {
        public int OrderId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime OrderStartDate { get; set; }
        public DateTime OrderEndDate { get; set; }

        public bool OrderCompleted { get; set; }
        public bool Active { get; set; }

        public bool OrderImportant { get; set; }

        public DateTime OrderAlert { get; set; }

    }
}
