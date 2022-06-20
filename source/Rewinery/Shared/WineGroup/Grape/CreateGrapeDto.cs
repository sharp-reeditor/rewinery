﻿namespace Rewinery.Shared.WineGroup.Grape
{
#pragma warning disable CS8618
    public class CreateGrapeDto
    {
        /// <summary>
        /// Grape sort name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Grape icon
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Cost of grape for production one liter of wine
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The category which includes grapes by color
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Subcategory which includes grapes by sugar content
        /// </summary>
        public int SubcategoryId { get; set; }
    }
}
