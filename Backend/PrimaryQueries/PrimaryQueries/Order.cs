﻿
namespace PrimaryQueries {
    /// <summary>
    /// An Order for a Part
    /// </summary>
    class Order {
        private int orderNumber;
        private Part part;
        private Employee employee;
        private Customer customer;
        /// <summary>
        /// Creates a new Order for a Part
        /// </summary>
        /// <param name="orderNumber">The number identifying the Order</param>
        /// <param name="part">The Part being ordered</param>
        /// <param name="employee">The Employee involved in the Order</param>
        /// <param name="customer">The Customer making the Order</param>
        public Order(int orderNumber, Part part, Employee employee, Customer customer) {
            this.orderNumber = orderNumber;
            this.part = part;
            this.employee = employee;
            this.customer = customer;
        }
        /// <summary>
        /// Gets the number identifying the Order
        /// </summary>
        /// <returns>The order number</returns>
        public int GetOrderNumber() {
            return orderNumber;
        }
        /// <summary>
        /// Gets the Part being ordered
        /// </summary>
        /// <returns>The Part being ordered</returns>
        public Part GetPart() {
            return part;
        }
        /// <summary>
        /// Gets the Employee involved in the Order
        /// </summary>
        /// <returns>The Employee involved in the Order</returns>
        public Employee GetEmployee() {
            return employee;
        }
        /// <summary>
        /// Gets the Customer making the order
        /// </summary>
        /// <returns>The Customer making the order</returns>
        public Customer GetCustomer() {
            return customer;
        }
    }
}