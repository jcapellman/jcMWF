using System;
using System.Web.WebPages;

namespace jcMWF.Lib {
    public class jcMWFProvider {
        public void Activate(params object[] userAgents) {
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("classic") {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf("netscape", StringComparison.OrdinalIgnoreCase) >= 0)
            });
        }
    }
}