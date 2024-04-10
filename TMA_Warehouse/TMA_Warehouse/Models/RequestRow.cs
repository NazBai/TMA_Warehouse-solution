﻿namespace TMA_Warehouse.Models
{
    public class RequestRow
    {
        public int Request_Row_ID { get; set; }
        public int Request_ID { get; set; }
        public int Item_ID { get; set; }
        public string Unit_of_measurement { get; set; }
        public int Quantity { get; set; }
        public decimal Price_without_VAT { get; set; }
        public string Comment { get; set; }
        public Request Request { get; set; }
    }
}
