using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.Versioning;

namespace NuGet
{
	[ContractClass(typeof(PackageContractClass))]
	public interface IPackage : IPackageMetadata
	{
		IEnumerable<FrameworkName> GetSupportedFrameworks();
	}

	[ContractClassFor(typeof(IPackage))]
	[ExcludeFromCodeCoverage]
	internal abstract class PackageContractClass : IPackage
	{
		IEnumerable<FrameworkName> IPackage.GetSupportedFrameworks()
		{
			Contract.Ensures(Contract.Result<IEnumerable<FrameworkName>>() != null);
			Contract.Ensures(Contract.ForAll(Contract.Result<IEnumerable<FrameworkName>>(), c => c != null));
			throw new NotImplementedException();
		}

		public abstract string Id { get; }
		public abstract SemanticVersion Version { get; }
	}
}
