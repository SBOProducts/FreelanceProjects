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
    /// Provides data access methods for the Property database table
    /// </summary>
    /// <remarks>
    public partial class Property
    {
        
        /// <summary>
        /// Creates a new Property record
        /// </summary>
        public static int Create(PropertyDO DO)
        {
            SqlParameter _PageId = new SqlParameter("PageId", SqlDbType.Int);
            SqlParameter _ArticleHtml = new SqlParameter("ArticleHtml", SqlDbType.VarChar);
            SqlParameter _Lat = new SqlParameter("Lat", SqlDbType.VarChar);
            SqlParameter _Long = new SqlParameter("Long", SqlDbType.VarChar);
            SqlParameter _PhotoUrl = new SqlParameter("PhotoUrl", SqlDbType.VarChar);
            SqlParameter _PhotoCaption = new SqlParameter("PhotoCaption", SqlDbType.VarChar);
            SqlParameter _Price = new SqlParameter("Price", SqlDbType.VarChar);
            SqlParameter _SoldDate = new SqlParameter("SoldDate", SqlDbType.VarChar);
            SqlParameter _Zestimate = new SqlParameter("Zestimate", SqlDbType.VarChar);
            SqlParameter _PriceSQFt = new SqlParameter("PriceSQFt", SqlDbType.VarChar);
            SqlParameter _Address = new SqlParameter("Address", SqlDbType.VarChar);
            SqlParameter _PropertyData = new SqlParameter("PropertyData", SqlDbType.VarChar);
            SqlParameter _LotSize = new SqlParameter("LotSize", SqlDbType.VarChar);
            SqlParameter _YearBuilt = new SqlParameter("YearBuilt", SqlDbType.VarChar);
            
            _PageId.Value = DO.PageId;
            _ArticleHtml.Value = DO.ArticleHtml;
            _Lat.Value = DO.Lat;
            _Long.Value = DO.Long;
            _PhotoUrl.Value = DO.PhotoUrl;
            _PhotoCaption.Value = DO.PhotoCaption;
            _Price.Value = DO.Price;
            _SoldDate.Value = DO.SoldDate;
            _Zestimate.Value = DO.Zestimate;
            _PriceSQFt.Value = DO.PriceSQFt;
            _Address.Value = DO.Address;
            _PropertyData.Value = DO.PropertyData;
            _LotSize.Value = DO.LotSize;
            _YearBuilt.Value = DO.YearBuilt;
            
            SqlParameter[] _params = new SqlParameter[] {
                _PageId,
                _ArticleHtml,
                _Lat,
                _Long,
                _PhotoUrl,
                _PhotoCaption,
                _Price,
                _SoldDate,
                _Zestimate,
                _PriceSQFt,
                _Address,
                _PropertyData,
                _LotSize,
                _YearBuilt
            };

            return DataCommon.ExecuteScalar("[dbo].[Property_Insert]", _params, "dbo");
            
        }


        /// <summary>
        /// Updates a Property record and returns the number of records affected
        /// </summary>
        public static int Update(PropertyDO DO)
        {
            SqlParameter _PropertyId = new SqlParameter("PropertyId", SqlDbType.Int);
            SqlParameter _PageId = new SqlParameter("PageId", SqlDbType.Int);
            SqlParameter _ArticleHtml = new SqlParameter("ArticleHtml", SqlDbType.VarChar);
            SqlParameter _Lat = new SqlParameter("Lat", SqlDbType.VarChar);
            SqlParameter _Long = new SqlParameter("Long", SqlDbType.VarChar);
            SqlParameter _PhotoUrl = new SqlParameter("PhotoUrl", SqlDbType.VarChar);
            SqlParameter _PhotoCaption = new SqlParameter("PhotoCaption", SqlDbType.VarChar);
            SqlParameter _Price = new SqlParameter("Price", SqlDbType.VarChar);
            SqlParameter _SoldDate = new SqlParameter("SoldDate", SqlDbType.VarChar);
            SqlParameter _Zestimate = new SqlParameter("Zestimate", SqlDbType.VarChar);
            SqlParameter _PriceSQFt = new SqlParameter("PriceSQFt", SqlDbType.VarChar);
            SqlParameter _Address = new SqlParameter("Address", SqlDbType.VarChar);
            SqlParameter _PropertyData = new SqlParameter("PropertyData", SqlDbType.VarChar);
            SqlParameter _LotSize = new SqlParameter("LotSize", SqlDbType.VarChar);
            SqlParameter _YearBuilt = new SqlParameter("YearBuilt", SqlDbType.VarChar);
            
            _PropertyId.Value = DO.PropertyId;
            _PageId.Value = DO.PageId;
            _ArticleHtml.Value = DO.ArticleHtml;
            _Lat.Value = DO.Lat;
            _Long.Value = DO.Long;
            _PhotoUrl.Value = DO.PhotoUrl;
            _PhotoCaption.Value = DO.PhotoCaption;
            _Price.Value = DO.Price;
            _SoldDate.Value = DO.SoldDate;
            _Zestimate.Value = DO.Zestimate;
            _PriceSQFt.Value = DO.PriceSQFt;
            _Address.Value = DO.Address;
            _PropertyData.Value = DO.PropertyData;
            _LotSize.Value = DO.LotSize;
            _YearBuilt.Value = DO.YearBuilt;
            
            SqlParameter[] _params = new SqlParameter[] {
                _PropertyId,
                _PageId,
                _ArticleHtml,
                _Lat,
                _Long,
                _PhotoUrl,
                _PhotoCaption,
                _Price,
                _SoldDate,
                _Zestimate,
                _PriceSQFt,
                _Address,
                _PropertyData,
                _LotSize,
                _YearBuilt
            };

            return DataCommon.ExecuteScalar("[dbo].[Property_Update]", _params, "dbo");
        }


        /// <summary>
        /// Deletes a Property record
        /// </summary>
        public static int Delete(PropertyDO DO)
        {
            SqlParameter _PropertyId = new SqlParameter("PropertyId", SqlDbType.Int);
            
            _PropertyId.Value = DO.PropertyId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _PropertyId
            };

            return DataCommon.ExecuteScalar("[dbo].[Property_Delete]", _params, "dbo");
        }


        /// <summary>
        /// Gets all Property records
        /// </summary>
        public static PropertyDO[] GetAll()
        {
            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Property_GetAll]", new SqlParameter[] { }, "dbo");
            
            List<PropertyDO> objs = new List<PropertyDO>();
            
            while(sr.Read()){

                PropertyDO obj = new PropertyDO();
                
                obj.PropertyId = sr.GetInt32(sr.GetOrdinal("PropertyId"));
                obj.PageId = sr.GetInt32(sr.GetOrdinal("PageId"));
                obj.ArticleHtml = sr.GetString(sr.GetOrdinal("ArticleHtml"));
                obj.Lat = sr.GetString(sr.GetOrdinal("Lat"));
                obj.Long = sr.GetString(sr.GetOrdinal("Long"));
                obj.PhotoUrl = sr.GetString(sr.GetOrdinal("PhotoUrl"));
                obj.PhotoCaption = sr.GetString(sr.GetOrdinal("PhotoCaption"));
                obj.Price = sr.GetString(sr.GetOrdinal("Price"));
                obj.SoldDate = sr.GetString(sr.GetOrdinal("SoldDate"));
                obj.Zestimate = sr.GetString(sr.GetOrdinal("Zestimate"));
                obj.PriceSQFt = sr.GetString(sr.GetOrdinal("PriceSQFt"));
                obj.Address = sr.GetString(sr.GetOrdinal("Address"));
                obj.PropertyData = sr.GetString(sr.GetOrdinal("PropertyData"));
                obj.LotSize = sr.GetString(sr.GetOrdinal("LotSize"));
                obj.YearBuilt = sr.GetString(sr.GetOrdinal("YearBuilt"));
                


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects Property records by PK
        /// </summary>
        public static PropertyDO[] GetByPK(Int32 PropertyId)
        {

            SqlParameter _PropertyId = new SqlParameter("PropertyId", SqlDbType.Int);
			
            _PropertyId.Value = PropertyId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _PropertyId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Property_GetByPK]", _params, "dbo");

            List<PropertyDO> objs = new List<PropertyDO>();
			
            while(sr.Read())
            {
                PropertyDO obj = new PropertyDO();
				
                obj.PropertyId = sr.GetInt32(sr.GetOrdinal("PropertyId"));
                obj.PageId = sr.GetInt32(sr.GetOrdinal("PageId"));
                obj.ArticleHtml = sr.GetString(sr.GetOrdinal("ArticleHtml"));
                obj.Lat = sr.GetString(sr.GetOrdinal("Lat"));
                obj.Long = sr.GetString(sr.GetOrdinal("Long"));
                obj.PhotoUrl = sr.GetString(sr.GetOrdinal("PhotoUrl"));
                obj.PhotoCaption = sr.GetString(sr.GetOrdinal("PhotoCaption"));
                obj.Price = sr.GetString(sr.GetOrdinal("Price"));
                obj.SoldDate = sr.GetString(sr.GetOrdinal("SoldDate"));
                obj.Zestimate = sr.GetString(sr.GetOrdinal("Zestimate"));
                obj.PriceSQFt = sr.GetString(sr.GetOrdinal("PriceSQFt"));
                obj.Address = sr.GetString(sr.GetOrdinal("Address"));
                obj.PropertyData = sr.GetString(sr.GetOrdinal("PropertyData"));
                obj.LotSize = sr.GetString(sr.GetOrdinal("LotSize"));
                obj.YearBuilt = sr.GetString(sr.GetOrdinal("YearBuilt"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the Property Table
        /// </summary>
        public static void Truncate()
        {
            DataCommon.TruncateTable("dbo", "Property");
        }

    }
}