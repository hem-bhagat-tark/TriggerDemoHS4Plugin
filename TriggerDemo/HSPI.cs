using HomeSeer.Jui.Views;
using HomeSeer.PluginSdk;
using HSPI_TriggerDemo.Triggers;
using System;
using static HSPI_TriggerDemo.Constants.Plugin;

namespace HSPI_TriggerDemo
{
    public class HSPI : AbstractPlugin
    {
        public override string Id => PLUGIN_ID;

        public override string Name => PLUGIN_NAME;

        public HSPI()
        {
        }

        protected override void BeforeReturnStatus()
        {
        }

        protected override void Initialize()
        {
            TriggerTypes.AddTriggerType(typeof(OldTrigger));
            TriggerTypes.AddTriggerType(typeof(NewTrigger));
        }

        protected override bool OnSettingChange(string pageId, AbstractView currentView, AbstractView changedView)
        {
            return true;
        }
    }
}
