namespace OrderManagment.Models
{
    // Модель для заказа
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderEquipment> Equipments { get; set; } = new List<OrderEquipment>();
    }
}
