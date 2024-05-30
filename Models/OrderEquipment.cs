﻿namespace OrderManagment.Models
{
    // Модель для связи заказа с оборудованием
    public class OrderEquipment
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public int Quantity { get; set; }
    }
}
