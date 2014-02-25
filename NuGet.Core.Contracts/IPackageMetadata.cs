using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace NuGet
{
	[ContractClass(typeof(PackageMetadataContractClass))]
	public interface IPackageMetadata
	{
		string Id { get; }
		SemanticVersion Version { get; }
	}

	[ContractClassFor(typeof(IPackageMetadata))]
	[ExcludeFromCodeCoverage]
	internal abstract class PackageMetadataContractClass : IPackageMetadata
	{
		string IPackageMetadata.Id
		{
			get
			{
				Contract.Ensures(Contract.Result<string>() != null);
				throw new NotImplementedException();
			}
		}

		SemanticVersion IPackageMetadata.Version
		{
			get
			{
				Contract.Ensures(Contract.Result<SemanticVersion>() != null);
				throw new NotImplementedException();
			}
		}
	}
}
