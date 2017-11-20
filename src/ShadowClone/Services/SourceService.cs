using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests.Unit.ShadowClone")]
namespace ShadowClone.Services
{
    internal class SourceService
    {
        public bool GetSourceDirectory() => true;
    }
}
