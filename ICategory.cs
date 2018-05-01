using Hyperion.Pf.Entity;

namespace Pixstock.Common.Model
{
    public interface ICategory : IEntity<long>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string Name { get; set; }
    }
}