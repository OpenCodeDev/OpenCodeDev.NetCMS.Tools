




## ContainerPacking
[![NuGet](https://img.shields.io/nuget/v/CromulentBisgetti.ContainerPacking.svg)](https://www.nuget.org/packages/CromulentBisgetti.ContainerPacking)

The container packing is a e-commerce tool using EB-AFIT packing algorithm to find the best shipping packages to fill for example a cart items into various available shipping boxes...

- Thanks to Erhan Baltacıoğlu for the algorithm.
- Thanks to CromulentBisgetti.ContainerPacking, we directly copied the code and adapted it to our need.

![Container packing visualization](https://github.com/OpenCodeDev/OpenCodeDev.NetCMS.Tools/blob/main/assets/packing.gif?raw=true)

### Usage
<hr/>
 
```
using OpenCodeDev.NetCMS.Tools.ContainerPacking;
using OpenCodeDev.NetCMS.Tools.ContainerPacking.Entities;

// Shipping Boxes (ID is object could be int/short/guid...) (ID, L, W, H)
// Knowing XYZ/LWH doesn't matter as long as 3 dimension values are entered.
List<Container> containers = [
    new Container(0, 39, 26, 12),   // Medium
    new Container(Guid.NewGuid(), 35, 26, 5),    // Small
    new Container(Guid.NewGuid(), 24, 16, 8)     // Extra-Small
];

List<Item> itemsToPack = [
    new Item(Guid.NewGuid(), 6, 8, 15, 4), // Small Item
    new Item(Guid.NewGuid(), 10, 10, 1, 4) // Extra Slim Item
];

// Pack the items
List<ContainerPackingResult> results = PackingService.Pack(containers, itemsToPack);

// Result will be each boxes chosen for the job.
// Those boxes also contain all item packed inside and the whole percentage portion of the packing
foreach (var result in results)
{
    Console.WriteLine($"Container: {result.GetID<Guid>()}");
    foreach (var packingResult in result.AlgorithmPackingResults)
    {
        Console.WriteLine($"Volume Packed {packingResult.PercentItemVolumePacked}%");
    }
}
Console.ReadLine();
```

### Notes
<hr />

Internally, the Pack() method will try to pack all the containers with all the items using all the requested algorithms in parallel. If you have a list of containers you want to try, but want them to run serially, then you can call Pack() with one container at a time. For example, if you want to run a large set of containers but would like to update the user interface as each one finishes, then you would want to call Pack() multiple times asynchronously and update the UI as each result returns.

