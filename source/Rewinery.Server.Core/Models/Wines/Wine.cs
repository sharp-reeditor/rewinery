﻿using Rewinery.Server.Core.Models.Base;

namespace Rewinery.Server.Core.Models.Wines
{
    #pragma warning disable CS8618
    public class Wine : BaseEntity
    {
        /// <summary>
        /// Information about the user who owns this recipe
        /// </summary>
        public ApplicationUser Owner { get; set; }

        /// <summary>
        /// Wine name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Information about wine
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Wine icon
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Wine price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Information about grape used in wine
        /// </summary>
        public Grape Grape { get; set; }

        /// <summary>
        /// Ingredient used in wine
        /// </summary>
        public ICollection<Ingredient> Ingredients { get; set; }

        /// <summary>
        /// Collection of the comment to this recipe
        /// </summary>
        public ICollection<Comment>? Comments { get; set; }

        /// <summary>
        /// Availability of the wine recipe (This recipe is available to everyone or private)
        /// </summary>
        public bool Public { get; set; }
    }
}
