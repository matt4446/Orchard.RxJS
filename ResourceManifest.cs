using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.UI.Resources;

namespace Orchard.RxJS
{
    public class ResourceManifest : IResourceManifestProvider
    {

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            var mainScript = "rx";
            var jqueryRx = "rx.jQuery";

            var version = "1.0.10621.0";

            manifest.DefineScript(mainScript).SetUrl("rx.min.js").SetVersion(version);
                //.SetDependencies("jQuery")

            manifest.DefineScript("rx.aggregates").SetUrl("rx.aggregates.min.js")
                .SetDependencies(mainScript)
                .SetVersion(version);
            manifest.DefineScript("rx.coincidence").SetUrl("rx.coincidence.min.js")
                .SetDependencies(mainScript)
                .SetVersion(version);
            manifest.DefineScript("rx.joinpatterns").SetUrl("rx.joinpatterns.min.js")
                .SetDependencies(mainScript)
                .SetVersion(version);
            manifest.DefineScript("rx.time").SetUrl("rx.time.min.js")
                .SetDependencies(mainScript)
                .SetVersion(version);

            manifest.DefineScript("rx.default").SetDependencies(mainScript, "rx.time");

            manifest.DefineScript(jqueryRx).SetUrl("rx.jquery.min.js", "rx.jQuery.js")
                .SetDependencies(mainScript)
                .SetVersion(version); 

        }

    }
}
