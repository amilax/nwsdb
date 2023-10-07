﻿//-------------------------------------------------------------------------------------
// Copyright (C) 2023, by National Water Supply and Drain Board. All right reserved.
// The information and source code contained herein is the exclusive property of 
// NWSDB and may not be disclosed, examined or reproduced in whole or in part without
// explicit written authorization from NWSDB ------------------------------------------
//-------------------------------------------------------------------------------------

using Xeptions;

namespace Nwsdb.Web.Api.Models.GSDivisions.Exceptions
{
    public class GSDivisionServiceException : Xeption
    {
        public GSDivisionServiceException(Exception innerException)
            : base(message: "GSDivision service error occured, contact support.", innerException) { }
    }
}
