using System.Runtime.Serialization;

namespace Netcore.Web.Api.Model.Abstract
{
    public abstract class BaseModel
    {
        public bool Success
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        } = string.Empty;

        public string SubStatus
        {
            get;
            set;
        } = string.Empty;

        public int? Code
        {
            get;
            set;
        }

        public string Message
        {
             get;
            set;
        } = string.Empty;

        public string Token
        {
            get;
            set;
        } = string.Empty;
        public int? Total { get; set; }
        public int? Pages { get; set; }
    }
}