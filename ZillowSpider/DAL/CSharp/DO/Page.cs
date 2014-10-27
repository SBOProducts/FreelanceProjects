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
    /// Encapsulates a row of data in the Page table
    /// </summary>
    public partial class PageDO
    {

        public virtual Int32 PageId {get; set;}
        public virtual String Url {get; set;}
        public virtual DateTime DownloadDate {get; set;}
        public virtual String Html {get; set;}

    }
}