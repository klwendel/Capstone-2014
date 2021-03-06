﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.Farouche.Commons;
using com.Farouche.DataAccess;
using System.Data.SqlClient;

//Author: 
//Date Created: 3/28/14
//Last Modified: 4/05/14
//Last Modified By: Adam Chandler

/*
*                               Changelog
* Date         By          Ticket          Version         Description
* 4/05/14       Adam                                        Removed InitializedReport 
* 3/28/14       Adam                                        Linked InitializedReport to DAL
* 
*                                                         
*/


namespace com.Farouche.BusinessLogic
{
    class ReportManager : DatabaseConnection
    {
        private readonly SqlConnection _connection = GetInventoryDbConnection();
        //Gets all the data for the reorderReport


        //Do not use use getReorders in ReorderManager
        public List<Reorder> InitializeReport(int vendorId) 
        {
            //if (vendorId == null)
            //{
            //    throw new ArgumentNullException("VendorID cannot be empty");
            //}
            //return ReportDAL.GetReorderReportData(vendorId, _connection);
            throw new ApplicationException("Removed");
        }



        
    }
}
