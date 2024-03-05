using OpenCodeDev.NetCMS.Tools.ContainerPacking.Entities;
using System.Collections.Generic;

namespace OpenCodeDev.NetCMS.Tools.ContainerPacking.Algorithms
{
	public abstract class AlgorithmBase
	{
		public abstract ContainerPackingResult Run(Container container, List<Item> items);
	}
}