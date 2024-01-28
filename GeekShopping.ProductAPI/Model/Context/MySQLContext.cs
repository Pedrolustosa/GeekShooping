using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    /// <summary>
    /// The my SQL context.
    /// </summary>
    public class MySQLContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySQLContext"/> class.
        /// </summary>
        public MySQLContext() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MySQLContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
    }
}
