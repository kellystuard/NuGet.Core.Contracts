using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.Versioning;

namespace NuGet
{
	public static class PackageExtensions
	{
		public static IEnumerable<PackageDependency> GetCompatiblePackageDependencies(this IPackageMetadata package, FrameworkName targetFramework)
		{
			Contract.Ensures(Contract.Result<IEnumerable<PackageDependency>>() != null);
			Contract.Ensures(Contract.ForAll(Contract.Result<IEnumerable<PackageDependency>>(), c => c != null));
			throw new NotImplementedException();
		}

		public static IEnumerable<IPackageFile> GetLibFiles(this IPackage package)
		{
			Contract.Ensures(Contract.Result<IEnumerable<IPackageFile>>() != null);
			Contract.Ensures(Contract.ForAll(Contract.Result<IEnumerable<IPackageFile>>(), c => c != null));
			throw new NotImplementedException();
		}
	}
}
