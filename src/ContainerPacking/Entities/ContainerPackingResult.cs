﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCodeDev.NetCMS.Tools.ContainerPacking.Entities
{
	/// <summary>
	/// The container packing result.
	/// </summary>
	[DataContract]
	public class ContainerPackingResult
	{
		#region Constructors

		public ContainerPackingResult()
		{
			this.AlgorithmPackingResults = new List<AlgorithmPackingResult>();
		}

		#endregion Constructors

		#region Public Properties

		/// <summary>
		/// Gets or sets the container ID.
		/// </summary>
		/// <value>
		/// The container ID.
		/// </value>
		[DataMember]
		public object ContainerID { get; set; }

		[DataMember]
		public List<AlgorithmPackingResult> AlgorithmPackingResults { get; set; }
        public T GetID<T>() => (T)ContainerID;

        #endregion Public Properties
    }
}