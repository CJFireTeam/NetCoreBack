﻿using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ICiudad
    {
        Task<IResult> GetCiudad(int regionCode);
    }
}