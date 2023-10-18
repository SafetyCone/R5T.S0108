using System;

using R5T.T0132;


namespace R5T.S0108
{
    [FunctionalityMarker]
    public partial interface IScripts : IFunctionalityMarker
    {
        public void Open_DotnetRuntimeDirectory()
        {
            /// Inputs.
            var dotnetRuntimeDirectoryPath =
                Instances.DotnetRuntimeDirectoryPaths.AspNetCoreApp_RuntimesDirectoryPath
                ;


            /// Run.
            Instances.WindowsExplorerOperator.Open(
                dotnetRuntimeDirectoryPath);
        }
    }
}
