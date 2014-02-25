using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.Versioning;
using NuGet.Core;

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
	}
}
