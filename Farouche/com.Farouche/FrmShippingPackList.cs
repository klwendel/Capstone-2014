﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using com.Farouche.BusinessLogic;
using com.Farouche.Commons;

/*
*                               Changelog
* Date         By               Ticket          Version          Description
* 04/19/2014   Kaleb Wendel                                      Adjusted class to implement a singleton pattern so only one form can be instantiated.
*/

namespace com.Farouche
{
    public partial class FrmShippingPackList : Form
    {
        private readonly AccessToken _myAccessToken;
        private ShippingOrderManager _myOrderManager;
        public static FrmShippingPackList Instance;

        public FrmShippingPackList(AccessToken accToken)
        {
            InitializeComponent();
            _myAccessToken = accToken;
            _myOrderManager = new ShippingOrderManager();
            RefreshPackView();
            Instance = this;
        }// End FrmShippingPackList(.)

        private void FrmShippingPackList_Load(object sender, EventArgs e)
        {
            RefreshPackView();
        }// End FrmShippingPackList_Load(..)

        private void RefreshPackView()
        {
            PopulatePackListView(lvPackList, _myOrderManager.GetPickedOrders());
        }//End RefreshListView(..)

        private void PopulatePackListView(ListView lv, List<ShippingOrder> orderList)
        {
            _myOrderManager.Orders = orderList;
            lv.Items.Clear();
            lv.Columns.Clear();
            foreach (var order in _myOrderManager.Orders)
            {
                if (order.UserId.HasValue)
                {
                }
                else
                {
                    var item = new ListViewItem();
                    item.Text = order.ID.ToString();
                    item.SubItems.Add(order.ShippingVendorName);
                    item.SubItems.Add(order.ShippingTermDesc);
                    item.SubItems.Add(order.ShipToName);
                    item.SubItems.Add(order.ShipToAddress);
                    item.SubItems.Add(order.ShipToCity);
                    item.SubItems.Add(order.ShipToState);
                    item.SubItems.Add(order.ShipToZip);
                    item.SubItems.Add(order.Picked.ToString());
                    lv.Items.Add(item);
                }
            }
            lv.Columns.Add("OrderID");
            lv.Columns.Add("Vendor");
            lv.Columns.Add("ShipTerm");
            lv.Columns.Add("CustomerName");
            lv.Columns.Add("Address");
            lv.Columns.Add("City");
            lv.Columns.Add("State");
            lv.Columns.Add("ZipCode");
            lv.Columns.Add("Picked");
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }//End PopulatePackListView(..)

        private void btnPackComplete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedOrder = (int)this.lvPackList.SelectedIndices[0] + 1;
                ShippingOrder currentOrder = _myOrderManager.GetOrderByID(selectedOrder);
                Boolean success = _myOrderManager.UpdateShippedDate(currentOrder);
                _myOrderManager.UpdateUserId(currentOrder, _myAccessToken.UserID);
                if (success == true)
                {
                    MessageBox.Show("Now Printing Pack Slip", "Packing Complete");
                    RefreshPackView();
                    frmPrintPackReport packReport = new frmPrintPackReport(currentOrder);
                    packReport.ShowDialog();
                    packReport = null;
                }
                else
                {
                    MessageBox.Show("Cannot complete action.", "Refreshing");
                    RefreshPackView();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an order from the list", "No Order Selected");
            }
        }

        private void FrmShippingPackList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }
    }
}
