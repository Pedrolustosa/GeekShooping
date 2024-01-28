using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model.Base
{
    /// <summary>
    /// The base entity.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Gets or Sets the id.
        /// </summary>
        [Key]
        [Column("id")]
        public long Id { get; set; }
    }
}
