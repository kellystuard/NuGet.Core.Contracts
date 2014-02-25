using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace NuGet
{
	[ContractClass(typeof(PackagePathResolverContractClass))]
	public interface IPackagePathResolver
	{
		string GetInstallPath(IPackage package);
	}

	[ContractClassFor(typeof(IPackagePathResolver))]
	[ExcludeFromCodeCoverage]
	internal abstract class PackagePathResolverContractClass : IPackagePathResolver
	{
		string IPackagePathResolver.GetInstallPath(IPackage package)
		{
			Contract.Ensures(Contract.Result<string>() != null);
			throw new NotImplementedException();
		}
	}
}
