using OpenCodeDev.NetCMS.Tools.ContainerPacking.Entities;
using System.Collections.Generic;

namespace OpenCodeDev.NetCMS.Tools.ContainerPacking.Algorithms
{
	/// <summary>
	/// Interface for the packing algorithms in this project.
	/// </summary>
	public interface IPackingAlgorithm
	{
		/// <summary>
		/// Runs the algorithm on the specified container and items.
		/// </summary>
		/// <param name="container">The container.</param>
		/// <param name="items">The items to pack.</param>
		/// <returns>The algorithm packing result.</returns>
		AlgorithmPackingResult Run(Container container, List<Item> items);
	}
}