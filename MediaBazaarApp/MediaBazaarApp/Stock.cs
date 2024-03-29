﻿namespace MediaBazaarApp
{
    public class Stock
    {
        private int id;
        //private static int idCounter = 1;
        private string model;
        private string brand;
        private double price;
        private int quantity;
        private double height;
        private double width;
        private double depth;
        private double weight;
        private string shortDescription;
        private string location;
        private bool discontinued;
        StockManagement s;
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public string ShortDescription
        {
            get { return this.shortDescription; }
            set { this.shortDescription = value; }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        public bool Discontinued
        {
            get { return this.discontinued; }
            set { this.discontinued = value; }
        }

        public Stock(int id, string model, string brand, double price, int quantity, double height, double width, double depth, double weight, string shortDescription)
        {
            this.id = id;
            this.model = model;
            this.brand = brand;
            this.price = price;
            this.quantity = quantity;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.weight = weight;
            this.shortDescription = shortDescription;
            this.discontinued = false;

            //id = idCounter;
            //idCounter++;
        }

        public override string ToString()
        {
            return $"ID: {id} - Model: {model} - Brand: {brand} - Price: {price} - Quantity: {quantity} - Height: {height} cm. - Width: {width} cm. - Depth: {depth} cm. - Weight: {weight} kg. - Storage Location: {location} -  Description: {shortDescription}";
        }




    }
}
