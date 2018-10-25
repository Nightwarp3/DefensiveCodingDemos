using DCD.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DCD.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlaceOrder();
        }

        private static void PlaceOrder()
        {
            var customer = new Customer();
            // populate customer instance

            var order = new Order();
            // populate order instance

            //var allowSplitOrders = true;
            //var emailReceipt = true;

            var payment = new Payment();
            // populate payment instance

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders:false, emailReceipt:true);
        }
    }
}
