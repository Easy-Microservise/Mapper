﻿using System.Collections;
using System.Collections.Generic;

namespace EasyMicroservices.Mapper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMapperProviderSync
    {
        /// <summary>
        /// map an object to another object
        /// </summary>
        /// <typeparam name="TFrom">map from object type</typeparam>
        /// <typeparam name="TTo">map to object type</typeparam>
        /// <param name="fromObject">object to map</param>
        /// <param name="uniqueIdentity"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns>mapped object</returns>
        TTo Map<TFrom, TTo>(TFrom fromObject = default, string uniqueIdentity = default, string language = default, params object[] parameters);
        /// <summary>
        /// map an object to another object
        /// </summary>
        /// <typeparam name="TTo">map to object type</typeparam>
        /// <param name="fromObject">object to map</param>
        /// <param name="uniqueIdentity"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns>mapped object</returns>
        TTo Map<TTo>(object fromObject, string uniqueIdentity = default, string language = default, params object[] parameters);
        /// <summary>
        /// map enumerable to a list
        /// </summary>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="fromObject"></param>
        /// <param name="uniqueIdentity"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        List<TTo> MapToList<TTo>(IEnumerable fromObject, string uniqueIdentity = default, string language = default, params object[] parameters);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="fromObject"></param>
        /// <param name="uniqueIdentity"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Dictionary<TFrom, TTo> MapToDictionary<TFrom, TTo>(IEnumerable<TFrom> fromObject, string uniqueIdentity = default, string language = default, params object[] parameters);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="fromObject"></param>
        /// <param name="uniqueIdentity"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        List<TTo> MapSingleToList<TTo>(object fromObject, string uniqueIdentity = default, string language = default, params object[] parameters);
        /// <summary>
        /// map a list to first item
        /// </summary>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="fromObject"></param>
        /// <param name="uniqueIdentity"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        TTo MapToFirst<TTo>(IEnumerable fromObject, string uniqueIdentity = default, string language = default, params object[] parameters);
    }
}
