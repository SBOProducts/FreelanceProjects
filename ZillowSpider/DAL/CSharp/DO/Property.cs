// CREATED BY: Nathan Townsend - Small Business Online, LLC
// CREATED DATE: 10/26/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.ComponentModel.DataAnnotations;

namespace ZillowDownloadConsole.DO.dbo
{
    /// <summary>
    /// Encapsulates a row of data in the Property table
    /// </summary>
    public partial class PropertyDO
    {

        public virtual Int32 PropertyId {get; set;}
        public virtual Int32 PageId {get; set;}
        public virtual String ArticleHtml {get; set;}
        public virtual String Lat {get; set;}
        public virtual String Long {get; set;}
        public virtual String PhotoUrl {get; set;}
        public virtual String PhotoCaption {get; set;}
        public virtual String Price {get; set;}
        public virtual String SoldDate {get; set;}
        public virtual String Zestimate {get; set;}
        public virtual String PriceSQFt {get; set;}
        public virtual String Address {get; set;}
        public virtual String PropertyData {get; set;}
        public virtual String LotSize {get; set;}
        public virtual String YearBuilt {get; set;}

    }
}