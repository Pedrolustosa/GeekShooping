using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable
namespace GeekShopping.ProductAPI.Model
{
    /// <summary>
    /// The product.
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Gets or Sets the name.
        /// </summary>
        [Required]
        [StringLength(150)]
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets the price.
        /// </summary>
        [Required]
        [Range(1,10000)]
        [Column("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets the description.
        /// </summary>
        [StringLength(500)]
        [Column("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets the category.
        /// </summary>
        [StringLength(50)]
        [Column("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets the image URL.
        /// </summary>
        [StringLength(300)]
        [Column("image_url")]
        public string ImageURL { get; set; }
    }
}
