﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
//using System.Web.Http;
using System.Net.Http.Headers;
using System.Text;
//using SPHE.CT;
//using SPHE.CT.Common.Helpers;
//using SPHE.CT.Common.Extensions;
//using SPHE.CT.Common.Filters;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace TestLibrary
{
      public class CTControllerBase //: //AsyncController
    {
        //private const string _CYPHER_PURPOSE_ENCRYPTED_COOKIE = "c00k13M0nst3r";
        //private const string _CYPHER_PURPOSE_ENCRYPTED_VALUE = "v0st0ck1c3";
        //private string _EncryptKey(string plainText, string purpose)
        //{
        //    var plainByte = Encoding.UTF8.GetBytes(plainText);
        //    var cypherByte = MachineKey.Protect(plainByte, purpose);
        //    var cypherText = Convert.ToBase64String(cypherByte);
        //    return cypherText;
        //}
        //private string _DecryptKey(string cypherText, string purpose)
        //{
        //    var cypherByte = Convert.FromBase64String(cypherText);
        //    var plainByte = MachineKey.Unprotect(cypherByte, purpose);
        //    var plainText = Encoding.UTF8.GetString(plainByte);
        //    return plainText;
        //}

        //public bool IsDevelopmentEnviornment
        //{
        //    get
        //    {
        //        if (this.Request.IsLocal)
        //        {
        //            return true;
        //        }
        //        else
        //        {
                    
        //                return false;
                    
        //        }
        //    }
        //}

       

        //public string CurrentUser
        //{
        //    get
        //    {
        //        return User.Identity.Name;
        //    }
        //}
        //public string CurrentUserIP
        //{
        //    get
        //    {
        //        return Request.UserHostAddress;
        //    }
        //}
        //public string GetCookie(string cookieName)
        //{
        //    if (this.HasCookie(cookieName))
        //    {
        //        return this.HttpContext.Request.Cookies.Get(cookieName).Value;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //public bool HasCookie(string cookieName)
        //{
        //    return this.HttpContext.Request.Cookies[cookieName] != null;
        //}
        //public string GetEncryptedCookie(string cookieName)
        //{
        //    var cypherText = this.GetCookie(cookieName);
        //    return _DecryptKey(cypherText, _CYPHER_PURPOSE_ENCRYPTED_COOKIE);
        //}
        //public string EncryptValue(string keyValue)
        //{
        //    return _EncryptKey(keyValue, _CYPHER_PURPOSE_ENCRYPTED_VALUE);
        //}
        //public string DecryptValue(string keyValue)
        //{
        //    return _DecryptKey(keyValue, _CYPHER_PURPOSE_ENCRYPTED_VALUE);
        //}
        //public string EncryptUserValue(string keyValue)
        //{
        //    return _EncryptKey(keyValue, this.CurrentUser);
        //}
        //public string DecryptUserValue(string keyValue)
        //{
        //    return _DecryptKey(keyValue, this.CurrentUser);
        //}

        //public void SetEncryptedCookie(string cookieName, string cookieValue, bool isHttpOnly = true)
        //{
        //    cookieValue = _EncryptKey(cookieValue, _CYPHER_PURPOSE_ENCRYPTED_COOKIE);
        //    this.SetCookie(cookieName, cookieValue, isHttpOnly);
        //}
        //public void SetCookie(string cookieName, string cookieValue, bool isHttpOnly = true)
        //{
        //    if (this.HasCookie(cookieName))
        //    {
        //        this.HttpContext.Response.Cookies.Remove(cookieName);
        //    }
        //    HttpCookie cookie = new HttpCookie(cookieName);
        //    cookie.HttpOnly = isHttpOnly;
        //    if (this.IsDevelopmentEnviornment != true)
        //    {
        //        cookie.Secure = true;
        //    }
        //    this.HttpContext.Response.Cookies.Add(cookie);
        //}


        //protected string GetHeader(string key)
        //{
        //    IEnumerable<string> values = this.GetHeaderValues(key);
        //    if (values != null)
        //    {
        //        return values.FirstOrDefault();
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //protected IEnumerable<string> GetHeaderValues(string key)
        //{
        //    try
        //    {
        //        return this.Request.Headers.GetValues(key);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //protected Dictionary<string, string> GetQueryStringsDictionary()
        //{
        //    return this.GetQueryStrings().ToDictionary(kv => kv.Key, kv => kv.Value, StringComparer.OrdinalIgnoreCase);
        //}
        //protected List<KeyValuePair<string, string>> GetQueryStrings()
        //{
        //    return this.Request.QueryString.AllKeys.Select(key => new KeyValuePair<string, string>(key, this.Request.QueryString[key.ToString()])).ToList();
        //}

        ////ValidateAjaxJsonCall added by pshukla on Jan 14 2016
        ////[ValidateAJAXJSONCall()]
        //protected override JsonResult Json(object data, string contentType, Encoding contentEncoding)
        //{
        //    try
        //    {
        //        return new JsonResult
        //        {
        //            Data = data,
        //            ContentType = contentType,
        //            ContentEncoding = contentEncoding,
        //            MaxJsonLength = int.MaxValue
        //        };
        //    }
        //    catch
        //    {
        //        return new JsonResult
        //        {
        //            Data = "Error",
        //            ContentType = contentType,
        //            ContentEncoding = contentEncoding
        //        };
        //    }
        //}
        ////ValidateAjaxJsonCall added by pshukla on Jan 14 2016
        ////[ValidateAJAXJSONCall()]
        //protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        //{
        //    try
        //    {
        //        return new JsonResult
        //        {
        //            Data = data,
        //            ContentType = contentType,
        //            ContentEncoding = contentEncoding,
        //            MaxJsonLength = int.MaxValue,
        //            JsonRequestBehavior = behavior
        //        };
        //    }
        //    catch
        //    {
        //        return new JsonResult
        //        {
        //            Data = "Error",
        //            ContentType = contentType,
        //            ContentEncoding = contentEncoding,
        //            JsonRequestBehavior = behavior
        //        };
        //    }
        //}
        //[Obsolete]
        //protected PartialViewResult ReturnGridView(string ViewName, object Model, int Count, int MaxCount = 2000)
        //{
        //    if (Model == null || Count == 0)
        //    {
        //        return base.PartialView("_NoResults");
        //    }
        //    else if (Count > MaxCount)
        //    {
        //        return base.PartialView("_TooManyResults", Count);
        //    }
        //    else
        //    {
        //        return base.PartialView(ViewName, Model);
        //    }
        //}
        
        //protected void LogError(string Source, System.Exception Exc, object ErrStructure = null)
        //{
        //    string vState1 = "";
        //    string vState2 = "";
        //    Newtonsoft.Json.JsonSerializer vSerZr = new Newtonsoft.Json.JsonSerializer();

        //    //Gather Host Data
        //    string vHost_Name = System.Net.Dns.GetHostName();
        //    string vHost_Type = "";// EnviornConfig.GetCurrentEnviornType().ToString();
        //    string vHost_IP = System.Net.Dns.GetHostAddresses(vHost_Name).GetValue(0).ToString();
        //    string vHost_Url = HttpContext.Request.Url.AbsoluteUri;

        //    //Gather Client Data
        //    string vClient_Name = "NONE";
        //    if ((HttpContext.User != null))
        //    {
        //        vClient_Name = HttpContext.User.Identity.Name;
        //    }
        //    string vClient_IP = HttpContext.Request.UserHostAddress;
        //    string vClient_Host = HttpContext.Request.UserHostName;
        //    string vClient_Agent = HttpContext.Request.UserAgent;

        //    dynamic vNfoObj = new
        //    {
        //        ClientName = vClient_Name,
        //        ClientAgent = vClient_Agent,
        //        ClientIP = vClient_IP,
        //        ClientHost = vClient_Host,
        //        HostName = vHost_Name,
        //        HostType = vHost_Type,
        //        HostIP = vHost_IP,
        //        HostUrl = vHost_Url,
        //        ErrMsg = Exc.Message
        //    };

        //    vState1 = JsonConvert.SerializeObject(vNfoObj);

        //    if (((ErrStructure != null)))
        //    {
        //        vState2 = JsonConvert.SerializeObject(ErrStructure);
        //    }
        //    //AppLogger.Log(Source, Exc.Message, vState1, vState2, true);
        //}
        //protected void LogSkinnyFBError(string Source, System.Exception Exc, object ErrStructure = null)
        //{
        //    string vState1 = "";
        //    string vState2 = "";
        //    Newtonsoft.Json.JsonSerializer vSerZr = new Newtonsoft.Json.JsonSerializer();

        //    //Gather Host Data
        //    string vHost_Name = System.Net.Dns.GetHostName();
        //    string vHost_Type = "";// EnviornConfig.GetCurrentEnviornType().ToString();
        //    string vHost_IP = System.Net.Dns.GetHostAddresses(vHost_Name).GetValue(0).ToString();
        //    string vHost_Url = HttpContext.Request.Url.AbsoluteUri;

        //    //Gather Client Data
        //    string vClient_Name = "NONE";
        //    if ((HttpContext.User != null))
        //    {
        //        vClient_Name = HttpContext.User.Identity.Name;
        //    }
        //    string vClient_IP = HttpContext.Request.UserHostAddress;
        //    string vClient_Host = HttpContext.Request.UserHostName;
        //    string vClient_Agent = HttpContext.Request.UserAgent;

        //    dynamic vNfoObj = new
        //    {
        //        ClientName = vClient_Name,
        //        ClientAgent = vClient_Agent,
        //        ClientIP = vClient_IP,
        //        ClientHost = vClient_Host,
        //        HostName = vHost_Name,
        //        HostType = vHost_Type,
        //        HostIP = vHost_IP,
        //        HostUrl = vHost_Url,
        //        ErrMsg = Exc.Message
        //    };

        //    vState1 = JsonConvert.SerializeObject(vNfoObj);

        //    if (((ErrStructure != null)))
        //    {
        //        vState2 = JsonConvert.SerializeObject(ErrStructure);
        //    }
        //    //AppLogger.Log(Source, Exc.InnerException.InnerException != null ? Exc.InnerException.InnerException.ToString() : Exc.Message, vState1, Exc.StackTrace.ToString(), true);

        //    if (Exc.InnerException != null && Exc.InnerException.InnerException != null)
        //    {

        //       // AppLogger.Log(Source, Exc.InnerException.InnerException.ToString(), vState1, Exc.StackTrace.ToString(), true);

        //    }
        //    else
        //    {
        //        //AppLogger.Log(Source, Exc.Message, vState1, Exc.StackTrace.ToString(), true);
        //    }

        //}
    }
}