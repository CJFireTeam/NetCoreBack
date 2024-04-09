using System.Text.Json.Serialization;

namespace Netcore.Web.Api.Model.Abstract
{
    public abstract class GenericBaseModel<T> : BaseModel
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public T? Data
        {
            get;
            set;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<T>? DataList
        {
            get;
            set;
        }
    }
}