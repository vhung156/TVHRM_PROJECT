using System;
using System.Collections.Generic;
using System.Text;

namespace BarcodeLib
{
    interface IBarcode
    {
        string Encoded_Value
        {
            get;
        }//Encoded_Value

        string RawData
        {
            get;
        }//Raw_Data

        List<string> Errors
        {
            get;
        }//Errors

    }//interface

    /// <summary>
    ///  Barcode interface for symbology layout.
    ///  Written by: Brad Barnhill
    /// </summary>
    
}//namespace
