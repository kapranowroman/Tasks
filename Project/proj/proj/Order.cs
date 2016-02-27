using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class Order
    {
        public string Manager { get; set; }
        public string Customer { get; private set; }
        public List<Stage> Stages;
        public OrderStatus Status { get; set; }

        public Order (string Manager, string Customer)
        {
            this.Manager=Manager;
            this.Customer = Customer;
            this.Status = OrderStatus.NEW;
        }
        

        public void addStage(Stage item)
        {
            Stages.Add(item);
        }
        public IReadOnlyCollection<Stage> getstages()
        {
            return new ReadOnlyCollection<Stage>(Stages);

        }
        

    }
}
