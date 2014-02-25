using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace NuGet
{
	[ContractClass(typeof(PackageManagerContractClass))]
	public interface IPackageManager
	{
		IPackagePathResolver PathResolver { get; }
	}

	[ContractClassFor(typeof(IPackageManager))]
	[ExcludeFromCodeCoverage]
	internal abstract class PackageManagerContractClass : IPackageManager
	{
		IPackagePathResolver IPackageManager.PathResolver
		{
			get
			{
				Contract.Ensures(Contract.Result<IPackagePathResolver>() != null);
				throw new NotImplementedException();
			}
		}
	}
}
