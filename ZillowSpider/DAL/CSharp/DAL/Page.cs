// CREATED BY: Nathan Townsend - Small Business Online, LLC
// CREATED DATE: 10/26/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ZillowDownloadConsole.DAL;
using ZillowDownloadConsole.DO.dbo;

namespace ZillowDownloadConsole.DAL.dbo
{
    /// <summary>
    /// Provides data access methods for the Page database table
    /// </summary>
    /// <remarks>
    public partial class Page
    {
        
        /// <summary>
        /// Creates a new Page record
        /// </summary>
        public static int Create(PageDO DO)
        {
            SqlParameter _Url = new SqlParameter("Url", SqlDbType.VarChar);
            SqlParameter _DownloadDate = new SqlParameter("DownloadDate", SqlDbType.DateTime);
            SqlParameter _Html = new SqlParameter("Html", SqlDbType.VarChar);
            
            _Url.Value = DO.Url;
            _DownloadDate.Value = DO.DownloadDate;
            _Html.Value = DO.Html;
            
            SqlParameter[] _params = new SqlParameter[] {
                _Url,
                _DownloadDate,
                _Html
            };

            return DataCommon.ExecuteScalar("[dbo].[Page_Insert]", _params, "dbo");
            
        }


        /// <summary>
        /// Updates a Page record and returns the number of records affected
        /// </summary>
        public static int Update(PageDO DO)
        {
            SqlParameter _PageId = new SqlParameter("PageId", SqlDbType.Int);
            SqlParameter _Url = new SqlParameter("Url", SqlDbType.VarChar);
            SqlParameter _DownloadDate = new SqlParameter("DownloadDate", SqlDbType.DateTime);
            SqlParameter _Html = new SqlParameter("Html", SqlDbType.VarChar);
            
            _PageId.Value = DO.PageId;
            _Url.Value = DO.Url;
            _DownloadDate.Value = DO.DownloadDate;
            _Html.Value = DO.Html;
            
            SqlParameter[] _params = new SqlParameter[] {
                _PageId,
                _Url,
                _DownloadDate,
                _Html
            };

            return DataCommon.ExecuteScalar("[dbo].[Page_Update]", _params, "dbo");
        }


        /// <summary>
        /// Deletes a Page record
        /// </summary>
        public static int Delete(PageDO DO)
        {
            SqlParameter _PageId = new SqlParameter("PageId", SqlDbType.Int);
            
            _PageId.Value = DO.PageId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _PageId
            };

            return DataCommon.ExecuteScalar("[dbo].[Page_Delete]", _params, "dbo");
        }


        /// <summary>
        /// Gets all Page records
        /// </summary>
        public static PageDO[] GetAll()
        {
            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Page_GetAll]", new SqlParameter[] { }, "dbo");
            
            List<PageDO> objs = new List<PageDO>();
            
            while(sr.Read()){

                PageDO obj = new PageDO();
                
                obj.PageId = sr.GetInt32(sr.GetOrdinal("PageId"));
                obj.Url = sr.GetString(sr.GetOrdinal("Url"));
                obj.DownloadDate = sr.GetDateTime(sr.GetOrdinal("DownloadDate"));
                obj.Html = sr.GetString(sr.GetOrdinal("Html"));
                


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects Page records by PK
        /// </summary>
        public static PageDO[] GetByPK(Int32 PageId)
        {

            SqlParameter _PageId = new SqlParameter("PageId", SqlDbType.Int);
			
            _PageId.Value = PageId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _PageId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Page_GetByPK]", _params, "dbo");

            List<PageDO> objs = new List<PageDO>();
			
            while(sr.Read())
            {
                PageDO obj = new PageDO();
				
                obj.PageId = sr.GetInt32(sr.GetOrdinal("PageId"));
                obj.Url = sr.GetString(sr.GetOrdinal("Url"));
                obj.DownloadDate = sr.GetDateTime(sr.GetOrdinal("DownloadDate"));
                obj.Html = sr.GetString(sr.GetOrdinal("Html"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the Page Table
        /// </summary>
        public static void Truncate()
        {
            DataCommon.TruncateTable("dbo", "Page");
        }

    }
}